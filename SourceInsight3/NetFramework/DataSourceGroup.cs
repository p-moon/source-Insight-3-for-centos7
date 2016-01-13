public class DataSourceGroup
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Name { get{} }
	public System.Drawing.Bitmap Image { get{} }
	public DataSourceDescriptorCollection DataSources { get{} }
	public bool IsDefault { get{} }
}

