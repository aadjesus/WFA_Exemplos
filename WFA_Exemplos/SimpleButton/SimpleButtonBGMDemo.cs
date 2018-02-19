using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace WFA_Workflow.SimpleButton
{
    public partial class SimpleButtonBGMDemo : DevExpress.XtraEditors.SimpleButton
    {
        public SimpleButtonBGMDemo()
        {
            InitializeComponent();
        }

        public SimpleButtonBGMDemo(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public enum eTiposPermissoes
        {
            [Description("Inclusão")]
            Inclusao,
            [Description("Alteração")]
            Alteracao,
            [Description("Exclusão")]
            Exclusao,
            [Description("Impressão")]
            Impressao
        }

        private eTiposPermissoes[] _tiposPermissoes;

        /// <summary>
        /// (Get\Set) Informa ou retorna os tipos de permissões associadas no botão.
        /// </summary>
        [Category(FGlobus.Util.Constantes.CATEGORIA)]
        [Description("Informa ou retorna os tipos de permissões associadas no botão.\nNome: Permissoes")]
        [EditorAttribute(typeof(UITypeEditorX), typeof(System.Drawing.Design.UITypeEditor))]
        [TypeConverter(typeof(PointConverter))]
        [DefaultValue(null)]
        [DisplayName("Tipos de permissões")]
        public eTiposPermissoes[] TiposPermissoes
        {
            get { return _tiposPermissoes; }
            set { _tiposPermissoes = value; }
        }


        internal class UITypeEditorX : UITypeEditor
        {
            public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext controle)
            {
                if (controle != null)
                    return UITypeEditorEditStyle.DropDown;
                else
                    return base.GetEditStyle(controle);
            }

            private IWindowsFormsEditorService _windowsFormsEditorService;

            public override object EditValue(ITypeDescriptorContext contexto, IServiceProvider provider, object valor)
            {
                if (contexto != null && provider != null)
                {
                    _windowsFormsEditorService = provider.GetService(typeof(IWindowsFormsEditorService)) as IWindowsFormsEditorService;

                    if (_windowsFormsEditorService != null)
                    {
                        CheckedListBoxControl checkedListBoxControl = new CheckedListBoxControl()
                        {
                            BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder,
                            CheckOnClick = true,
                            SortOrder = SortOrder.Descending
                        };

                        #region Expressao cria CheckedListBoxItem

                        Func<eTiposPermissoes, CheckedListBoxItem> expCheckedListBoxItem =
                            item => new CheckedListBoxItem(
                                    item,
                                    FGlobus.Util.Util.GetDescricaoEnum(item),
                                    (valor != null &&
                                    (valor as IEnumerable<eTiposPermissoes>)
                                        .Contains(item))
                                            ? CheckState.Checked
                                            : CheckState.Unchecked);

                        #endregion

                        checkedListBoxControl.Items.AddRange(Enum.GetValues(typeof(eTiposPermissoes))
                            .OfType<eTiposPermissoes>()
                            .Select(expCheckedListBoxItem)
                            .ToArray());

                        _windowsFormsEditorService.DropDownControl(checkedListBoxControl);

                        return checkedListBoxControl.CheckedItems
                            .OfType<CheckedListBoxItem>()
                            .Where(w => w.CheckState.Equals(CheckState.Checked))
                            .Select(s => (eTiposPermissoes)s.Value)
                            .ToArray();
                    }
                }

                return valor;

            }
        }

        public class PointConverter : TypeConverter
        {
            public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
            {
                if (context.Instance is SimpleButtonBGMDemo)
                {
                    eTiposPermissoes[] listaPermissoes = value as eTiposPermissoes[];
                    if (listaPermissoes != null)
                        return listaPermissoes
                            .Aggregate(String.Empty, (a, b) => a + (String.IsNullOrEmpty(a) ? "" : " | ") + b.ToString().Substring(0, 3));
                }

                return null;
            }
        }

    }
}
