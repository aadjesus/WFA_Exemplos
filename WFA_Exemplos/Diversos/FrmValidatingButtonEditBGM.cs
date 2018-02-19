using System;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using FGlobus.Componentes.WinForms;

namespace WFA_Workflow
{
    public partial class FrmValidatingButtonEditBGM : MasterForm
    {
        public FrmValidatingButtonEditBGM()
        {
            InitializeComponent();         

        }


        public void ExecutarMetodo<T>(
            ref T tipo,
            Expression<Func<T, object>> propriedade,
            Teste2 metodo,
            object parametros)
        {
            bool executaConsulta = tipo == null;
            try
            {
                if (tipo != null)
                {
                    MemberExpression memberExpression = null;
                    UnaryExpression unaryExpression = propriedade.Body as UnaryExpression;

                    if (unaryExpression == null)
                        memberExpression = propriedade.Body as MemberExpression;
                    else
                        memberExpression = unaryExpression.Operand as MemberExpression;

                    object valorPropriedade = tipo.GetType().GetProperty(memberExpression.Member.Name).GetValue(tipo, null);
                    
                    
                    executaConsulta = "a".ToString().CompareTo(valorPropriedade.ToString()) != 0;
                }
            }
            catch
            {
                throw new Exception("# ERRO # Sintaxe incorreta para a propriedade.");
            }

            if (executaConsulta)
            {

                var retorno = (metodo as Teste2).Invoke(parametros);

                if (retorno is Array)
                    retorno = (retorno as Array)
                        .OfType<T>()
                        .FirstOrDefault();

                tipo = (T)retorno;
            }
        }

       
        private void buttonEditBGM1_Validating(object sender, CancelEventArgs e)
        {            
            //if (SentidoNavegacao == eSentidoNavegacao.Fore)
            //{
            //    buttonEditBGM1.ExecutarMetodo1<GFO.MensagemValidadorDTO>(
            //        ref xisto,
            //        p => p.CodMensagem,
            //        new DelegateExecutaMetodo(gestaoDeFrotaOnLineWS.GenericoConsultaPorChave<GFO.MensagemValidadorDTO>),
            //        Convert.ToInt32(buttonEditBGM1.Text)
            //}

        }

        private void FrmValidatingButtonEditBGM_Shown(object sender, EventArgs e)
        {
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.Skins.SkinManager.Default.RegisterAssembly(typeof(DevExpress.UserSkins.FGlobus.Skin).Assembly);

            IPAddress[] ips;

            string hostname = "172.16.0.143";
            ips = Dns.GetHostAddresses(hostname);

            Console.WriteLine("GetHostAddresses({0}) returns:", hostname);

            foreach (IPAddress ip in ips)
            {
                Console.WriteLine("    {0}", ip);
            }

            foreach (NetworkInterface adapter in NetworkInterface.GetAllNetworkInterfaces())
            {
                foreach (UnicastIPAddressInformation unicastIPAddressInformation in adapter.GetIPProperties().UnicastAddresses)
                {
                    if (unicastIPAddressInformation.Address.AddressFamily == AddressFamily.InterNetwork)
                    {
                        //if (address.Equals(unicastIPAddressInformation.Address))
                        //{
                        //    return unicastIPAddressInformation.IPv4Mask;
                        //}
                    }
                }
            }


            string s = System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName; ;

            IPAddress[] addressList = Dns.GetHostByName(Dns.GetHostName()).AddressList;

            for (int i = 0; i < addressList.Length; i++) s += addressList[i].ToString() + "\n";
            if (s == null)
            {

            }

            //xisto = new GFO.MensagemValidadorDTO() { CodMensagem = 1 };
            //GFO.DefinicaoDePeriodosDTO x1 = null;

            //this.ExecutarMetodo<GFO.MensagemValidadorDTO>(
            //    // 1
            //    ref xisto,
            //    p => p.CodMensagem,
            //    gestaoDeFrotaOnLineWS.GenericoConsultaPorChave<GFO.MensagemValidadorDTO>,
            //    1

            //    // 2
            //    //ref x1,
            //    //p => p.CodigoDefinicaoPeriodos,
            //    //gestaoDeFrotaOnLineWS.GenericoConsultaBasica<GFO.DefinicaoDePeriodosDTO>,                
            //    //new GFO.sCondicaoAdicionalCriteria()
            //    //{
            //    //    Operador = GFO.eOperador.Igual,
            //    //    Propriedade = "CodigoEmpresa",
            //    //    Valor = 8
            //    //}


            //    // 3
            //    //ref x1,
            //    //p => p.CodigoDefinicaoPeriodos,
            //    //gestaoDeFrotaOnLineWS.GenericoConsultaPorChave<GFO.DefinicaoDePeriodosDTO>,
            //    //new GFO.DefinicaoDePeriodosDTO() { CodigoEmpresa = 8, CodigoFilial = 9, CodigoDefinicaoPeriodos = 8 }



            //);


        }
    }

    public delegate object Teste2(object a);
}