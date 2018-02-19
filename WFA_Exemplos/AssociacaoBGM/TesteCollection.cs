using System;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace WFA_Workflow.AutorizaGridsBGMx
{
    //~TabPageEx()
    //  {
    //      GC.SuppressFinalize(this);
    //  }

    public partial class TesteCollection : UserControl
    {
        public TesteCollection()
        {
            InitializeComponent();
        }

        private ColunaAutorizaBGMCollection _colunas = new ColunaAutorizaBGMCollection();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        //[Editor(typeof(ComplexItemCollectionEditor), typeof(System.Drawing.Design.UITypeEditor))]
        public ColunaAutorizaBGMCollection Colunas
        {
            get
            {
                return _colunas;
            }
        }

        //[ListBindable(false)]
        //[TypeConverter(typeof(DevExpress.Utils.Design.UniversalCollectionTypeConverter))]

        [Serializable()]
        public class ColunaAutorizaBGMCollection : CollectionBase
        {
            public ColunaAutorizaBGMCollection()
            {
            }

            public ColunaAutorizaBGM Add(ColunaAutorizaBGM colunaAutorizaBGM)
            {
                this.InnerList.Add(colunaAutorizaBGM);
                return colunaAutorizaBGM;
            }

            public void AddRange(ColunaAutorizaBGM[] colunaAutorizaBGM)
            {
                this.InnerList.AddRange(colunaAutorizaBGM);
            }

            public void Remove(ColunaAutorizaBGM colunaAutorizaBGM)
            {
                this.InnerList.Remove(colunaAutorizaBGM);
            }

            public bool Contains(ColunaAutorizaBGM colunaAutorizaBGM)
            {
                return this.InnerList.Contains(colunaAutorizaBGM);
            }

            public ColunaAutorizaBGM this[int i]
            {
                get
                {
                    return this.InnerList[i] as ColunaAutorizaBGM;
                }
                set
                {
                    this.InnerList[i] = value;
                }
            }

            public ColunaAutorizaBGM[] GetValues()
            {
                ColunaAutorizaBGM[] colunaAutorizaBGM = new ColunaAutorizaBGM[this.InnerList.Count];

                this.InnerList.CopyTo(0, colunaAutorizaBGM, 0, this.InnerList.Count);

                return colunaAutorizaBGM;
            }
        }

        public class ColunaAutorizaBGM
        {
            public ColunaAutorizaBGM()
            { }

            public ColunaAutorizaBGM(int largura, string titulo)
            {
                _largura = largura;
                _titulo = titulo;
            }


            private string _titulo = String.Empty;
            private string _fieldName = String.Empty;
            private int _largura = 100;

            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public string Titulo
            {
                get { return _titulo; }
                set { _titulo = value; }
            }

            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public int Largura
            {
                get { return _largura; }
                set { _largura = value; }
            }

            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public string FieldName
            {
                get { return _fieldName; }
                set { _fieldName = value; }
            }

            public override string ToString()
            {
                return String.Concat(_titulo, " ,", _fieldName, " ,", _largura);
            }
        }

        public class ComplexItemCollectionEditor : System.ComponentModel.Design.CollectionEditor
        {

            private CollectionForm collectionForm;

            public ComplexItemCollectionEditor(Type type) : base(type) { }


            public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
            {

                if (this.collectionForm != null && this.collectionForm.Visible)
                {

                    ComplexItemCollectionEditor editor = new ComplexItemCollectionEditor(this.CollectionType);
                    return editor.EditValue(context, provider, value);
                }

                else return base.EditValue(context, provider, value);

            }


            protected override CollectionForm CreateCollectionForm()
            {
                this.collectionForm = base.CreateCollectionForm();
                return this.collectionForm;
            }


            protected override object CreateInstance(Type ItemType)
            {
                ColunaAutorizaBGM ci = (ColunaAutorizaBGM)base.CreateInstance(ItemType);
                if (this.Context.Instance != null)
                    ci.Titulo = "aaaaa";

                return ci;
            }
        }
    }
}
