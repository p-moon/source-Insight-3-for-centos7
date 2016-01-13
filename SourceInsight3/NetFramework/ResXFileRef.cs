public class ResXFileRef
{

	// Constructors
	public ResXFileRef(string fileName, string typeName) {}
	public ResXFileRef(string fileName, string typeName, System.Text.Encoding textFileEncoding) {}

	// Methods
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string FileName { get{} }
	public string TypeName { get{} }
	public System.Text.Encoding TextFileEncoding { get{} }
}

