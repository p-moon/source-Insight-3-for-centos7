public class DataGridViewColumnDesignTimeVisibleAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public DataGridViewColumnDesignTimeVisibleAttribute(bool visible) {}
	public DataGridViewColumnDesignTimeVisibleAttribute() {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool IsDefaultAttribute() {}
	public virtual bool Match(object obj) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public DataGridViewColumnDesignTimeVisibleAttribute Yes;
	public DataGridViewColumnDesignTimeVisibleAttribute No;
	public DataGridViewColumnDesignTimeVisibleAttribute Default;

	// Properties
	public bool Visible { get{} }
	public object TypeId { get{} }
}

