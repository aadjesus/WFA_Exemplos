using System.ComponentModel;

namespace WFA_Workflow.OcultarPropriedade
{
    public partial class CmpOcultarPropriedade : DevExpress.XtraEditors.SimpleButton
    {
        public CmpOcultarPropriedade()
        {
            InitializeComponent();
        }

        public CmpOcultarPropriedade(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        bool _teste = true;

      // [MyAttribute("a")]
        public bool Teste
        {
            get { return _teste; }
            set
            {
                _teste = value;

                //FilterProperties(this);
                //try
                //{
                //    foreach (var item in TypeDescriptor.GetProperties(this.GetType()))
                //    {
                //        PropertyDescriptor propriedade = item as PropertyDescriptor;

                //        BrowsableAttribute attrib = (BrowsableAttribute)propriedade.Attributes[typeof(BrowsableAttribute)];
                //        FieldInfo isBrow = attrib.GetType().GetField("browsable", BindingFlags.NonPublic | BindingFlags.Instance);

                //        if (attrib.Browsable)
                //        {
                //            if (propriedade.PropertyType.Name == "Font")
                //            {
                //                //MessageBox.Show("aa");
                //                isBrow.SetValue(attrib, false);

                //                //    //PropertyDescriptor descriptor = TypeDescriptor.GetProperties(this.GetType())["AllowFocus"];
                //                //    //BrowsableAttribute attrib = (BrowsableAttribute)descriptor.Attributes[typeof(BrowsableAttribute)];

                //            }
                //            else
                //                isBrow.SetValue(attrib, true);
                //            //isBrow.SetValue(attrib, propriedade.PropertyType.Name != "Color");
                //        }




                //    }
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(String.Concat(ex));
                //}

            }
        }

        //private static void FilterProperties(object objToEdit)
        //{
        //    Type t = objToEdit.GetType();
        //    PropertyInfo[] props = t.GetProperties();
        //    // create fooObj in order to have another instance to test for NotImplemented exceptions 
        //    // (I do not know whether your getters could have side effects that you prefer to avoid)
        //    object fooObj = Activator.CreateInstance(t);
        //    foreach (PropertyInfo pi in props)
        //    {
        //        bool filter = false;
        //        object[] atts = pi.GetCustomAttributes(typeof(MyAttribute), true);
        //        if (atts.Length > 0)
        //            filter = true;
        //        else
        //        {
        //            //try
        //            //{
        //            //    object tmp = pi.GetValue(fooObj, null);
        //            //}
        //            //catch
        //            //{
        //            //    //filter = true;
        //            //}
        //        }

        //        PropertyDescriptor pd = TypeDescriptor.GetProperties(t)[pi.Name];
        //        BrowsableAttribute bAtt = (BrowsableAttribute)pd.Attributes[typeof(BrowsableAttribute)];
        //        FieldInfo fi = bAtt.GetType().GetField("browsable",
        //                           System.Reflection.BindingFlags.NonPublic |
        //                           System.Reflection.BindingFlags.Instance);
        //        fi.SetValue(bAtt, !filter);
        //    }
        //}

        //[AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
        //sealed class MyAttribute : Attribute
        //{
        //    // See the attribute guidelines at 
        //    //  http://go.microsoft.com/fwlink/?LinkId=85236
        //    readonly string positionalString;

        //    public MyAttribute()
        //    { }

        //    // This is a positional argument
        //    public MyAttribute(string positionalString)
        //    {
        //        this.positionalString = positionalString;
                
        //    }

        //    public string PositionalString
        //    {
        //        get { return positionalString; }
        //    }

        //    // This is a named argument
        //    public int NamedInt { get; set; }
        //}
    }

    //public class MyDynamicTypeConverter : ExpandableObjectConverter
    //{
    //    public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
    //    {
    //        if (destinationType.Equals(typeof(string)))
    //        {
    //            CmpOcultarPropriedade baseDisplay = GetBaseDisplay(context);
    //            if (baseDisplay.ReadFailed)
    //            {
    //                // Display the error message
    //                return baseDisplay.ErrorMessageReadFailed;
    //            }
    //        }
    //        return base.ConvertTo(context, culture, value, destinationType);
    //    }

    //    public override bool GetPropertiesSupported(ITypeDescriptorContext context)
    //    {
    //        CmpOcultarPropriedade baseDisplay = GetBaseDisplay(context);
    //        if (baseDisplay.ReadFailed)
    //        {
    //            // If read failed, do not expand the display for this object
    //            return false;
    //        }
    //        return base.GetPropertiesSupported(context);
    //    }

    //    private CmpOcultarPropriedade GetBaseDisplay(ITypeDescriptorContext context)
    //    {
    //        // Extract base data type using reflections
    //        object obj = context.Instance.GetType().GetProperty(context.PropertyDescriptor.Name).GetValue(context.Instance, null);
    //        return (BaseDataType)obj;
    //    }
    //}
}
