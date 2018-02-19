using System.Windows.Forms;
using FGlobus.Componentes.WinForms;

namespace WFA_Workflow
{
    public partial class FrmDataBindings : Form
    {
        public FrmDataBindings()
        {
            InitializeComponent();
        }

        MasterForm masterForm = new MasterForm();
        private void buttonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            masterForm.AbrirAguarde();            

            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.OK)
                sistemaDTOBindingSource.DataSource = Globus5.WPF.Comum.WebServices.ControleWSApp.GenericoConsultaPorChave("ValorChaveCRUD", "SistemaDTO", buttonEdit1.Text);
            //else
                //sistemaDTOBindingSource.DataSource = Globus5.WPF.Comum.WebServices.ControleWSApp.GenericoRetornarTodos("ValorChaveCRUD", "SistemaDTO")
                //    .Select(s => s as Globus5.WPF.Comum.ws.controle.SistemaDTO);

            masterForm.FecharAguarde();
        }
    }
}
