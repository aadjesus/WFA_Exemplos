using System;
using System.Collections;
using System.IO;
using System.Resources;
using System.Windows.Forms;

namespace WFA_Workflow
{
    public partial class FrmLendoArqResource : Form
    {
        public FrmLendoArqResource()
        {
            InitializeComponent();
        }

        static Stream GetResourceStream(string resourceName)
        {
            return System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName);
        }


        private void FrmLendoArqResource_Shown(object sender, EventArgs e)
        {
            //FileStream fs = new FileStream("Resource1.resx", FileMode.OpenOrCreate, FileAccess.Write);

            ////XDocument xDocument = XDocument.Load(fs);

            //string value = "Hello world";
            //string name = "name";

            //IResourceWriter writer = new ResourceWriter(fs);
            //writer.AddResource(name, value);
            //writer.Close();

            //if (value == null)
            //{
                
            //}
            string[] x1= null;
            var xx = System.Resources.Tools.StronglyTypedResourceBuilder.Create("Resource1.resx", "TesteResource", "WFA_Exemplos", new Microsoft.CSharp.CSharpCodeProvider(), false, out x1);
            if (xx == null)
            {
                
            }
            
            System.IO.Stream stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("WFA_Workflow.TesteResource.resources");
            using (ResourceReader reader = new ResourceReader(stream))
            {               
                foreach (DictionaryEntry entry in reader)
                {
                    string key = entry.Key as string;
                    object val = entry.Value;
                }
            }






        }


    }
}
