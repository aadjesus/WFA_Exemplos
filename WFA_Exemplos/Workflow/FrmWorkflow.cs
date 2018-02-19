using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using FGlobus.Componentes.WinForms;

namespace WFA_Workflow
{
    public partial class FrmWorkflow : Form
    {
        public FrmWorkflow()
        {
            InitializeComponent();


        }

        private void FrmWorkflow_Load(object sender, EventArgs e)
        {
            Inicializacao.Usuario = "MANAGER";
            Inicializacao.Sistema = "GFO";
            //WebServices.CarregarConfigWebServices(@"c:\Users\alessandro.augusto\Documents\Visual Studio\Exemplos_Meus\WFA_Exemplos\WFA_Workflow\bin\Release\BgmRodotec.Globus5.Config");

            string nomePadraoDll = "BgmRodotec.Globus5.Cadastro";

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

        private void trVwTela_DoubleClick(object sender, EventArgs e)
        {
            TreeNode treeNode = this.trVwTela.SelectedNode;
            if (treeNode.Tag != null)
            {
                MasterFormCadastro masterFormCadastro = (treeNode.Tag as MasterFormCadastro);
                
                masterFormCadastro.TopLevel = false;
                userControl11.windowsFormsHost1.Child = masterFormCadastro;
                userControl11.windowsFormsHost1.Width = masterFormCadastro.Width;
                userControl11.windowsFormsHost1.Height = masterFormCadastro.Height;
                
                masterFormCadastro.LookAndFeel.UseDefaultLookAndFeel = false;
                masterFormCadastro.FormBorderStyle = FormBorderStyle.None;
            }

        }
    }
}
