using System.Windows.Forms;

namespace WFA_Workflow
{
    public partial class FrmWebBrowserStream : Form
    {
        public FrmWebBrowserStream()
        {
            InitializeComponent();

            string text = "<html><head><title>Stuff</title></head>" +
                "<body><h1>TESTE</h1></body></html>";

            //byte[] bytes = Encoding.UTF8.GetBytes(text);
            //MemoryStream ms = new MemoryStream();
            //ms.Write(bytes, 0, bytes.Length);
            //ms.Position = 0;
            //webBrowser1.DocumentStream = ms;

            webBrowser1.DocumentText = text;
            
        }

        static void SetDocumentStream(WebBrowser browser)
        {
            
        }

    }


}
