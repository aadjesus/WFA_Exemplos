using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Reflection;

namespace WFA_Exemplos.AssociacaoBGM
{
    public partial class xxxxxxxxxxxxxx : UserControl
    {
        public xxxxxxxxxxxxxx()
        {
            InitializeComponent();
        }

        protected override void CreateHandle()
        {
            //XtraScrollableControl
            ScrollableControl scrollableControl = this.Parent as ScrollableControl;
            if (scrollableControl != null)
            {
                scrollableControl.ControlAdded += zzzzzzzzzzzzz_ControlAdded;
                //scrollableControl.ControlAdded -= zzzzzzzzzzzzz_ControlAdded;
            }

            base.CreateHandle();
        }


        void zzzzzzzzzzzzz_ControlAdded(object sender, ControlEventArgs e)
        {
            MessageBox.Show("1");
        }

        private void Teste_NomeMetodo()
        {
            Panel aaa = new Panel();
            aaa.ControlAdded += rrrrrrrrrrrrrr;

            var x1 = GetEventSubscribers(aaa, "rrrrrrrrrrrrrr");
            if (x1)
            {

            }

            //FieldInfo event_visible_field_info = typeof(Control).GetField("EventVisible", BindingFlags.Static | BindingFlags.NonPublic);
            //object object_value = event
        }


        //            Form form = new Form2();
        //            EventHandlerList events = (EventHandlerList)typeof(Component)
        //                .GetProperty("Events", BindingFlags.NonPublic | BindingFlags.Instance)
        //                .GetValue(form, null);
        //            object key = typeof(Form)
        //                .GetField("EVENT_FORMCLOSING", BindingFlags.NonPublic | BindingFlags.Static)
        //                .GetValue(null);

        //            Delegate handlers = events[key];
        //            foreach (Delegate handler in handlers.GetInvocationList())
        //            {
        //                MethodInfo method = handler.Method;
        //                string name = handler.Target == null ? "" : handler.Target.ToString();
        //                if (handler.Target is Control) name = ((Control)handler.Target).Name;
        //                listBox1.Text = name + "; " + method.DeclaringType.Name + "." + method.Name + Environment.NewLine;
        //            }


        public static bool GetEventSubscribers(object controle, string nomeEvento)
        {
            Type t = controle.GetType();
            var evento = t.GetProperty("Events", BindingFlags.GetProperty | BindingFlags.NonPublic | BindingFlags.Instance);
            //if (evento == null)
                return false;

            //var valorEvento = evento.GetValue(controle) as EventHandlerList;


            //var eventHandlerFieldInfo = valorEvento.GetType().GetField("head", BindingFlags.Instance | BindingFlags.NonPublic);

            //var listEntry = eventHandlerFieldInfo.GetValue(valorEvento);
            //var handler = listEntry.GetType().GetField("handler", BindingFlags.Instance | BindingFlags.NonPublic);
            //var subD = handler.GetValue(listEntry) as Delegate;

            //var x1 = subD.GetInvocationList().Where(w => w.Method.Name == nomeEvento);
            //return x1 != null;

            //Type t = target.GetType();
            //var eventInfo = t.GetEvent("ControlAdded", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static);

            //do
            //{
            //    FieldInfo[] fia = t.GetFields(
            //        BindingFlags.Static |
            //        BindingFlags.Instance |
            //        BindingFlags.NonPublic);
            //    var x12 = t.GetEvent("events", BindingFlags.Static | BindingFlags.Instance | BindingFlags.NonPublic);
            //    if (x12 == null)
            //    {

            //    }

            //    foreach (FieldInfo fi in fia)
            //    {
            //        if (fi.Name == eventName)
            //        {
            //            Delegate d = fi.GetValue(target) as Delegate;
            //            if (d != null)
            //                return d.GetInvocationList();
            //        }
            //        else if (fi.FieldType == typeof(EventHandlerList))
            //        {
            //            //---->
            //            var obj = fi.GetValue(target) as EventHandlerList;
            //            var eventHandlerFieldInfo = obj.GetType().GetField("head", BindingFlags.Instance | BindingFlags.NonPublic);
            //            do
            //            {
            //                var listEntry = eventHandlerFieldInfo.GetValue(obj);
            //                var handler = listEntry.GetType().GetField("handler", BindingFlags.Instance | BindingFlags.NonPublic);
            //                if (handler != null)
            //                {
            //                    var subD = handler.GetValue(listEntry) as Delegate;
            //                    if (subD.GetType() != eventInfo.EventHandlerType)
            //                    {
            //                        eventHandlerFieldInfo = listEntry.GetType().GetField("next", BindingFlags.Instance | BindingFlags.NonPublic);
            //                        obj = listEntry as EventHandlerList;  //<-----------
            //                        continue;
            //                    }
            //                    if (subD != null)
            //                    {
            //                        return subD.GetInvocationList();
            //                    }
            //                }
            //            }
            //            while (eventHandlerFieldInfo != null);
            //        }
            //    }
            //    t = t.BaseType;
            //} while (t != null);
            //return new Delegate[] { };
        }

        void rrrrrrrrrrrrrr(object sender, ControlEventArgs e)
        {
            throw new NotImplementedException();
        }

    }
}
