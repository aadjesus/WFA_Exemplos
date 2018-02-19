using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using FGlobus.Componentes.WinForms;

namespace WFA_Workflow
{
    public partial class FrmSmartViewer : MasterForm
    {
        public FrmSmartViewer()
        {

            InitializeComponent();

            
        }

        private enum eTipoTela
        {
            Pesquisas = 0,
            Cadastros = 1
        }

        private eTipoTela _tipoTela;

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            TreeNode treeNode = this.trVwTela.SelectedNode;
            if (treeNode.Tag != null)
            {
                //pnlCtrlTelaMFCadastro
                //pnlCtrlBotoesMFCadastro
                
                MasterForm masterForm = (treeNode.Tag as MasterForm);
                //this.GetType().GetMethods().FirstOrDefault() = masterForm.GetType().GetMethods().FirstOrDefault();
                //this.GetType().
                
                //BindingFlags flags = BindingFlags.Public | BindingFlags.Static;                
                //MethodInfo minfo = masterForm.GetType().GetMethod("MyMethod", flags);
                

                //MasterForm ex = (MasterForm)Delegate.CreateDelegate( typeof(MasterForm), minfo);
                //MethodInfo clone = Reflect<ICloneable>.GetMethod(x => x.Clone());

                //EventInfo evClick = this.GetType().GetEvents();// GetEvent("Click");
                //evClick.AddEventHandler(

                masterForm.GetType().GetEvents()
                    .OfType<EventInfo>()
                    .ToList()
                    .ForEach(f => 
                    {

                        //var p = new Program();
                        //var eventInfo = f;
                        //var methodInfo = f.GetType().GetMethod(f.Name);
                        //Delegate handler = Delegate.CreateDelegate(eventInfo.EventHandlerType, this, methodInfo);
                        //eventInfo.AddEventHandler(this, handler);

                        //button1.Click += new EventHandler(button1_Click);

                        // Get secret click event key
                        //FieldInfo eventClick = typeof(Control).GetField("EventClick", BindingFlags.NonPublic | BindingFlags.Static);
                        //object secret = eventClick.GetValue(null);
                        //// Retrieve the click event
                        //PropertyInfo eventsProp = typeof(Component).GetProperty("Events", BindingFlags.NonPublic | BindingFlags.Instance);
                        //EventHandlerList events = (EventHandlerList)eventsProp.GetValue(button1, null);
                        //Delegate click = events[secret];
                        //// Remove it from button1, add it to button2
                        //events.RemoveHandler(secret, click);
                        //events = (EventHandlerList)eventsProp.GetValue(button2, null);
                        //events.AddHandler(secret, click);

                    });

                panel1.Controls.Clear();
                panel1.Controls.AddRange(masterForm.Controls
                    .OfType<PanelControl>()
                    .ToArray());

                //pnlCtrlTelaMFCadastro
                //(treeNode.Tag as MasterForm).Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void FrmSmartViewer_Shown(object sender, EventArgs e)
        {
            _tipoTela = eTipoTela.Cadastros;
            string nomePadraoDll = "BgmRodotec.Globus5." + _tipoTela.ToString();

            this.trVwTela.Nodes.Clear();

            #region Popula TreeView


            this.trVwTela.Nodes.AddRange(FGlobus.Util.Util.RetornarArquivosDoWPF(eTipoArquivoWPF.DLL,"Cadastro")
                .OrderBy(o => o)
                .Aggregate(new List<TreeNode>(), (listaModulos, itemModulo) =>
                {
                    Assembly assemblyProjeto = null;
                    try
                    {
                        assemblyProjeto = Assembly.LoadFrom(itemModulo);
                        var telas = assemblyProjeto.GetTypes()
                            .Where(w => w.BaseType.FullName.Equals(typeof(MasterFormCadastro).ToString()) ||
                                        w.BaseType.FullName.Equals(typeof(MasterPanelBrowseDePesquisa).ToString()));

                        if (telas != null && telas.Count() > 0)
                        {
                            // Nivel modulo
                            TreeNode treeNodeModulo = new TreeNode(telas.First().Assembly.GetName().Name.Replace(nomePadraoDll + ".", ""));
                            treeNodeModulo.Nodes.AddRange(telas
                                .Aggregate(new List<TreeNode>(), (listaTelas, type) =>
                                {
                                    MasterForm masterForm = Activator.CreateInstance(type) as MasterForm;
                                    listaTelas.Add(new TreeNode(type.Name) { Tag = masterForm });
                                    return listaTelas;
                                })
                                .ToArray());

                            listaModulos.Add(treeNodeModulo);
                        }
                    }
                    catch { }
                    finally
                    {
                        assemblyProjeto = null;
                    }

                    return listaModulos;
                })
                .ToArray());

            #endregion


        }
    }
}
