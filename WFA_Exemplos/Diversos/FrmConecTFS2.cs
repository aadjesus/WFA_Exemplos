using System;
using System.Windows.Forms;
//using Microsoft.TeamFoundation.Client;
//using Microsoft.TeamFoundation.Server;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();         
        }



        public static class Util1
        {

            /// <summary>
            /// (Get\Set) Retornar ou informa se esta no ambiente BGMRodotec VERDADEIRO se conectou no TFS
            /// </summary>
            /// <returns>bool.</returns>
            public static bool AmbienteBGMRodotec
            {
                get
                {
                    if (AppDomain.CurrentDomain.GetData("FGLOBUS_AMBIENTEBGMRODOTEC") == null)
                    {
                        bool conectou = false;
                        try
                        {
                            conectou = new System.Net.Sockets.TcpClient("tfsserver", 8080).Connected;
                        }
                        catch { }
                        AppDomain.CurrentDomain.SetData("FGLOBUS_AMBIENTEBGMRODOTEC", conectou);
                    }

                    return (bool)AppDomain.CurrentDomain.GetData("FGLOBUS_AMBIENTEBGMRODOTEC");
                }
                set
                {
                    AppDomain.CurrentDomain.SetData("FGLOBUS_AMBIENTEBGMRODOTEC", value);
                }
            }

            /// <summary>
            /// (Get) Retornar VERDADEIRO o usuário conectado é do setor de desenvolvimento
            /// </summary>
            /// <returns>bool.</returns>
            public static bool AmbienteDesenvolvimento
            {
                get
                {
                    //if (AppDomain.CurrentDomain.GetData("FGLOBUS_AMBIENTEDESENVOLVIMENTO") == null)
                    //{
                    //    bool usuarioDesenvolvimento = false;
                    //    if (AmbienteBGMRodotec)
                    //    {
                    //        try
                    //        {
                    //            IGroupSecurityService iGroupSecurityService = new TfsTeamProjectCollection(new Uri("http://tfsserver:8080/tfs")).GetService<IGroupSecurityService>();
                    //            usuarioDesenvolvimento = iGroupSecurityService.ReadIdentity(SearchFactor.AccountName, System.Environment.UserName, QueryMembership.Expanded)
                    //                .DistinguishedName.ToUpper().Contains("Desenvolvimento".ToUpper());
                    //        }
                    //        catch { }
                    //    }
                    //    AppDomain.CurrentDomain.SetData("FGLOBUS_AMBIENTEDESENVOLVIMENTO", usuarioDesenvolvimento);
                    //}

                    return (bool)AppDomain.CurrentDomain.GetData("FGLOBUS_AMBIENTEDESENVOLVIMENTO");
                }
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //foreach (var item in AppDomain.CurrentDomain.GetAssemblies())
            //{



            //    Console.WriteLine("*****************************");
            //    foreach (AssemblyName an in item.GetReferencedAssemblies())
            //    {
            //        Console.WriteLine(String.Format("Name={0}, Version={1}, Culture={2}, PublicKey token={3}",
            //            an.Name,
            //            an.Version,
            //            an.CultureInfo.Name,
            //            (BitConverter.ToString(an.GetPublicKeyToken()))));
            //    }
            //}


            //IEnumerable<System.Reflection.Assembly> allAssemblies = AppDomain.CurrentDomain.GetAssemblies();
            //foreach (var a in AppDomain.CurrentDomain.GetAssemblies())
            //{
            //    allAssemblies = allAssemblies.Union(a.GetReferencedAssemblies().Select(b => System.Reflection.Assembly.Load(b)));
            //}
            //var providers = from d in allAssemblies
            //                from c in d.GetTypes()
            //                select c;
            //if (providers == null)
            //{

            //}

            //gfo.GestaoDeFrotaOnLineWS a1 = new gfo.GestaoDeFrotaOnLineWS();
            //var x1 = a1.a1();
            //var x2 = a1.a2();
            //if (x1 == null || x2 == null)
            //{

            //}

            //var loadedAssemblies = AppDomain.CurrentDomain.GetAssemblies().ToList();
            //var loadedPaths = loadedAssemblies.Select(a => a.Location).ToArray();

            //var referencedPaths = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "*.dll");

            //var toLoad = referencedPaths.Where(r => !loadedPaths.Contains(r, StringComparer.InvariantCultureIgnoreCase)).ToList();
            //toLoad
            //    .ForEach(path => loadedAssemblies.Add(AppDomain.CurrentDomain.Load(AssemblyName.GetAssemblyName(path))));
            //if (loadedAssemblies == null)
            //{

            //}

            System.Reflection.Assembly myAssembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.Reflection.AssemblyName myAssemblyName = myAssembly.GetName();
            Version ver = myAssemblyName.Version;
            //1.0.4671.24294
            //1.0.4671.24308
            //1.0.4671.24321

            if (ver == null)
            {

            }
        }
    }
}
