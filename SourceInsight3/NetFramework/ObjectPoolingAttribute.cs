public class ObjectPoolingAttribute : System.Attribute, System.Runtime.InteropServices._Attribute, IConfigurationAttribute
{

	// Constructors
	public ObjectPoolingAttribute() {}
	public ObjectPoolingAttribute(int minPoolSize, int maxPoolSize) {}
	public ObjectPoolingAttribute(bool enable) {}
	public ObjectPoolingAttribute(bool enable, int minPoolSize, int maxPoolSize) {}

	// Methods
	public virtual bool IsValidTarget(string s) {}
	public virtual bool Apply(System.Collections.Hashtable info) {}
	public virtual bool AfterSaveChanges(System.Collections.Hashtable info) {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public bool Enabled { get{} set{} }
	public int MaxPoolSize { get{} set{} }
	public int MinPoolSize { get{} set{} }
	public int CreationTimeout { get{} set{} }
	public object TypeId { get{} }
}

