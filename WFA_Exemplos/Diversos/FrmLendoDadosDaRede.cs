using System;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace WFA_Workflow
{
    public partial class FrmLendoDadosDaRede : Form
    {
        public FrmLendoDadosDaRede()
        {
            InitializeComponent();



        }

        public void Xisto(object type)
        {
            //PropertyInfo[] listaPropertyInfo = type.GetType().GetProperties();

            //listaPropertyInfo
            //    .Aggregate(listBoxControl1, (a, b) =>
            //    {

            //        try
            //        {
            //            if (b.GetType().GetProperties().Count() > 1)
            //            {
            //                Xisto(b);
            //            }
            //            a.Items.Add(String.Concat(b.Name, " =>"));
            //        }
            //        catch (Exception)
            //        {
            //        }

            //        return a;
            //    });

            //if (listaPropertyInfo.Count() > 1)
            //    Xisto(type);
            //else
            //{
            //    PropertyInfo propertyInfo = listaPropertyInfo.FirstOrDefault(); ;
            //    listBoxControl1.Items.Add(String.Concat(propertyInfo.Name, " =>", propertyInfo.GetValue(propertyInfo, null)));
            //}

        }

        private void FrmLendoDadosDaRede_Shown(object sender, EventArgs e)
        {

            foreach (NetworkInterface adapter in NetworkInterface.GetAllNetworkInterfaces())
            {
                listBoxControl1.Items.Add(String.Concat("adapter.Description      = ", adapter.Description));
                listBoxControl1.Items.Add(String.Concat("Description              = ", adapter.Description));
                listBoxControl1.Items.Add(String.Concat("Id                       = ", adapter.Id));
                //listBoxControl1.Items.Add(String.Concat("LoopbackInterfaceIndex =   ", adapter.LoopbackInterfaceIndex));
                listBoxControl1.Items.Add(String.Concat("Name                     = ", adapter.Name));
                listBoxControl1.Items.Add(String.Concat("NetworkInterfaceType     = ", adapter.NetworkInterfaceType));
                listBoxControl1.Items.Add(String.Concat("OperationalStatus        = ", adapter.OperationalStatus));
                listBoxControl1.Items.Add(String.Concat("Speed                    = ", adapter.Speed));
                //listBoxControl1.Items.Add(String.Concat("GetAllNetworkInterfaces=   ", adapter.GetAllNetworkInterfaces()));
                listBoxControl1.Items.Add(String.Concat("GetIPProperties          = ", adapter.GetIPProperties()));
                listBoxControl1.Items.Add(String.Concat("GetIPv4Statistics        = ", adapter.GetIPv4Statistics()));
                listBoxControl1.Items.Add(String.Concat("GetPhysicalAddress       = ", adapter.GetPhysicalAddress()));

                listBoxControl1.Items.Add(String.Concat("================================================"));

                foreach (UnicastIPAddressInformation unicastIPAddressInformation in adapter.GetIPProperties().UnicastAddresses)
                {

                    listBoxControl1.Items.Add(String.Concat("AddressPreferredLifetime       = ", unicastIPAddressInformation.AddressPreferredLifetime));
                    listBoxControl1.Items.Add(String.Concat("AddressValidLifetime           = ", unicastIPAddressInformation.AddressValidLifetime));
                    listBoxControl1.Items.Add(String.Concat("DhcpLeaseLifetime              = ", unicastIPAddressInformation.DhcpLeaseLifetime));
                    listBoxControl1.Items.Add(String.Concat("DuplicateAddressDetectionState = ", unicastIPAddressInformation.DuplicateAddressDetectionState));
                    listBoxControl1.Items.Add(String.Concat("IPv4Mask                       = ", unicastIPAddressInformation.IPv4Mask));
                    listBoxControl1.Items.Add(String.Concat("Address                        = ", unicastIPAddressInformation.Address));
                    listBoxControl1.Items.Add(String.Concat("PrefixOrigin                   = ", unicastIPAddressInformation.PrefixOrigin));
                    listBoxControl1.Items.Add(String.Concat("SuffixOrigin                   = ", unicastIPAddressInformation.SuffixOrigin));
                }

                listBoxControl1.Items.Add(String.Concat("================================================"));


                foreach (GatewayIPAddressInformation unicastIPAddressInformation in adapter.GetIPProperties().GatewayAddresses)
                {
                    //unicastIPAddressInformation.Address.GetType().GetProperty("IsIPv6LinkLocal").GetValue(unicastIPAddressInformation.Address, null);

                    //unicastIPAddressInformation.Address.GetType().GetProperties()
                    //    .Aggregate(listBoxControl1, (a1, b1) =>
                    //    {
                    //        try
                    //        {
                    //            a1.Items.Add(String.Concat(b1.GetValue(unicastIPAddressInformation.Address, null)));
                    //        }
                    //        catch (Exception)
                    //        {
                    //        }
                    //        return a1;
                    //    });

                    Xisto(unicastIPAddressInformation.Address);

                    //listBoxControl1.Items.Add(String.Concat("Address         = ", unicastIPAddressInformation.Address));
                    //listBoxControl1.Items.Add(String.Concat("AddressFamily   = ", unicastIPAddressInformation.Address.AddressFamily));
                    //listBoxControl1.Items.Add(String.Concat("IsIPv6LinkLocal = ", unicastIPAddressInformation.Address.IsIPv6LinkLocal));
                    //listBoxControl1.Items.Add(String.Concat("IsIPv6Multicast = ", unicastIPAddressInformation.Address.IsIPv6Multicast));
                    //listBoxControl1.Items.Add(String.Concat("IsIPv6SiteLocal = ", unicastIPAddressInformation.Address.IsIPv6SiteLocal));
                    //listBoxControl1.Items.Add(String.Concat("IsIPv6Teredo    = ", unicastIPAddressInformation.Address.IsIPv6Teredo));
                }

                listBoxControl1.Items.Add(String.Concat("================================================"));


            }
        }

    }
}
