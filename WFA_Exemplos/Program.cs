using System;
using System.Windows.Forms;
using WFA_Workflow;

namespace WindowsFormsApplication1
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("pt-BR");
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("pt-BR");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.Skins.SkinManager.Default.RegisterAssembly(typeof(DevExpress.UserSkins.FGlobus.Skin).Assembly);

            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "GlobusMais_Silver";

          
            Application.Run(new FrmPrincipal());
        }





    }
}
