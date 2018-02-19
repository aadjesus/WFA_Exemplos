using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
//using Microsoft.TeamFoundation.Client;
//using Microsoft.TeamFoundation.Server;

namespace WFA_Workflow
{
    public partial class FrmConecTFS : Form
    {
        public FrmConecTFS()
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

        private void FrmConecTFS_Shown(object sender, EventArgs e)
        {

            //TfsTeamProjectCollection a1 = new TfsTeamProjectCollection(new Uri("http://tfsserver:8080/tfs"));

            //IGroupSecurityService iGroupSecurityService12 = a1.GetService<IGroupSecurityService>();

            //if (iGroupSecurityService12 == null)
            //{

            //}


            //TfsTeamProjectCollection tfsTeamProjectCollection = new TfsTeamProjectCollection(new Uri("http://tfsserver:8080/tfs"));
            //IGroupSecurityService iGroupSecurityService = tfsTeamProjectCollection.GetService<IGroupSecurityService>();

            //IEnumerable<Identity> listaIdentity = iGroupSecurityService.ReadIdentities(
            //        SearchFactor.Sid,
            //        iGroupSecurityService.ReadIdentity(SearchFactor.EveryoneApplicationGroup,
            //                                           null,
            //                                           QueryMembership.Direct).Members,
            //        QueryMembership.None)
            //    //.Where(w => w.AccountName.StartsWith("Desenvolvimento"))
            //    .Select(s => iGroupSecurityService.ReadIdentity(SearchFactor.Sid, s.Sid, QueryMembership.Expanded))
            //    .Where(w => w.Members.Length > 0);

            //dataGridView1.DataSource = listaIdentity
            //    .Aggregate(new List<Identity>(), (a, b) =>
            //    {
            //        a.AddRange(iGroupSecurityService.ReadIdentities(SearchFactor.Sid, b.Members, QueryMembership.None));
            //        return a;
            //    })
            //    .Distinct()
            //    .OrderBy(o => o.DisplayName)
            //    .ToArray();

            //MessageBox.Show(String.Concat(
            //    FGlobus.Util.Util.AmbienteBGMRodotec,
            //    Environment.NewLine,
            //    FGlobus.Util.Util.AmbienteDesenvolvimento));

            ////var xxx = new System.Net.WebClient().DownloadString("http://tfsserver/sites/BGMRodotec/GlobusMais/Dashboards/ProjectDashboard_wss.aspx");
            ////var xxx = new System.Net.WebClient().DownloadString("http://192.1.1.45:8080/tfs/bgmrodotec");
            ////if (xxx == null)
            ////{

            ////}

            //TcpClient client = new TcpClient("tfsserver", 8080);

            //MessageBox.Show(String.Concat(client.Connected));

        }
    }


}
