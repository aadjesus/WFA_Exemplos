using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors.Mask;
using FGlobus.Util;
using FGlobus.Util.ExtensaoEnum;
using FGlobus.Util.ExtensaoObject;

namespace WFA_Workflow.Mascaras
{
    internal partial class Mascaras : UserControl
    {
        #region Construtor

        /// <summary>
        /// Construtor padrão
        /// </summary>
        public Mascaras()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Construtor default
        /// </summary>
        /// <param name="controle">Objeto do tipo Control</param>
        /// <param name="iWindowsFormsEditorService">Objeto do tipo IWindowsFormsEditorService</param>
        public Mascaras(Control controle, IWindowsFormsEditorService iWindowsFormsEditorService)
        {
            InitializeComponent();

            _controle = controle;
            _iWindowsFormsEditorService = iWindowsFormsEditorService;
        }

        #endregion

        #region Atributos

        private Control _controle;
        private IWindowsFormsEditorService _iWindowsFormsEditorService;
        private eMascara _mascaraSelecionada;

        #endregion

        #region Propriedades

        /// <summary>
        /// (Set/Get) Informa ou retorna a o tipo de mascara selecionado
        /// </summary>
        public eMascara MascaraSelecionada
        {
            get
            {
                return _mascaraSelecionada;
            }
            set
            {
                _mascaraSelecionada = value;
            }
        }

        #endregion

        private void Mascaras_Load(object sender, EventArgs e)
        {
            if (_controle != null)
            {
                _mascaraSelecionada = _controle.RetornarValorPropriedade<eMascara>("Mascara");

                // Cria lista com os itens do enum
                var listaTipoMascara = ExtensaoEnum.RetornarItensDoEnum<eMascara>()
                    .Select(s => new
                    {
                        TipoMascara = s,
                        MascarasAttribute = s.RetornarAtributo<MascarasAttribute>()
                    })
                    .Where(w => w.MascarasAttribute.Controles.Contains(_controle.GetType()))
                    .Select((s, index) => new
                    {
                        Index = index,
                        s.MascarasAttribute.Descricao,
                        s.MascarasAttribute.Exemplo,
                        s.TipoMascara
                    })
                    .ToArray();

                this.grdCtrlMascaras.DataSource = listaTipoMascara;

                // Procura a mascara selecionada e posiciona na mesma
                int handle = listaTipoMascara
                    .Where(w => w.TipoMascara == _mascaraSelecionada)
                    .FirstOrDefault()
                    .Index;

                this.grdCtrlMascaras.ForceInitialize();
                this.grdVwMascaras.FocusedRowHandle = handle;
                //this.grdVwMascaras.SelectRow(handle);
            }
        }

        internal static void DefinirMascara(TextEdit textEdit)
        {
            if (!textEdit.IsDesignMode && textEdit.Properties.Mask.EditMask.NuloOuVazio())
            {
                eMascara mascara = textEdit.RetornarValorPropriedade<eMascara>("Mascara");
                int tamanhoCampo = textEdit.RetornarValorPropriedade<int>("TamanhoCampo");
                if (mascara != eMascara.Default)
                {
                    MascarasAttribute mascarasAttribute = mascara.RetornarAtributo<MascarasAttribute>();
                    if (mascarasAttribute.MaskType != MaskType.None &&
                        mascarasAttribute.Controles.Contains(textEdit.GetType()))
                    {
                        string editMask = mascarasAttribute.EditMask;
                        char placeHolder = ' ';
                        switch (mascara)
                        {
                            case eMascara.Senha:
                                {
                                    textEdit.Properties.PasswordChar = '*';
                                    placeHolder = '_';
                                    break;
                                }
                            case eMascara.Numero:
                                {
                                    editMask = String.Concat("\\d{0,", tamanhoCampo, "}");
                                    placeHolder = '_';
                                    break;
                                }
                            case eMascara.Classificador:
                                {
                                    editMask = String.Concat("([0-9]|[.]){0,", tamanhoCampo, "}");
                                    placeHolder = '_';
                                    break;
                                }
                        }

                        textEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
                        textEdit.Properties.Mask.MaskType = mascarasAttribute.MaskType;
                        textEdit.Properties.Mask.SaveLiteral = false;

                        textEdit.Properties.Mask.IgnoreMaskBlank = false;
                        textEdit.Properties.Mask.PlaceHolder = placeHolder;
                        textEdit.Properties.Mask.EditMask = editMask;
                        //textEdit.Properties.Mask.AutoComplete = false;
                    }
                }
            }
        }

        internal static bool ValidarMascara(TextEdit textEdit, DXErrorProvider dXErrorProvider)
        {
            dXErrorProvider.ClearErrors();

            eMascara mascara = textEdit.RetornarValorPropriedade<eMascara>("Mascara");
            if (mascara != eMascara.Default &&
                !textEdit.Text.NuloOuVazio())
            {            
                switch (mascara)
                {
                    case eMascara.Email:
                        {
                            if (textEdit.Text.IndexOf("@").Equals(-1))
                                dXErrorProvider.SetError(textEdit, "Entre com um e-mail válido.", ErrorType.Critical);                                
                            
                            break;
                        }
                }

                if (dXErrorProvider.HasErrors)
                    textEdit.Focus();
            }

            dXErrorProvider.GetError(textEdit);

            return !dXErrorProvider.HasErrors;
        }
    }



    /// <summary>
    /// Enum para controlas as mascaras disponiveis
    /// </summary>
    public enum eMascara
    {
        /// <summary>
        /// Default
        /// </summary>
        [Mascaras("Default", null, null, MaskType.None, typeof(CalcEditBGMX), typeof(DateEditBGMX), typeof(TextEditBGMDemo), typeof(ButtonEditBGMX))]
        Default = 1,
        /// <summary>
        /// Valor
        /// </summary>
        [Mascaras("Valor", "R$ 999.999,99", "c", MaskType.None, typeof(CalcEditBGMX))]
        Valor = 2,
        /// <summary>
        /// Percentual
        /// </summary>
        [Mascaras("Percentual", "9,99%", "P", MaskType.Numeric, typeof(CalcEditBGMX))]
        Percentual = 3,
        /// <summary>
        /// Dia, mês e ano (2 digítos)
        /// </summary>
        [Mascaras("Dia, mês e ano (2 digítos)", "01/09/10", "99/99/00", MaskType.Simple, typeof(DateEditBGMX), typeof(ButtonEditBGMX))]
        DiaMesEAnoDoisDigitos = 4,
        /// <summary>
        /// Dia, mês e ano (4 digítos)
        /// </summary>
        [Mascaras("Dia, mês e ano (4 digítos)", "01/09/1910", "99/99/0000", MaskType.Simple, typeof(DateEditBGMX), typeof(ButtonEditBGMX))]
        DiaMesEAnoQuatroDigitos = 5,
        /// <summary>
        /// Horas sem segundos
        /// </summary>
        [Mascaras("Horas sem segundos", "02:17", "90:00", MaskType.Simple, typeof(DateEditBGMX), typeof(ButtonEditBGMX))]
        HoraSemSegundos = 6,
        /// <summary>
        /// Horas com segundos
        /// </summary>
        [Mascaras("Horas com segundos", "02:17:20", "90:00:00", MaskType.Simple, typeof(DateEditBGMX), typeof(ButtonEditBGMX))]
        HoraComSegundos = 7,
        /// <summary>
        /// Dia, mês e ano (2 digítos) / Horas sem segundo
        /// </summary>
        [Mascaras("Dia, mês e ano (2 digítos) / Horas sem segundo", "01/09/10 02:17", "99/99/00 90:00", MaskType.Simple, typeof(DateEditBGMX), typeof(ButtonEditBGMX))]
        DiaMesAnoDoisDigitosHorasSemSegundos = 8,
        /// <summary>
        /// Dia, mês e ano (2 digítos) / Horas com segundo
        /// </summary>
        [Mascaras("Dia, mês e ano (2 digítos) / Horas com segundo", "01/09/10 02:17:20", "99/99/00 90:00:00", MaskType.Simple, typeof(DateEditBGMX), typeof(ButtonEditBGMX))]
        DiaMesAnoDoisDigitosHorasComSegundos = 9,
        /// <summary>
        /// Dia, mês e ano (4 digítos) / Horas sem segundo
        /// </summary>
        [Mascaras("Dia, mês e ano (4 digítos) / Horas sem segundo", "01/09/1910 02:17", "99/99/0000 90:00", MaskType.Simple, typeof(DateEditBGMX), typeof(ButtonEditBGMX))]
        DiaMesAnoQuatroDigitosHorasSemSegundos = 10,
        /// <summary>
        /// Dia, mês e ano (4 digítos) / Horas com segundo
        /// </summary>
        [Mascaras("Dia, mês e ano (4 digítos) / Horas com segundo", "01/09/1910 02:17:20", "99/99/0000 90:00:00", MaskType.Simple, typeof(DateEditBGMX), typeof(ButtonEditBGMX))]
        DiaMesAnoQuatroDigitosHorasComSegundos = 11,
        /// <summary>
        /// Dia e mês (número)
        /// </summary>
        [Mascaras("Dia e mês (número)", "01/09", "99/99", MaskType.Simple, typeof(DateEditBGMX), typeof(ButtonEditBGMX))]
        DiaEMesNumero = 12,
        /// <summary>
        /// Dia e mês (extenso)
        /// </summary>
        [Mascaras("Dia e mês (extenso)", "01 de Setembro", "m", MaskType.DateTime, typeof(DateEditBGMX), typeof(ButtonEditBGMX))]
        DiaEMesExtenso = 13,
        /// <summary>
        /// Dia e dia da semana
        /// </summary>
        [Mascaras("Dia e dia da semana", "01, quinta-feira", "d, dddd", MaskType.DateTime, typeof(DateEditBGMX), typeof(ButtonEditBGMX))]
        DiaEDiaDaSemana = 14,
        /// <summary>
        /// Placa do veículo
        /// </summary>
        [Mascaras("Placa do veículo", "AAA-9999", "\\w{0,3}-\\d\\d\\d\\d", MaskType.Regular, typeof(TextEditBGMDemo), typeof(ButtonEditBGMX))]
        PlacaVeiculo = 15,
        /// <summary>
        /// CPF
        /// </summary>
        [Mascaras("CPF", "999.999.999-99", "000.000.000-00", MaskType.Simple, typeof(TextEditBGMDemo), typeof(ButtonEditBGMX))]
        CPF = 16,
        /// <summary>
        /// RG
        /// </summary>
        [Mascaras("RG", "99.999.999-9", "00.000.000-a", MaskType.Simple, typeof(TextEditBGMDemo), typeof(ButtonEditBGMX))]
        RG = 17,
        /// <summary>
        /// CNPJ
        /// </summary>
        [Mascaras("CNPJ", "99.999.999/9999-99", "00.000.000/0000-00", MaskType.Simple, typeof(TextEditBGMDemo), typeof(ButtonEditBGMX))]
        CNPJ = 18,
        /// <summary>
        /// CEP
        /// </summary>
        [Mascaras("CEP", "99999-999", "00000-000", MaskType.Simple, typeof(TextEditBGMDemo), typeof(ButtonEditBGMX))]
        CEP = 19,
        /// <summary>
        /// Telefone sem DDD
        /// </summary>
        [Mascaras("Telefone sem DDD", "9999-9999", "0000-0000", MaskType.Simple, typeof(TextEditBGMDemo), typeof(ButtonEditBGMX))]
        TelefoneSemDDD = 20,
        /// <summary>
        /// Telefone com 2 dígitos no DDD
        /// </summary>
        [Mascaras("Telefone com 2 dígitos no DDD", "(99) 9999-9999", "(99) 0000-0000", MaskType.Simple, typeof(TextEditBGMDemo), typeof(ButtonEditBGMX))]
        TelefoneDoisDigitosDDD = 21,
        /// <summary>
        /// Telefone com 3 dígitos no DDD
        /// </summary>
        [Mascaras("Telefone com 3 dígitos no DDD", "(999) 9999-9999", "(999) 0000-0000", MaskType.Simple, typeof(TextEditBGMDemo), typeof(ButtonEditBGMX))]
        TelefoneTresDigitosDDD = 22,
        /// <summary>
        /// E-mail
        /// </summary>
        [Mascaras("E-mail", "desenvolvimento@bgmrodotec.com.br", null, MaskType.None, typeof(TextEditBGMDemo), typeof(ButtonEditBGMX))]
        Email = 23,
        /// <summary>
        /// Senha
        /// </summary>
        [Mascaras("Senha", "**********", null, MaskType.None, typeof(TextEditBGMDemo))]
        Senha = 24,
        /// <summary>
        /// Número
        /// </summary>
        [Mascaras("Número", "12345", "\\d{0,5}", MaskType.RegEx, typeof(TextEditBGMDemo), typeof(ButtonEditBGMX))]
        Numero = 25,
        /// <summary>
        /// Classificador
        /// </summary>
        [Mascaras("Classificador", "1.01.01.000", "", MaskType.RegEx, typeof(TextEditBGMDemo), typeof(ButtonEditBGMX))]
        Classificador = 26,
        /// <summary>
        /// Mês e ano (4 digítos)", "09/1910
        /// </summary>
        [Mascaras("Mês e ano (4 digítos)", "09/1910", "MM/yyyy", MaskType.DateTime, typeof(DateEditBGMX), typeof(ButtonEditBGMX))]
        MeseAnoComQuatroDigitos = 27,
        /// <summary>
        /// Telefone de 9 dígitos sem DDD
        /// </summary>
        [Mascaras("Telefone de 9 dígitos sem DDD", "999999999", "0", MaskType.Simple, typeof(TextEditBGMDemo), typeof(ButtonEditBGMX))]
        Telefone9SemDDD = 28,
        /// <summary>
        /// Telefone de 9 dígitos com 2 dígitos no DDD
        /// </summary>
        [Mascaras("Telefone de 9 dígitos com 2 dígitos no DDD", "(99) 999999999", "(99) 000000000", MaskType.Simple, typeof(TextEditBGMDemo), typeof(ButtonEditBGMX))]
        Telefone9DoisDigitosDDD = 29,
        /// <summary>
        /// Telefone de 9 dígitos com 3 dígitos no DDD
        /// </summary>
        [Mascaras("Telefone de 9 dígitos com 3 dígitos no DDD", "(999) 999999999", "(999) 000000000", MaskType.Simple, typeof(TextEditBGMDemo), typeof(ButtonEditBGMX))]
        Telefone9TresDigitosDDD = 30,
        /// <summary>
        /// Valor sem R$
        /// </summary>
        [Mascaras("Valor sem R$", "999.999,99", "n", MaskType.Numeric, typeof(CalcEditBGMX))]
        ValorApenasNumeros = 31,
        /// <summary>
        /// Quantidade de horas
        /// </summary>
        [Mascaras("Quantidade de horas", "999:99", "000:00", MaskType.Simple, typeof(TextEditBGMDemo))]
        QuantidadeDeHoras = 32,
    }

    [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    internal sealed class MascarasAttribute : Attribute
    {
        #region Construtor

        /// <summary>
        /// Construtor default
        /// </summary>
        public MascarasAttribute() { }

        /// <summary>
        /// Construtor padrão
        /// </summary>
        /// <param name="descricao">Descrição</param>
        /// <param name="exemplo">Exemplo</param>
        /// <param name="editMask">Mascara</param>
        /// <param name="maskType">Objeto do tipo MaskType</param>
        /// <param name="controles">Controles associados ou atributo</param>
        public MascarasAttribute(string descricao, string exemplo, string editMask, MaskType maskType, params Type[] controles)
        {
            _descricao = descricao;
            _exemplo = exemplo;
            _editMask = editMask;
            _maskType = maskType;
            _controles = controles;
        }

        #endregion

        #region Atributos

        private readonly string _descricao;
        private readonly string _exemplo;
        private readonly string _editMask;
        private readonly MaskType _maskType;
        private readonly Type[] _controles;

        #endregion

        #region Propriedades

        public string Descricao
        {
            get { return _descricao; }
        }

        public string Exemplo
        {
            get { return _exemplo; }
        }

        public string EditMask
        {
            get { return _editMask; }
        }

        public MaskType MaskType
        {
            get { return _maskType; }
        }

        public Type[] Controles
        {
            get { return _controles; }
        }

        #endregion                                                                                                                                                                                                                                                                                                                ))]
    }

    internal class UITypeEditorBGMRodotecX : UITypeEditor
    {
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext controle)
        {
            if (controle != null)
                return UITypeEditorEditStyle.DropDown;

            return base.GetEditStyle(controle);
        }

        #region Atributos

        private IWindowsFormsEditorService _windowsFormsEditorService;

        #endregion

        public override object EditValue(ITypeDescriptorContext contexto, IServiceProvider provider, object valor)
        {
            try
            {
                if (contexto != null && provider != null)
                {
                    _windowsFormsEditorService = provider.GetService(typeof(IWindowsFormsEditorService)) as IWindowsFormsEditorService;
                    return this.EditValueMascaras(contexto, valor);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Concat(ex));
            }

            return valor;
        }

        private object EditValueMascaras(ITypeDescriptorContext contexto, object valor)
        {
            try
            {
                Mascaras tipoMascaras = new Mascaras((System.Windows.Forms.Control)contexto.Instance, _windowsFormsEditorService);
                tipoMascaras.grdVwMascaras.DoubleClick += delegate(object senderDoubleClick, EventArgs eDoubleClick)
                {
                    tipoMascaras.MascaraSelecionada = tipoMascaras.grdVwMascaras.GetFocusedRow()
                        .RetornarValorPropriedade<eMascara>("TipoMascara");
                    _windowsFormsEditorService.CloseDropDown();
                };

                _windowsFormsEditorService.DropDownControl(tipoMascaras);

                return tipoMascaras.MascaraSelecionada;

            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Concat(ex));
                return null;
            }
        }
    }

}
