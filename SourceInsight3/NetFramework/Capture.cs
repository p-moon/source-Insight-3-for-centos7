public class Capture
{

	// Methods
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Index { get{} }
	public int Length { get{} }
	public string Value { get{} }
}

