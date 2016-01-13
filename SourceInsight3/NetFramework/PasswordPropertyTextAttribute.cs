public class PasswordPropertyTextAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public PasswordPropertyTextAttribute() {}
	public PasswordPropertyTextAttribute(bool password) {}

	// Methods
	public virtual bool Equals(object o) {}
	public virtual int GetHashCode() {}
	public virtual bool IsDefaultAttribute() {}
	public virtual bool Match(object obj) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public PasswordPropertyTextAttribute Yes;
	public PasswordPropertyTextAttribute No;
	public PasswordPropertyTextAttribute Default;

	// Properties
	public bool Password { get{} }
	public object TypeId { get{} }
}

