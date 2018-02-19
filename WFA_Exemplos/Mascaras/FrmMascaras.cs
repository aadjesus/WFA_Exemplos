using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace WFA_Workflow.Mascaras
{
    public partial class FrmMascaras : Form
    {
        public FrmMascaras()
        {
            InitializeComponent();

            //ConditionValidationRule containsValidationRule = new ConditionValidationRule();
            //containsValidationRule.ConditionOperator = ConditionOperator.Contains;
            //containsValidationRule.Value1 = '@';
            //containsValidationRule.ErrorText = "Entre com um e-mail válido";
            //containsValidationRule.ErrorType = ErrorType.Warning;
            //dxValidationProvider1.SetValidationRule(textEditBGMX1, containsValidationRule);
            //dxValidationProvider1.SetValidationRule(textEditBGMX2, containsValidationRule);
        }

        private void textEdit1_Validated(object sender, EventArgs e)
        {
            labelControl1.Text = labelControl1.Text + "2";
        }

        private void textEdit1_Validating(object sender, CancelEventArgs e)
        {
            labelControl1.Text = labelControl1.Text + "1";
        }

        private void textEditBGMX1_EditValueChanged(object sender, EventArgs e)
        {
            //  labelControl1.Text = textEditBGMX1.EditValue.ToString();

        }

        private void textEditBGM1_EditValueChanged(object sender, EventArgs e)
        {
            //   labelControl2.Text = textEditBGM1.EditValue.ToString();
        }

        private void FrmMascaras_Load(object sender, EventArgs e)
        {

        }

        private void textEditBGMX1_Validated(object sender, EventArgs e)
        {
            //dxValidationProvider1.Validate();
        }

        private void textEditBGMX1_Validating(object sender, CancelEventArgs e)
        {
            //dxValidationProvider1.Validate();
        }

        private void textEditBGMX1_Validating_1(object sender, CancelEventArgs e)
        {
            //labelControl1.Text = textEditBGMX1.Text;
            //if (textEditBGMX1.EditValue != null)
            //    labelControl2.Text = textEditBGMX1.EditValue.ToString();
            MessageBox.Show("aaa");
        }
    }
}

