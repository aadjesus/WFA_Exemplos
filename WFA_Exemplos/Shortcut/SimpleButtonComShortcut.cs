using System;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace WFA_Workflow.Shortcut
{
    public partial class SimpleButtonComShortcut : DevExpress.XtraEditors.SimpleButton
    {
        public SimpleButtonComShortcut()
        {
            InitializeComponent();
        }

        public SimpleButtonComShortcut(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private BarManager _baraManager;

        public BarManager BaraManager
        {
            get { return _baraManager; }
            set { _baraManager = value; }
        }        

        private Keys _shortcut;
        public Keys Shortcut
        {
            get { return _shortcut; }
            set { _shortcut = value; }
        }


        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);

            if (_baraManager != null && _shortcut != Keys.None)
            {
                int item = _baraManager.Items.Add(
                    new BarButtonItem(
                        _baraManager, 
                        string.Concat("bbi_", Name),
                        -1, 
                        new BarShortcut(_shortcut)));

                _baraManager.Items[item].ItemClick += new ItemClickEventHandler(OnBarButtonItemItemClick);
            }
        }


        private void OnBarButtonItemItemClick(object sender, ItemClickEventArgs e)
        {
            OnClick(EventArgs.Empty);
        }
    }
}
