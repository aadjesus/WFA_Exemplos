using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using FGlobus.Componentes.WinForms;

namespace WFA_Workflow
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            TileItem tileItem = sender as TileItem;
            if (tileItem != null)
            {
                try
                {
                    Form formulario = Activator.CreateInstance(Type.GetType(tileItem.Tag.ToString())) as Form;
                    this.Visible = true;
                    this.ShowInTaskbar = true;
                    formulario.ShowDialog();
                }
                catch (Exception ex)
                {
                    tileItem.AppearanceItem.Normal.BackColor = Color.Red;
                    MessageBox.Show(String.Concat(ex));
                }
                finally
                {
                    this.Visible = true;
                    this.ShowInTaskbar = true;
                }
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private List<FileInfo> DirSearch(string sDir)
        {
            try
            {
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    foreach (string f in Directory.GetFiles(d, "*.cs"))
                    {
                        // lstFilesFound.Items.Add(f);
                    }
                    DirSearch(d);
                }
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }

            return null;
        }


        private void FrmPrincipal_Shown(object sender, EventArgs e)
        {
            Inicializacao.Sistema = "CTR";
            Inicializacao.Usuario = "MANAGER";
            Inicializacao.VersaoGlobusEmExecucao = FGlobus.Util.EnumeradoresUtil.eVersaoGlobus.GlobusMais;

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();

            comboBoxEdit1.Properties.Items.AddRange(DevExpress.Skins.SkinManager.Default.Skins
                .OfType<DevExpress.Skins.SkinContainer>()
                .Select(s => s.SkinName)
                .ToArray());

            //comboBoxEdit1.Properties.Items.AddRange(DevExpress.UserSkins.BonusSkins
            //    .OfType<DevExpress.Skins.SkinContainer>()
            //    .Select(s => s.SkinName)
            //    .ToArray());


            //comboBoxEdit1.Text = "GlobusMais_Clean";

            Func<string, List<FileInfo>> funcListaFileInfo = null;
            funcListaFileInfo = subDiretorios =>
            {
                return Directory.GetDirectories(subDiretorios)
                    .Aggregate(new List<FileInfo>(), (retorno, item) =>
                    {
                        retorno.AddRange(Directory.GetFiles(item, "*.cs")
                            .Select(s => new System.IO.FileInfo(s))
                            .ToArray());

                        retorno.AddRange(funcListaFileInfo(item));

                        return retorno;
                    });
            };

            this.tileGroup2.Items.Clear();

                                                  
            var listaArquivos = funcListaFileInfo(@"c: \Users\alessandro.augusto\Source\Repos\Exemplos\WFA_Exemplos\WFA_Exemplos\")
                .GroupBy(g => g.Name.Split('.').FirstOrDefault(),
                        (grupo, lista) => new
                        {
                            Name = grupo,
                            LastWriteTime = lista
                               .Max(m => m.LastWriteTime)
                        });
            var listaFormularios = this.GetType().Assembly.GetTypes()
                .Where(w => w != typeof(FrmPrincipal) &&
                            w.Name.IndexOf("Frm") >= 0
                            // && (w.BaseType == typeof(Form) ||
                            // w.BaseType == typeof(DevExpress.XtraBars.Ribbon.RibbonForm) ||
                            // w.BaseType == typeof(MasterForm) ||
                            // w.BaseType == typeof(MasterFormGlobus) ||
                            // w.BaseType == typeof(MasterFormCadastro) ||
                            // w.BaseType == typeof(XtraForm))
                            );

            listaArquivos
                .Join(listaFormularios,
                        a => a.Name,
                        b => b.Name,
                        (a, b) => new
                        {
                            a,
                            b
                        })
                .OrderByDescending(o => o.a.LastWriteTime)
                .ToList()
                .ForEach(item =>
                {
                    TileItem tileItem = new TileItem();
                    try
                    {
                        int numero = this.tileGroup2.Items.Count + 1;
                        tileItem.Tag = item.b.FullName;
                        tileItem.ItemClick += new TileItemClickEventHandler(tileItem1_ItemClick);
                        tileItem.Elements.Add(new TileItemElement()
                        {
                            TextAlignment = TileItemContentAlignment.TopLeft,
                            Text = numero.ToString("000")
                        });
                        tileItem.Elements.Add(new TileItemElement()
                        {
                            TextAlignment = TileItemContentAlignment.BottomRight,
                            Text = item.a.LastWriteTime.Date.Equals(DateTime.Now.Date)
                                ? item.a.LastWriteTime.ToShortTimeString()
                                : item.a.LastWriteTime.ToShortDateString()
                        });
                        tileItem.Elements.Add(new TileItemElement()
                        {
                            TextAlignment = TileItemContentAlignment.MiddleCenter,
                            Text = item.b.Name
                        });

                        //tileItem.IsLarge = numero == 1;
                    }
                    catch
                    {
                        tileItem.Text = item.b.FullName;
                        tileItem.AppearanceItem.Normal.BackColor = Color.Red;
                    }

                    this.tileGroup2.Items.Add(tileItem);
                });


            TileItem tileItem1 = this.tileGroup2
                .Items
                .OfType<TileItem>()
                .FirstOrDefault();
            tileItem1.IsLarge = true;
            tileItem1_ItemClick(tileItem1, null);

        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = comboBoxEdit1.Text;
            //"Pumpkin";//
        }
    }

}
