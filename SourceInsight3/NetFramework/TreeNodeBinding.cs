public class TreeNodeBinding : System.Web.UI.IStateManager, System.ICloneable, System.Web.UI.IDataSourceViewSchemaAccessor
{

	// Constructors
	public TreeNodeBinding() {}

	// Methods
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string DataMember { get{} set{} }
	public int Depth { get{} set{} }
	public string FormatString { get{} set{} }
	public string ImageToolTip { get{} set{} }
	public string ImageToolTipField { get{} set{} }
	public string ImageUrl { get{} set{} }
	public string ImageUrlField { get{} set{} }
	public string NavigateUrl { get{} set{} }
	public string NavigateUrlField { get{} set{} }
	public bool PopulateOnDemand { get{} set{} }
	public TreeNodeSelectAction SelectAction { get{} set{} }
	public Nullable<bool> ShowCheckBox { get{} set{} }
	public string Target { get{} set{} }
	public string TargetField { get{} set{} }
	public string Text { get{} set{} }
	public string TextField { get{} set{} }
	public string ToolTip { get{} set{} }
	public string ToolTipField { get{} set{} }
	public string Value { get{} set{} }
	public string ValueField { get{} set{} }
}

