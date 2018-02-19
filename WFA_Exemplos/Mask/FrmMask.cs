using System;
using System.Windows.Forms;

namespace WFA_Workflow.Mask
{
    public partial class FrmMask : Form
    {
        public FrmMask()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(maskedEdit1.IsValid.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // get
            if (rdoText.Checked)
                textBox1.Text = maskedEdit1.Text;
            else if (rdoValue.Checked)
                textBox1.Text = maskedEdit1.Value;
            else if (rdoMask.Checked)
                textBox1.Text = maskedEdit1.InputMask;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // set
            if (rdoText.Checked)
                maskedEdit1.Text = textBox1.Text;
            else if (rdoValue.Checked)
                maskedEdit1.Value = textBox1.Text;
            else if (rdoMask.Checked)
                maskedEdit1.InputMask = textBox1.Text;
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            txtOutput.Text = maskedInput.Text;
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            maskedInput.PromptChar = System.Convert.ToChar(txtmskPromptChar.Text);
        }

        private void maskedInput_TextChanged(object sender, EventArgs e)
        {
            if (maskedInput.MaskCompleted == true)
                lblMaskCompleted.Visible = true;
            else
                lblMaskCompleted.Visible = false;
        }

        private void chkHideMsk_CheckedChanged(object sender, EventArgs e)
        {
            maskedInput.HidePromptOnLeave = chkHideMsk.Checked;
        }

        private void chkIncludeLiteral_CheckedChanged(object sender, EventArgs e)
        {
            SetOutputFormat();
        }

        private void SetOutputFormat()
        {
            if (chkIncludeLiteral.Checked == true)
            {
                if (chkIncludePrompt.Checked == true)
                {
                    maskedInput.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                }
                else
                {
                    maskedInput.TextMaskFormat = MaskFormat.IncludeLiterals;
                }
            }
            else
            {
                if (chkIncludePrompt.Checked == true)
                {
                    maskedInput.TextMaskFormat = MaskFormat.IncludePrompt;
                }
                else
                {
                    maskedInput.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                }
            }
        }

        private void chkIncludePrompt_CheckedChanged(object sender, EventArgs e)
        {
            SetOutputFormat();
        }

        private void chkBeepErr_CheckedChanged(object sender, EventArgs e)
        {
            maskedInput.BeepOnError = chkBeepErr.Checked;
        }

        private void radMask1_CheckedChanged(object sender, EventArgs e)
        {
            maskedInput.Mask = radMask1.Text;
        }

        private void radMask2_CheckedChanged(object sender, EventArgs e)
        {
            maskedInput.Mask = radMask2.Text;
        }

        private void radMask3_CheckedChanged(object sender, EventArgs e)
        {
            maskedInput.Mask = radMask3.Text;
        }

        private void radMask4_CheckedChanged(object sender, EventArgs e)
        {
            maskedInput.Mask = radMask4.Text;
        }

        private void radMask5_CheckedChanged(object sender, EventArgs e)
        {
            maskedInput.Mask = radMask5.Text;
        }
    }
}
