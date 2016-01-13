public class Match : Group
{

	// Methods
	public Match NextMatch() {}
	public virtual string Result(string replacement) {}
	public static Match Synchronized(Match inner) {}
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Match Empty { get{} }
	public GroupCollection Groups { get{} }
	public bool Success { get{} }
	public CaptureCollection Captures { get{} }
	public int Index { get{} }
	public int Length { get{} }
	public string Value { get{} }
}

