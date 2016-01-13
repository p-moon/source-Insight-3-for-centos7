public class Link
{

	// Constructors
	public Link() {}
	public Link(int start, int length) {}
	public Link(int start, int length, object linkData) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Description { get{} set{} }
	public bool Enabled { get{} set{} }
	public int Length { get{} set{} }
	public object LinkData { get{} set{} }
	public string Name { get{} set{} }
	public int Start { get{} set{} }
	public object Tag { get{} set{} }
	public bool Visited { get{} set{} }
}

