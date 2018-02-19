using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using DevExpress.Utils.Design;
using DevExpress.XtraEditors;

namespace WFA_Exemplos.SplitContainerDemo
{
    public partial class SplitContainerDemo : GroupControl
    {
        public SplitContainerDemo()
        {
            InitializeComponent();
        }

        public SplitContainerDemo(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            SplitContainer splitContainer = new SplitContainer()
            {
                Dock = DockStyle.Fill
            };
            this.Controls.Add(splitContainer);

            //Orientation = System.Windows.Forms.Orientation.Horizontal;
            //Button button = new Button();
            //Panel panel = new Panel() { Dock = DockStyle.Fill };
            //panel.Controls.Add(button);
            //Panel1.Controls.Add(panel);
        }



        public override ISite Site
        {
            get
            {
                return base.Site;
            }
            set
            {
                base.Site = value;
                IPropertyValueUIService uiService = this.GetService(typeof(IPropertyValueUIService)) as IPropertyValueUIService;

                if (uiService != null)
                {
                    PropertyValueUIHandler x1 = new PropertyValueUIHandler(this.marginPropertyValueUIHandler);
                    if (value == null)
                        uiService.RemovePropertyValueUIHandler(x1);
                    else
                        uiService.AddPropertyValueUIHandler(x1);
                }
            }
        }

        public int VerticalMargin
        {
            get
            {
                return vMargin;
            }
            set
            {
                vMargin = value;
            }
        }

        // Field storing the value of the HorizontalMargin property. 
        private int hMargin;

        // Field storing the value of the VerticalMargin property. 
        private int vMargin;
        public int HorizontalMargin
        {
            get
            {
                return hMargin;
            }
            set
            {
                hMargin = value;
            }
        }

        private void marginPropertyValueUIHandler(
            ITypeDescriptorContext context,
            PropertyDescriptor propDesc,
            ArrayList itemList)
        {
            if (propDesc.DisplayName.Equals("HorizontalMargin"))
            {
                itemList.Add(new PropertyValueUIItem(Properties.Resources.ButtonEditBGMLupa, new PropertyValueUIItemInvokeHandler(this.marginInvoke), "Test ToolTip"));
            }
            if (propDesc.DisplayName.Equals("VerticalMargin"))
            {
                itemList.Add(new PropertyValueUIItem(Properties.Resources.ButtonEditBGMLupa, new PropertyValueUIItemInvokeHandler(this.marginInvoke), "Test ToolTip"));
            }
        }

        private void marginInvoke(System.ComponentModel.ITypeDescriptorContext context, System.ComponentModel.PropertyDescriptor propDesc, PropertyValueUIItem item)
        {
            MessageBox.Show("Test invoke message box");
        }
    }


}
