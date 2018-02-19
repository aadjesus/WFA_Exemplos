using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using FGlobus.Componentes.WinForms;

namespace WFA_Workflow.AssemblyInfo
{
    public partial class FrmAssemblyInfo : Form
    {
        public FrmAssemblyInfo()
        {
            InitializeComponent();

            MessageBox.Show(this.RunTime().ToString());

            Version v = Assembly.GetExecutingAssembly().GetName().Version;
            string ver = string.Format("Versão: Major = {0}, Minor = {1}, Build = {2}, Revision = {3}", v.Major, v.Minor, v.Build, v.Revision);

            String nomeArquivo = AppDomain.CurrentDomain.BaseDirectory + "Versao.txt";
            if (!System.IO.File.Exists(nomeArquivo))
                System.IO.File.Create(nomeArquivo).Close();

            System.IO.TextWriter arqTXT = System.IO.File.AppendText(nomeArquivo);
            arqTXT.WriteLine(ver);

            listBox1.Items.Clear();
            arqTXT.Close();

            System.IO.File.ReadAllLines(nomeArquivo).Aggregate(listBox1.Items, (a1, b) =>
            {
                a1.Add(b);
                return a1;
            });


            foreach (var assemblyName in Assembly.GetExecutingAssembly()
                .GetReferencedAssemblies()
                .Where(w => w.FullName.IndexOf("FGlobus") != -1)
                )
            {
                //Assembly assembly = Assembly.Load(assemblyName);                
                //foreach (var type in assembly.GetTypes())
                //{
                Console.WriteLine(assemblyName.FullName);
                //}
            }

            Action<string, Assembly> aaa = null;
            aaa = (a2,a3) => a3
                .GetReferencedAssemblies()
                .Where(w => w.FullName.IndexOf("FGlobus") != -1)
                .ToList()
                .ForEach(f =>
                {
                    Assembly assembly = Assembly.Load(f);

                    if (assembly
                            .GetReferencedAssemblies()
                            .Where(w => w.FullName.IndexOf("FGlobus") != -1)
                            .Count() > 0)
                        aaa("b=",assembly);

                    listBox2.Items.Add(String.Concat( a2, f.FullName));
                });

            aaa("a=",Assembly.GetExecutingAssembly());




            //Action<Assembly> sss = null;

            //sss = a1 => a1.GetReferencedAssemblies()
            //    .Aggregate(listBox2.Items, (a, b) =>
            //    {

            //        sss(Assembly.GetAssembly(b.GetType()));
            //        a.Add(b.FullName);
            //        return a;
            //    });

            //sss(Assembly.GetExecutingAssembly());

            //AssemblyName
            //Assembly.GetExecutingAssembly().GetReferencedAssemblies()


            //// This variable holds the amount of indenting that 
            //// should be used when displaying each line of information.
            //Int32 indent = 0;
            //// Display information about the EXE assembly.
            //Assembly a = System.Reflection.Assembly.GetExecutingAssembly();
            //Display(indent, "Assembly identity={0}", a.FullName);
            //Display(indent + 1, "Codebase={0}", a.CodeBase);

            //// Display the set of assemblies our assemblies reference.

            //Display(indent, "Referenced assemblies:");
            //foreach (AssemblyName an in a.GetReferencedAssemblies())
            //{
            //    Display(indent + 1, "Name={0}, Version={1}, Culture={2}, PublicKey token={3}", an.Name, an.Version, an.CultureInfo.Name, (BitConverter.ToString(an.GetPublicKeyToken())));
            //}
            //Display(indent, "");

            //// Display information about each assembly loading into this AppDomain.

            ////AppDomain.CurrentDomain.GetAssemblies()[76].GetName().Name.IndexOf("BgmRodotec.FGlobus.Componentes.WinForms")
            //var xx = AppDomain.CurrentDomain.GetAssemblies()
            //    .Where(w => w.FullName.IndexOf("BgmRodotec") != -1);

            //foreach (Assembly b in xx)
            //{
            //    Display(indent, "Assembly: {0}", b);

            //    // Display information about each module of this assembly.
            //    foreach (Module m in b.GetModules(true))
            //    {
            //        Display(indent + 1, "Module: {0}", m.Name);
            //    }

            //    // Display information about each type exported from this assembly.

            //    indent += 1;
            //    //foreach (Type t in b.GetExportedTypes())
            //    //{
            //    //Display(0, "");
            //    //Display(indent, "Type: {0}", t);

            //    //// For each type, show its members & their custom attributes.

            //    //indent += 1;
            //    //foreach (MemberInfo mi in t.GetMembers())
            //    //{
            //    //    Display(indent, "Member: {0}", mi.Name);
            //    //    DisplayAttributes(indent, mi);

            //    //    // If the member is a method, display information about its parameters.

            //    //    if (mi.MemberType == MemberTypes.Method)
            //    //    {
            //    //        foreach (ParameterInfo pi in ((MethodInfo)mi).GetParameters())
            //    //        {
            //    //            Display(indent + 1, "Parameter: Type={0}, Name={1}", pi.ParameterType, pi.Name);
            //    //        }
            //    //    }

            //    //    // If the member is a property, display information about the property's accessor methods.
            //    //    if (mi.MemberType == MemberTypes.Property)
            //    //    {
            //    //        foreach (MethodInfo am in ((PropertyInfo)mi).GetAccessors())
            //    //        {
            //    //            Display(indent + 1, "Accessor method: {0}", am);
            //    //        }
            //    //    }
            //    //}
            //    //indent -= 1;
            //    //}
            //    //indent -= 1;
            //}

        }


        public void DisplayAttributes(Int32 indent, MemberInfo mi)
        {
            // Get the set of custom attributes; if none exist, just return.
            object[] attrs = mi.GetCustomAttributes(false);
            if (attrs.Length == 0) { return; }

            // Display the custom attributes applied to this member.
            Display(indent + 1, "Attributes:");
            foreach (object o in attrs)
            {
                Display(indent + 2, "{0}", o.ToString());
            }
        }

        // Display a formatted string indented by the specified amount.
        public void Display(Int32 indent, string format, params object[] param)
        {
            listBox2.Items.Add(new string(' ', indent * 2));
            listBox2.Items.Add(String.Format(format, param));
        }
    }
}
