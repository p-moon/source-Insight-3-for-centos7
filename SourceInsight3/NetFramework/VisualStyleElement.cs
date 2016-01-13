public class VisualStyleElement
{

	// Methods
	public static VisualStyleElement CreateElement(string className, int part, int state) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string ClassName { get{} }
	public int Part { get{} }
	public int State { get{} }
}

