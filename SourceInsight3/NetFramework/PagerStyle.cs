public class PagerStyle : Style, System.Web.UI.IParserAccessor, ITemplateable, System.Web.UI.IStateManager, System.ICloneable
{

	// Constructors
	public PagerStyle() {}

	// Methods
	public string GetNextPageText(int currentPageIndex) {}
	public string GetPreviousPageText(int currentPageIndex) {}
	public string GetPageLabelText(int currentPageIndex, int pageCount) {}
	public virtual object Clone() {}
	public void ApplyTo(System.Web.UI.WebControls.WebControl control) {}
	public System.Web.UI.ITemplate GetTemplate(string templateName) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public object NextPageTextKey;
	public object PreviousPageTextKey;
	public object PageLabelKey;

	// Properties
	public string NextPageText { get{} set{} }
	public string PreviousPageText { get{} set{} }
	public string PageLabel { get{} set{} }
	public MobileControl Control { get{} }
	public string Name { get{} set{} }
	public string StyleReference { get{} set{} }
	public object Item { get{} set{} }
	public object Item { get{} }
	public FontInfo Font { get{} }
	public Alignment Alignment { get{} set{} }
	public Wrapping Wrapping { get{} set{} }
	public System.Drawing.Color ForeColor { get{} set{} }
	public System.Drawing.Color BackColor { get{} set{} }
	public bool IsTemplated { get{} }
	public DeviceSpecific DeviceSpecific { get{} set{} }
}

