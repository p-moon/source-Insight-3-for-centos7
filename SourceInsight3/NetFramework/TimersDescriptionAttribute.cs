public class TimersDescriptionAttribute : System.ComponentModel.DescriptionAttribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public TimersDescriptionAttribute(string description) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool IsDefaultAttribute() {}
	public virtual bool Match(object obj) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string Description { get{} }
	public object TypeId { get{} }
}

