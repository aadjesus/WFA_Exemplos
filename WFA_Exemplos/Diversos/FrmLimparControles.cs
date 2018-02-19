using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.Utils.Controls;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraTab;
using FGlobus.Componentes.WinForms;

namespace WFA_Workflow
{
    public partial class FrmLimparControles : Form
    {
        public FrmLimparControles()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.LimparControles(this);
        }

        public void LimparControles(Control control, bool verificaSeLimpaCampo = false)
        {
            Dictionary<string, object[]> dictionary = new Dictionary<string, object[]>();

            dictionary.Add("SelectedIndex", new object[] { -1, false });
            dictionary.Add("Checked", new object[] { false, false });
            dictionary.Add("DateTime", new object[] { null, true });
            dictionary.Add("Time", new object[] { null, false });
            dictionary.Add("EditValue", new object[] { null, false });
            dictionary.Add("Text", new object[] { null, true });

            control.Controls
                .OfType<Control>()
                .Where(w => !String.IsNullOrEmpty(w.Name))
                .ToList()
                .ForEach(controle =>
                {
                    if (controle is PanelBase ||
                        controle is XtraTabControl ||
                        controle is Panel ||
                        controle is XtraPanel ||
                        controle is XtraScrollableControl)
                        LimparControles(controle);
                    else if (
                             //!(controle is SimpleButton) &&
                             !(controle is LookUpEditBase) &&
                             !(controle is GridControl) &&
                             !(controle is LabelControl))
                    {
                        bool pesquisaTodas = true;
                        dictionary
                            .ToList()
                            .ForEach(u =>
                            {
                                PropertyInfo propertyInfo = controle.GetType().GetProperty(u.Key);
                                object[] valores = u.Value as object[];

                                if (propertyInfo != null && pesquisaTodas)
                                {
                                    object tipoValor = controle.GetType() == typeof(PedeEmpresaBGM) ||
                                                       controle.GetType() == typeof(PedeFilialBGM) ||
                                                       controle.GetType() == typeof(PedeGaragemBGM)
                                        ? 0
                                        : valores[0];

                                    propertyInfo.SetValue(controle, tipoValor, null);

                                    pesquisaTodas = (bool)valores[1];
                                }
                            });
                    }
                });

        }
    }
}
