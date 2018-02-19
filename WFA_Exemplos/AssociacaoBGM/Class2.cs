
namespace WFA_Workflow.AutorizaGridsBGMx
{
    //[Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
    ////[ToolboxItem(true), ToolboxBitmap(typeof(ToolboxIconResourceFinder), "FloorsGrouping.bmp")]
    //[DisplayName("Floors Group")]
    //[Editor("WindowsFormsControlLibrary2.FloorsGrouping, WindowsFormsControlLibrary2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=197889249da45bfc", typeof(UITypeEditor))]
    //[Description("Floorssssssss")]
    //[Category("Saino")]
    //[DefaultProperty("Text")]
    //[DesignerCategory("Component")] //Form //Designer //Empty String ("")
    //public partial class FloorsGrouping : Bar
    //{
    //    private Tabs tabs = new Tabs();

    //    public FloorsGrouping()
    //    {
    //        InitializeComponent();
    //        this.AutoHide = true;
    //    }

    //    [Category("Data")]
    //    [DisplayName("Tabs")]
    //    [Description("Tabsssssssssssss")]
    //    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    //    [Editor(typeof(ItemsCollectionEditor), typeof(UITypeEditor))]
    //    public Tabs Tab
    //    {
    //        get
    //        {
    //            //AddTabs();
    //            return tabs;
    //        }
    //        //set
    //        //{
    //        //AddTabs();
    //        //}
    //    }

    //    public void AddTabs()
    //    {
    //        foreach (DockContainerItem dciItem in Tab)
    //        {
    //            if (!Parent.Controls.ContainsKey(dciItem.Name))
    //            {
    //                Items.Add(dciItem);
    //            }
    //        }
    //    }
    //}

    //[DisplayName("Floors Information")]
    //[Description("Floors Informationnnnnnnnnnnnnnnn")]
    //[DefaultProperty("Text")]
    //[DesignerCategory("Component")]
    //[ToolboxItem(false)]
    //public class FloorsInformation : DockContainerItem
    //{
    //    /// <summary>
    //    /// Required designer variable.
    //    /// </summary>
    //    private System.ComponentModel.IContainer components = null;

    //    private SimilarFloorsInformation similarFloorsInformation = new SimilarFloorsInformation();
    //    private AllFloorsInformation allFloorsInformation = new AllFloorsInformation();
    //    private string text = "Floors Information";

    //    public FloorsInformation()
    //    {

    //    }

    //    [Category("Data")]
    //    [DisplayName("Similar Floors Panel")]
    //    [Description("Similar Floors Panellllllllllllllllllll")]
    //    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    //    public SimilarFloorsInformation SimilarFloorsInfo
    //    {
    //        get
    //        {
    //            return similarFloorsInformation;
    //        }
    //        set
    //        {
    //            similarFloorsInformation = value;
    //        }
    //    }

    //    [Category("Data")]
    //    [DisplayName("All Floors Group")]
    //    [Description("All Floors Groupppppppppppppp")]
    //    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    //    public AllFloorsInformation AllFloorsInfo
    //    {
    //        get
    //        {
    //            return allFloorsInformation;
    //        }
    //        set
    //        {
    //            allFloorsInformation = value;
    //        }
    //    }

    //    protected override void Dispose(bool disposing)
    //    {
    //        if (disposing && (components != null))
    //        {
    //            components.Dispose();
    //        }
    //        base.Dispose(disposing);
    //    }
    //}

    //public class Tabs : CollectionBase
    //{
    //    public FloorsInformation this[int intIndex]
    //    {
    //        get
    //        {
    //            return (FloorsInformation)InnerList[intIndex];
    //        }
    //        set
    //        {
    //            InnerList[intIndex] = value;
    //        }
    //    }

    //    public int Add(FloorsInformation finfItemType)
    //    {
    //        return InnerList.Add(finfItemType);
    //    }

    //    public bool Contains(FloorsInformation finfItemType)
    //    {
    //        return InnerList.Contains(finfItemType);
    //    }

    //    public void Remove(FloorsInformation finfItemType)
    //    {
    //        InnerList.Remove(finfItemType);
    //    }

    //    public void Insert(int intIndex, FloorsInformation finfItemType)
    //    {
    //        InnerList.Insert(intIndex, finfItemType);
    //    }

    //    public FloorsInformation[] GetValues()
    //    {
    //        FloorsInformation[] finfItemType = new FloorsInformation[InnerList.Count];
    //        InnerList.CopyTo(0, finfItemType, 0, InnerList.Count);
    //        return finfItemType;
    //    }
    //}

    //public class ItemsCollectionEditor : CollectionEditor
    //{
    //    private Type[] typItems;

    //    public ItemsCollectionEditor(Type typItem)
    //        : base(typItem)
    //    {
    //        typItems = new Type[] { typeof(FloorsInformation) };
    //    }

    //    protected override Type[] CreateNewItemTypes()
    //    {
    //        return typItems;
    //    }

    //    protected override CollectionForm CreateCollectionForm()
    //    {
    //        CollectionForm collectionForm = base.CreateCollectionForm();
    //        collectionForm.Text = "Tabs Collection Editor";
    //        return collectionForm;
    //        //return base.CreateCollectionForm();
    //    }

    //    protected override object SetItems(object editValue, object[] value)
    //    {
    //        return base.SetItems(editValue, value);
    //    }
    //}
}


