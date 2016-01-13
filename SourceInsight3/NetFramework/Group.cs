public class Group : Capture
{

	// Methods
	public static Group Synchronized(Group inner) {}
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool Success { get{} }
	public CaptureCollection Captures { get{} }
	public int Index { get{} }
	public int Length { get{} }
	public string Value { get{} }
}

