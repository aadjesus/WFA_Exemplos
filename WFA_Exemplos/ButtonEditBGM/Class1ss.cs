// Developer Express Code Central Example:
// How to register a custom editor for use in the XtraGrid
// 
// This is an example for the Knowledge Base article. Please refer to the article
// for the explanation.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E756

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;

namespace WindowsApplication1
{
    [UserRepositoryItem("Register")]
    public class RepositoryItemMyButtonEdit : RepositoryItemButtonEdit
    {
        static RepositoryItemMyButtonEdit()
        {
            Register();
        }
        public RepositoryItemMyButtonEdit() { }

        internal const string EditorName = "MyButtonEdit";

        public static void Register()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(EditorName, typeof(MyButtonEdit),
                typeof(RepositoryItemMyButtonEdit), typeof(DevExpress.XtraEditors.ViewInfo.ButtonEditViewInfo),
                new MyButtonEditPainter(), true, null));
        }

        public override string EditorTypeName
        {
            get { return EditorName; }
        }


    }
    /// <summary>
    /// MyButtonEdit is a descendant from ButtonEdit.
    /// It displays a dialog form below the text box when the edit button is clicked.
    /// </summary>
    public class MyButtonEdit : ButtonEdit
    {
        static MyButtonEdit()
        {
            RepositoryItemMyButtonEdit.Register();
        }
      
        public override string EditorTypeName
        {
            get { return RepositoryItemMyButtonEdit.EditorName; }
        }
        
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemMyButtonEdit Properties
        {
            get { return base.Properties as RepositoryItemMyButtonEdit; }
        }

        protected override void OnClickButton(DevExpress.XtraEditors.Drawing.EditorButtonObjectInfoArgs buttonInfo)
        {
            ShowPopupForm();
            base.OnClickButton(buttonInfo);
        }
        protected virtual void ShowPopupForm()
        {
            using (Form form = new Form())
            {
                form.StartPosition = FormStartPosition.Manual;
                form.Location = this.PointToScreen(new Point(0, Height));
                form.ShowDialog();
            }
        }

    }

    public class MyButtonEditPainter : ButtonEditPainter
    {
        public MyButtonEditPainter() : base() { }
        protected override void DrawButton(DevExpress.XtraEditors.ViewInfo.ButtonEditViewInfo viewInfo, EditorButtonObjectInfoArgs info)
        {
            base.DrawButton(viewInfo, info);
            if (info.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)
            {
                Bitmap bmp = new Bitmap(SystemIcons.Information.ToBitmap(), info.Bounds.Width, info.Bounds.Height);
                info.Graphics.DrawImageUnscaled(bmp, info.Bounds);
            }
        }
    }
}
