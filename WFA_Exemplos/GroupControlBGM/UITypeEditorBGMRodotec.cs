using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Windows.Forms.Design;

namespace WFA_Exemplos.GroupControlBGM
{
    internal class UITypeEditorBGMRodotec : UITypeEditor
    {
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.DropDown;
        }

        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object valor)
        {
            if (context == null || provider == null)
                return valor;

            IWindowsFormsEditorService editorService = provider.GetService(typeof(IWindowsFormsEditorService)) as IWindowsFormsEditorService;

            if (editorService != null)
            {
                groupControlBGMDemoXOcultar = new GroupControlBGMDemoXOcultar(valor);
                groupControlBGMDemoXOcultar.DoubleClick += delegate(object senderDoubleClick, EventArgs eDoubleClick)
                {
                    editorService.CloseDropDown();
                };

                editorService.DropDownControl(groupControlBGMDemoXOcultar);
                (context.Instance as GroupControlBGMDemoX).Image = groupControlBGMDemoXOcultar.Image;

                return groupControlBGMDemoXOcultar.Ocultar;
            }

            return valor;
        }

        GroupControlBGMDemoXOcultar groupControlBGMDemoXOcultar;
        public override void PaintValue(PaintValueEventArgs e)
        {
            try
            {
                e.Graphics.DrawImage((e.Context.Instance as GroupControlBGMDemoX).Image, e.Bounds);
            }
            catch
            {
                base.PaintValue(e);
            }
        }

        public override bool GetPaintValueSupported(ITypeDescriptorContext context)
        {
            return true;
        }
    }
}
