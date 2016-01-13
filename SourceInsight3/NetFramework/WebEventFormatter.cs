public class WebEventFormatter
{

	// Methods
	public void AppendLine(string s) {}
	public string ToString() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int IndentationLevel { get{} set{} }
	public int TabSize { get{} set{} }
}

