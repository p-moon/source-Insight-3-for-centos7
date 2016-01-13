public class DataObjectFieldAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public DataObjectFieldAttribute(bool primaryKey) {}
	public DataObjectFieldAttribute(bool primaryKey, bool isIdentity) {}
	public DataObjectFieldAttribute(bool primaryKey, bool isIdentity, bool isNullable) {}
	public DataObjectFieldAttribute(bool primaryKey, bool isIdentity, bool isNullable, int length) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public bool IsIdentity { get{} }
	public bool IsNullable { get{} }
	public int Length { get{} }
	public bool PrimaryKey { get{} }
	public object TypeId { get{} }
}

