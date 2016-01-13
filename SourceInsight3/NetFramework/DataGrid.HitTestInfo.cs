public class HitTestInfo
{

	// Methods
	public virtual bool Equals(object value) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public HitTestInfo Nowhere;

	// Properties
	public int Column { get{} }
	public int Row { get{} }
	public HitTestType Type { get{} }
}

