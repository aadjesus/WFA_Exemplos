using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Reflection.Emit;
using System.Windows.Forms;
using FGlobus.Componentes.WinForms;
using FGlobus.Util;

namespace WFA_Workflow.Destaque 
{
    public partial class FrmDestaque : Form
    {
        public FrmDestaque()
        {
            InitializeComponent();

            comboBoxEdit1.AdicionarItens<eTamanho>();
            comboBoxEdit1.SelectedIndex = 0;
        }

        private void FrmDestaque_Load(object sender, EventArgs e)
        {


        }

        private void Teste_ssss()
        {
            Button guy = new Button();
            PropertyDescriptor prop;
            PropertyDescriptorCollection guyProps = TypeDescriptor.GetProperties(guy);
            prop = TypeDescriptor.CreateProperty(this.GetType(), "SampleProp", "".GetType(), null);
            guyProps.Add(prop);
            if (guy == null)
            {
                
            }

        }
        private void Teste_22222()
        {
            //Dynamic d = new Dynamic();
            //d = d.Add("MyProperty", 42);
            //Console.WriteLine(d.GetType().GetProperty("MyProperty").GetValue(d, null));

            FrmDestaque a = new FrmDestaque();
            a = a.Add("MyProperty", 42);

            PropertyInfo propertyInfo = a.GetType().GetProperty("MyProperty");
            Console.WriteLine(propertyInfo.GetValue(a, null));
        }


        public FrmDestaque Add<T>(string key, T value)
        {
            AssemblyBuilder assemblyBuilder = AppDomain.CurrentDomain.DefineDynamicAssembly(new AssemblyName("WFA_Exemplos"), AssemblyBuilderAccess.Run);

            ModuleBuilder moduleBuilder = assemblyBuilder.DefineDynamicModule("WFA_Workflow.dll");
            TypeBuilder typeBuilder = moduleBuilder.DefineType(Guid.NewGuid().ToString());
            typeBuilder.SetParent(this.GetType());
            PropertyBuilder propertyBuilder = typeBuilder.DefineProperty(key, System.Reflection.PropertyAttributes.None, typeof(T), Type.EmptyTypes);

            MethodBuilder getMethodBuilder = typeBuilder.DefineMethod("get_" + key, MethodAttributes.Public, CallingConventions.HasThis, typeof(T), Type.EmptyTypes);
            ILGenerator getter = getMethodBuilder.GetILGenerator();
            getter.Emit(OpCodes.Ldarg_0);
            getter.Emit(OpCodes.Ldstr, key);
            getter.Emit(OpCodes.Callvirt, typeof(FrmDestaque).GetMethod("Get", BindingFlags.Instance | BindingFlags.NonPublic).MakeGenericMethod(typeof(T)));
            getter.Emit(OpCodes.Ret);
            propertyBuilder.SetGetMethod(getMethodBuilder);

            Type type = typeBuilder.CreateType();

            FrmDestaque frmDestaque = (FrmDestaque)Activator.CreateInstance(type);
            frmDestaque.dictionary = this.dictionary;
            dictionary.Add(key, value);

            return frmDestaque;
        }

        protected T Get<T>(string key)
        {
            return (T)dictionary[key];
        }

        private Dictionary<string, object> dictionary = new Dictionary<string, object>();

        private void destaqueBGM2_Load(object sender, EventArgs e)
        {

        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {

        }


        public enum eTamanho
        {
            /// <summary>
            /// Pequeno
            /// </summary>
            Pequeno = 1,
            /// <summary>
            /// Médio 60% a mais que o pequeno
            /// </summary>
            Medio = 60,
            /// <summary>
            /// Grande 120% a mais que o pequeno
            /// </summary>
            Grande = 120
        }

        private const float TAMANHO_DEFAULT_FONT_TITULO = 8.25F;
        private const float TAMANHO_DEFAULT_FONT_VALOR = 16.25F;
        private const int VALOR_PARA_ALGORITMO_TAMANHO = 63;


        private eTamanho _tamanho = eTamanho.Grande;

        private float RetornarTamanho(float valor)
        {
            return (valor + (valor * ((int)(char)_tamanho) / 100));
        }

        private Font RetornarFont(float valor)
        {
            float tamanho = (valor + (valor * ((int)(char)_tamanho) / 100));

            return new Font(this.lblCtrlTitulo.Font.FontFamily, tamanho, FontStyle.Bold);
        }

        private int TamanhoControle
        {
            get
            {
                return (((this.lblCtrlTitulo.Font.Size + this.lblCtrlValor.Font.Size) * 100) / VALOR_PARA_ALGORITMO_TAMANHO).Converter<int>();
            }
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _tamanho = (comboBoxEdit1.SelectedItem as ListItemBGM<eTamanho>).Value;


            //float tamanhoTitulo = RetornarTamanho(TAMANHO_DEFAULT_FONT_TITULO);
            //float tamanhoValor = RetornarTamanho(TAMANHO_DEFAULT_FONT_VALOR);

            //this.lblCtrlTitulo.Font = new Font(this.lblCtrlTitulo.Font.FontFamily, tamanhoTitulo, FontStyle.Bold);
            //this.lblCtrlValor.Font = new Font(this.lblCtrlTitulo.Font.FontFamily, tamanhoValor, FontStyle.Bold);

            //panelControl1.Height = (((tamanhoTitulo + tamanhoValor) * 100) / 63).Converter<int>();
            //pctrEdtImagem.Width = pctrEdtImagem.Height;

            this.lblCtrlTitulo.Font = this.RetornarFont(TAMANHO_DEFAULT_FONT_TITULO);
            this.lblCtrlValor.Font = this.RetornarFont(TAMANHO_DEFAULT_FONT_VALOR);

            int tamanho = this.TamanhoControle;

            this.MinimumSize = new Size(tamanho, tamanho);
            panelControl1.Height = tamanho;
            this.pctrEdtImagem.Width = this.pctrEdtImagem.Height;

            labelControl2.Text = String.Concat(
                "tamanhoTitulo       : ", lblCtrlTitulo.Font.Size, Environment.NewLine,
                "tamanhoValor        : ", lblCtrlValor.Font.Size, Environment.NewLine,
                "panelControl1.Height: ", panelControl1.Height, Environment.NewLine,
                ""

                );

            DefinirTamanhoWidthConformeValor();
        }

        private void DefinirTamanhoWidthConformeValor()
        {
            panelControl1.Width = this.pctrEdtImagem.Width + TextRenderer.MeasureText(this.lblCtrlValor.Text, this.lblCtrlValor.Font).Width;
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            this.lblCtrlValor.Text = textEdit1.Text;
         //   DefinirTamanhoWidthConformeValor();
        }

    }
}


