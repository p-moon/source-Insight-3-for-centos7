public class ObfuscationAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public ObfuscationAttribute() {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public bool StripAfterObfuscation { get{} set{} }
	public bool Exclude { get{} set{} }
	public bool ApplyToMembers { get{} set{} }
	public string Feature { get{} set{} }
	public object TypeId { get{} }
}

