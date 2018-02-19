using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml.Serialization;
using FGlobus.Componentes.WinForms;
using FGlobus.Util.ExtensaoLinq;

namespace WFA_Workflow
{
    public partial class FrmPopulaPropriedadeItem : Form
    {
        public FrmPopulaPropriedadeItem()
        {
            InitializeComponent();
        }

        enum eComboBoxEdit
        {
            [XmlEnum("XmlEnum-a")]
            Item_A,
            [XmlEnum("XmlEnum-b")]
            Item_B,
            [Description("Description-c")]
            Item_C,
            [Description("Description-d")]
            Item_D
        }

        enum eImageComboBoxEdit
        {
            ImageComboBoxEdit_A,
            ImageComboBoxEdit_B,
            [Description("Description-ccccccccccc")]
            ImageComboBoxEdit_C,
            ImageComboBoxEdit_D
        }

        enum eRadioGroup
        {
            RadioGroup_1 = 'A',
            RadioGroup_2 = 'B',
            RadioGroup_3 = 'C',
            RadioGroup_4 = 'D'
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.comboBoxEdit1.AdicionarItens<eComboBoxEdit>(eComboBoxEdit.Item_A);

            this.imageComboBoxEdit1.AdicionarItens<eImageComboBoxEdit>(eImageComboBoxEdit.ImageComboBoxEdit_B);

            this.checkedComboBoxEdit1.AdicionarItens<eComboBoxEdit>(eComboBoxEdit.Item_C);

            this.radioGroup1.AdicionarItens<eRadioGroup>(eRadioGroup.RadioGroup_4);

            this.listBoxControl1.AdicionarItens<eComboBoxEdit>(eComboBoxEdit.Item_C);

            this.checkedListBoxControl1.AdicionarItens<eComboBoxEdit>(eComboBoxEdit.Item_C, eComboBoxEdit.Item_B);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.labelComboBoxEdit.Text = this.comboBoxEdit1.RetornarItem<eComboBoxEdit>().ToString();

            this.labelImageComboBoxEdit.Text = this.imageComboBoxEdit1.RetornarItem<eImageComboBoxEdit>().ToString();

            this.labelCheckedComboBoxEdit.Text = this.checkedComboBoxEdit1.RetornarItens<eComboBoxEdit>().Concatenar();

            this.labelRadioGroup.Text = this.radioGroup1.RetornarItem<eRadioGroup>().ToString();

            this.labelListBoxControl.Text = this.listBoxControl1.RetornarItem<eComboBoxEdit>().ToString();

            this.labelCheckedListBoxControl.Text = this.checkedListBoxControl1.RetornarItens<eComboBoxEdit>().Concatenar();

        }
    }

}
