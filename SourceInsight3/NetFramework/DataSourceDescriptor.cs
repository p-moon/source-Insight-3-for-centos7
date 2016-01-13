public class DataSourceDescriptor
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Name { get{} }
	public System.Drawing.Bitmap Image { get{} }
	public string TypeName { get{} }
	public bool IsDesignable { get{} }
}

