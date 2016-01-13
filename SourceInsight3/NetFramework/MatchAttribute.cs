public class MatchAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public MatchAttribute(string pattern) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string Pattern { get{} set{} }
	public int Group { get{} set{} }
	public int Capture { get{} set{} }
	public bool IgnoreCase { get{} set{} }
	public int MaxRepeats { get{} set{} }
	public object TypeId { get{} }
}

