public class MenuItemBinding : System.Web.UI.IStateManager, System.ICloneable, System.Web.UI.IDataSourceViewSchemaAccessor
{

	// Constructors
	public MenuItemBinding() {}

	// Methods
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string DataMember { get{} set{} }
	public int Depth { get{} set{} }
	public bool Enabled { get{} set{} }
	public string EnabledField { get{} set{} }
	public string FormatString { get{} set{} }
	public string ImageUrl { get{} set{} }
	public string ImageUrlField { get{} set{} }
	public string NavigateUrl { get{} set{} }
	public string NavigateUrlField { get{} set{} }
	public string PopOutImageUrl { get{} set{} }
	public string PopOutImageUrlField { get{} set{} }
	public bool Selectable { get{} set{} }
	public string SelectableField { get{} set{} }
	public string SeparatorImageUrl { get{} set{} }
	public string SeparatorImageUrlField { get{} set{} }
	public string Target { get{} set{} }
	public string TargetField { get{} set{} }
	public string Text { get{} set{} }
	public string TextField { get{} set{} }
	public string ToolTip { get{} set{} }
	public string ToolTipField { get{} set{} }
	public string Value { get{} set{} }
	public string ValueField { get{} set{} }
}

