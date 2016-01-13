public class MimeTextMatch
{

	// Constructors
	public MimeTextMatch() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Name { get{} set{} }
	public string Type { get{} set{} }
	public int Group { get{} set{} }
	public int Capture { get{} set{} }
	public int Repeats { get{} set{} }
	public string RepeatsString { get{} set{} }
	public string Pattern { get{} set{} }
	public bool IgnoreCase { get{} set{} }
	public MimeTextMatchCollection Matches { get{} }
}

