using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using FGlobus.Componentes.WinForms;
//using Microsoft.Office.Interop.Word;
//using Word = Microsoft.Office.Interop.Word;

namespace WFA_Workflow
{
    public partial class FrmCorretorOrtografico : Form
    {
        public FrmCorretorOrtografico()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Word.Application wordApp = null;
            //List<string> listaCritica = null;
            //try
            //{
            //    Dictionary<string, string> dicionario = this.Controls
            //        .OfType<Control>()
            //        .OrderBy(o => o.TabIndex)
            //        .Aggregate(new Dictionary<string, string>(), (retorno, item) =>
            //        {
            //            GridControl gridControl = item as GridControl;
            //            if (gridControl != null)
            //                (gridControl.MainView as DevExpress.XtraGrid.Views.Base.ColumnView).Columns
            //                    .OfType<DevExpress.XtraGrid.Columns.GridColumn>()
            //                    .Where(w => !String.IsNullOrEmpty(w.Name) && !String.IsNullOrEmpty(w.Caption))
            //                    .ToList()
            //                    .ForEach(f => retorno.Add(String.Concat(item.Name, ".", f.Name), f.Caption));
            //            else if (item is LabelControl &&
            //                     !String.IsNullOrEmpty(item.Name) && !String.IsNullOrEmpty(item.Text))
            //                retorno.Add(item.Name, item.Text);


            //            return retorno;
            //        });

            //    if (dicionario.Count > 0)
            //    {
            //        wordApp = new Word.Application();

            //        listaCritica = dicionario
            //            .Aggregate(new List<string>(), (retornoCritica, itemCritica) =>
            //            {
            //                Word._Document documento = wordApp.Documents.Add();
            //                documento.Content.LanguageID = Microsoft.Office.Interop.Word.WdLanguageID.wdPortugueseBrazil;

            //                documento.Words.First.InsertBefore(itemCritica.Value);
            //                Word.ProofreadingErrors spellingErrors = documento.SpellingErrors;

            //                if (spellingErrors.Count > 0)
            //                {
            //                    string sugestoes = spellingErrors
            //                        .OfType<Microsoft.Office.Interop.Word.Range>()
            //                        .Select(s => wordApp.GetSpellingSuggestions(s.Text)
            //                                        .OfType<Word.SpellingSuggestion>()
            //                                        .Aggregate(String.Empty, (retornoSugestao, itemSugestao) => retornoSugestao + (String.IsNullOrEmpty(retornoSugestao) ? "" : ", ") + itemSugestao.Name))
            //                        .Aggregate(String.Empty, (retornoSugestoes, itemSugestoes) => retornoSugestoes + (String.IsNullOrEmpty(retornoSugestoes) ? "" : " | ") + itemSugestoes);

            //                    if (!String.IsNullOrEmpty(sugestoes))
            //                        retornoCritica.Add(String.Concat(new string(' ', 14), itemCritica.Key, ", Texto: ", itemCritica.Value, ", Sugestões: ", sugestoes));

            //                }

            //                documento.Close(Word.WdSaveOptions.wdDoNotSaveChanges);
            //                return retornoCritica;
            //            });
            //    }
            //}
            //catch { }
            //finally
            //{
            //    try
            //    {
            //        if (listaCritica.Count > 0)
            //        {
            //            List<string> criticas = new List<string>();
            //            if (criticas.Count > 0)
            //                criticas.Add(Environment.NewLine);

            //            criticas.Add("# ERRO # Existem controles que não estão escritos corretamente.");
            //            criticas.Add("Controles: ");

            //            criticas.AddRange(listaCritica.ToArray());

            //            MasterFormCritica.VisualizarCritica<string>(criticas);

            //            wordApp.Quit(Microsoft.Office.Interop.Word.WdSaveOptions.wdDoNotSaveChanges);
            //            System.Runtime.InteropServices.Marshal.FinalReleaseComObject(wordApp);
            //        }
            //    }
            //    catch { }

            //}

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //System.Collections.CollectionBase
            //new ComboBoxItem().Value                           
            //new CheckedListBoxItem().Description                           
            //new RadioGroupItem().Description

            //checkedComboBoxEdit1.Properties.Items;
            //radioGroup1.Properties.Items; 
            //comboBoxEdit1;
            //imageComboBoxEdit1;
            //comboBoxEdit1.Properties.Items
            //Thread aaa = new Thread();

            Dictionary<string, string> lista1 = new Dictionary<string, string>();

            this.Controls
                   .OfType<Control>()
                   .ToList()
                   .ForEach(itemControle =>
                   {
                       MethodInfo memberInfo = itemControle.GetType().GetMethod("get_Properties");

                       //Type tipo = itemControle.GetType();
                       //var x1 = tipo.InvokeMember("Properties", BindingFlags.GetProperty | BindingFlags.GetField, null, itemControle, null);
                       //if (x1 == null)
                       //{

                       //}

                       if (memberInfo != null)
                       {
                           object getProperties = memberInfo.Invoke(itemControle, null);
                           memberInfo = getProperties.GetType().GetMethod("get_Items");

                           CollectionBase itensProperties = null;
                           if (memberInfo != null)
                               itensProperties = memberInfo.Invoke(getProperties, null) as System.Collections.CollectionBase;

                           if (itensProperties != null)
                               itensProperties
                                   .OfType<object>()
                                   .Select((s, index) => new
                                   {
                                       Item = s,
                                       Index = index
                                   })
                                   .ToList()
                                   .ForEach(itemProperties =>
                                   {
                                       string valorItem = String.Empty;
                                       if (itemProperties.Item.GetType().GetProperty("Description") == null)
                                           valorItem = itemProperties.Item.ToString();
                                       else
                                           valorItem = itemProperties.Item.GetType().GetMethod("get_Description").Invoke(itemProperties.Item, null).ToString();

                                       lista1.Add(String.Concat(itemControle.Name, ".", itemProperties.Index), valorItem);
                                   });
                       }
                   });

            if (lista1 == null)
            {

            }

        }

        private void buttonEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter && e.Modifiers == Keys.Control))
            {
                MessageBox.Show("a");
            }
            // PopupBaseEdit

            //var a1 = new CheckedComboBoxEdit().Properties.Items;  //CheckedListBoxItemCollection//ListBoxItemCollection
            //var a2 = new RadioGroup().Properties.Items;  //RadioGroupItemCollection//CollectionBase
            //var a3 = new ComboBoxEdit().Properties.Items;  //ComboBoxItemCollection//CollectionBase
            //var a4 = new ImageComboBoxEdit().Properties.Items; //ImageComboBoxItemCollection//ComboBoxItemCollection
        }

        private void FrmCorretorOrtografico_Shown(object sender, EventArgs e)
        {
            //GFO.GestaoDeFrotaOnLineWS aa = new GFO.GestaoDeFrotaOnLineWS();
            Globus5.WPF.Comum.WebServices.GestaoDeFrotaOnLineWSApp.RetornarDadosEnum<Globus5.WPF.Comum.ws.gestaoDeFrotaOnline.eTipoRelatorioSoltura>()
                .PopularItensControle(imageComboBoxEdit1);

            //imageComboBoxEdit1.Properties.Items.AddRange = new ImageComboBoxItemCollection()

            var xx = Globus5.WPF.Comum.WebServices.GestaoDeFrotaOnLineWSApp.RetornarDescricaoEnum<Globus5.WPF.Comum.ws.gestaoDeFrotaOnline.eTipoRelatorioSoltura>(Globus5.WPF.Comum.ws.gestaoDeFrotaOnline.eTipoRelatorioSoltura.Ambos);
            if (xx == null)
            {

            }

        }

    }

    public struct sDadosEnum
    {
        public Enum Valor { get; set; }
        public string Descricao { get; set; }
    }

    public static class ExtensaoClassesxx
    {
        public static sDadosEnum[] RetornarDadosEnum<T>(this System.Web.Services.Protocols.SoapHttpClientProtocol valor)
        {
            Assembly assembly = valor.GetType().Assembly;
            Type type = assembly.GetType(valor.GetType().FullName);

            object activator = Activator.CreateInstance(type);
            List<object> parametros = new List<object>();
            parametros.Add(typeof(T).Name);

            var listaRetono1 = type.InvokeMember(
                "RetornarDadosEnum",
                BindingFlags.InvokeMethod | BindingFlags.Instance | BindingFlags.Public,
                null,
                activator,
                parametros.ToArray());

            IEnumerable<string> listaRetono = listaRetono1 as IEnumerable<string>;

            if (listaRetono.Count().Equals(0))
                return null;
            else
            {
                var listaEnum = Enum.GetValues(typeof(T))
                     .OfType<Enum>()
                     .Select(s => new
                     {
                         Item = s,
                         ItemString = s.ToString()
                     });

                var listaDadorEnum = listaRetono
                    .Select(s => s.Split(new string[] { FGlobus.Util.Constantes.CARACTER_SEPARACAO }, StringSplitOptions.None))
                    .Select(s => new
                    {
                        ItemString = s.FirstOrDefault(),
                        Descricao = s.LastOrDefault()
                    });

                IEnumerable<sDadosEnum> listaDadosEnum =
                    (from a in listaEnum
                     join b in listaDadorEnum on a.ItemString equals b.ItemString into join_b
                     from b in join_b.DefaultIfEmpty()
                     select new sDadosEnum()
                     {
                         Descricao = b == null ? a.Item.ToString() : b.Descricao,
                         Valor = a.Item
                     });

                return listaDadosEnum
                    .ToArray();
            }
        }

        public static string[] RetornarDescricoesEnum<T>(this System.Web.Services.Protocols.SoapHttpClientProtocol valor)
        {
            return valor.RetornarDadosEnum<T>()
                .Select(s => s.Descricao)
                .ToArray();
        }

        public static string RetornarDescricaoEnum<T>(this System.Web.Services.Protocols.SoapHttpClientProtocol valor, T enumerador)
        {
            return valor.RetornarDadosEnum<T>()
                .Where(w => w.Valor.Equals(enumerador))
                .FirstOrDefault()
                .Descricao;
        }

        public static void PopularItensControle(this IEnumerable<sDadosEnum> valor, BaseEdit itemControle)
        {
            try
            {
                MethodInfo memberInfo = itemControle
                    .GetType()
                    .GetMethod("get_Properties");

                if (memberInfo != null)
                {
                    //delegate int IntFunc (int x);
                    //Delegate staticD = Delegate.CreateDelegate(typeof(IntFunc), typeof(Program), "Square");
                    //delegate int IntFunc (int x);
                    //Console.WriteLine(staticD.DynamicInvoke(3));   


                    object getProperties = memberInfo
                        .Invoke(itemControle, null);

                    if (getProperties != null)
                        memberInfo = getProperties
                            .GetType()
                            .GetMethod("get_Items");

                    object itensProperties = null;
                    if (memberInfo != null)
                        itensProperties = memberInfo
                            .Invoke(getProperties, null);

                    if (itensProperties != null)
                    {
                        itensProperties
                            .GetType()
                            .GetMethod("Clear")
                            .Invoke(itensProperties, null);
                        //var xx = itensProperties
                        //    .GetType()
                        //    .GetMethod("AddRange");
                        

                        //var item = Activator
                        //    .CreateInstance(itensProperties
                        //                        .GetType()
                        //                        .GetMethod("get_Item")
                        //                        .ReturnType);

                        //string valorItem = String.Empty;
                        //if (item.GetType().GetProperty("Description") == null)
                        //    item.GetType().GetMethod("set_Description").Invoke(item, new object[] { "aaaaaaaaa" });
                        //else
                        //    item.GetType().GetMethod("set_Description").Invoke(item, new object[] { "aaaaaaaaa" });

                        //if (item.GetType().GetProperty("Value") == null)
                        //    item.GetType().GetMethod("set_Value").Invoke(item, new object[] { "aaaaaaaaa" });
                        //else
                        //    item.GetType().GetMethod("set_Value").Invoke(item, new object[] { "aaaaaaaaa" });

                        //var aaa = new object[] { item } as System.Collections.ICollection;


                        ////var list = Activator.CreateInstance(itensProperties
                        ////                                        .GetType()
                        ////                                        .GetMethod("get_Item")
                        ////                                        .ReturnType);


                        //Type objType = itensProperties.GetType();
                        //MemberInfo addMethod = objType.GetMember("Add").FirstOrDefault() ;
                        //addMethod.GetType().InvokeMember(null, BindingFlags.Public | BindingFlags.CreateInstance, null, item, null);
                        
                        //if (addMethod == null)
                        //{
                            
                        //}

                        
                       

                    }


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(String.Concat(ex));
            }
        }

        public static void SetAutoCompleteSource(this BaseEdit edit)
        {
            object o = null;// edit.GetProperty("MaskBox");
            DevExpress.XtraEditors.Mask.MaskBox maskBox = o as DevExpress.XtraEditors.Mask.MaskBox;
            if (maskBox != null)
            {
                maskBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                //maskBox.AutoCompleteMode = mode;
                //maskBox.AutoCompleteCustomSource = source;
            }
        }
    }


}


