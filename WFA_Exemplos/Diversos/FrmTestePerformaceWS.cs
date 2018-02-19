using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WFA_Workflow
{
    public partial class FrmTestePerformaceWS : Form
    {
        public FrmTestePerformaceWS()
        {
            InitializeComponent();
        }

        private void Teste_Json_Click(object sender, EventArgs e)
        {
            //DateTime dateTime1 = DateTime.Now;
            //this.IniJson.Text = dateTime1.ToString();

            //CTR.ControleWS ctr = new CTR.ControleWS();
            //string tetse = ctr.Teste_Json();
            //System.Web.Script.Serialization.JavaScriptSerializer serializacaoJson = new System.Web.Script.Serialization.JavaScriptSerializer();
            //serializacaoJson.MaxJsonLength = Int32.MaxValue;

            //this.QtdeTeste_Json.Text = (serializacaoJson.DeserializeObject(tetse) as System.Collections.IList).Count.ToString();
            //this.FinJson.Text = DateTime.Now.Subtract(dateTime1).ToString();
        }

        private void Teste_JsonCompactado_Click(object sender, EventArgs e)
        {
            //DateTime dateTime1 = DateTime.Now;
            //this.IniJsonComp.Text = dateTime1.ToString();

            //CTR.ControleWS ctr = new CTR.ControleWS();
            //string tetse = Decompress(ctr.Teste_JsonCompactado());

            //System.Web.Script.Serialization.JavaScriptSerializer serializacaoJson = new System.Web.Script.Serialization.JavaScriptSerializer();
            //serializacaoJson.MaxJsonLength = Int32.MaxValue;
            //var objeto = serializacaoJson.DeserializeObject(tetse);

            //this.QtdeTeste_JsonCompactado.Text = (objeto as System.Collections.IList).Count.ToString();
            //this.FinJsonComp.Text = DateTime.Now.Subtract(dateTime1).ToString();
        }

        private void Teste_Normal_Click(object sender, EventArgs e)
        {
            //DateTime dateTime1 = DateTime.Now;
            //this.IniNormal.Text = dateTime1.ToString();

            //CTR.ControleWS ctr = new CTR.ControleWS();
            //object tetse = ctr.Teste_Normal();

            //this.QtdeTeste_Normal.Text = (tetse as System.Collections.IList).Count.ToString();
            //this.FinNormal.Text = DateTime.Now.Subtract(dateTime1).ToString();
        }

        public static string Decompress(string compressedText)
        {
            byte[] gzBuffer = Convert.FromBase64String(compressedText);
            using (MemoryStream ms = new MemoryStream())
            {
                int msgLength = BitConverter.ToInt32(gzBuffer, 0);
                ms.Write(gzBuffer, 4, (gzBuffer.Length - 4));

                byte[] buffer = new byte[msgLength];

                ms.Position = 0;
                using (System.IO.Compression.GZipStream zip = new System.IO.Compression.GZipStream(ms, System.IO.Compression.CompressionMode.Decompress))
                {
                    zip.Read(buffer, 0, buffer.Length);
                }

                return Encoding.UTF8.GetString(buffer);
            }
        }

        public static string Compress(string text)
        {
            
            byte[] buffer = Encoding.UTF8.GetBytes(text);
            MemoryStream ms = new MemoryStream();
            using (System.IO.Compression.GZipStream zip = new System.IO.Compression.GZipStream(ms, System.IO.Compression.CompressionMode.Compress, true))
            {
                zip.Write(buffer, 0, buffer.Length);
            }

            ms.Position = 0;
            MemoryStream outStream = new MemoryStream();

            byte[] compressed = new byte[ms.Length];
            ms.Read(compressed, 0, compressed.Length);

            byte[] gzBuffer = new byte[compressed.Length + 4];
            System.Buffer.BlockCopy(compressed, 0, gzBuffer, 4, compressed.Length);
            System.Buffer.BlockCopy(BitConverter.GetBytes(buffer.Length), 0, gzBuffer, 0, 4);
            return Convert.ToBase64String(gzBuffer);
        }
    }
}
