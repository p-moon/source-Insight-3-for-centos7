public class PropertyValueUIItem
{

	// Constructors
	public PropertyValueUIItem(System.Drawing.Image uiItemImage, PropertyValueUIItemInvokeHandler handler, string tooltip) {}

	// Methods
	public virtual void Reset() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Drawing.Image Image { get{} }
	public PropertyValueUIItemInvokeHandler InvokeHandler { get{} }
	public string ToolTip { get{} }
}

