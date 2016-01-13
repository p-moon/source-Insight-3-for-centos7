public class DataObjectAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public DataObjectAttribute() {}
	public DataObjectAttribute(bool isDataObject) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool IsDefaultAttribute() {}
	public virtual bool Match(object obj) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public DataObjectAttribute DataObject;
	public DataObjectAttribute NonDataObject;
	public DataObjectAttribute Default;

	// Properties
	public bool IsDataObject { get{} }
	public object TypeId { get{} }
}

