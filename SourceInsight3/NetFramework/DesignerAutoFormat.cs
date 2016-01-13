public class DesignerAutoFormat
{

	// Methods
	public abstract virtual void Apply(System.Web.UI.Control control) {}
	public virtual System.Web.UI.Control GetPreviewControl(System.Web.UI.Control runtimeControl) {}
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Name { get{} }
	public DesignerAutoFormatStyle Style { get{} }
}

