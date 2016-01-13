public class ResInfo
{

	// Constructors
	public ResInfo(string filename, string name, bool isPublic, bool isLinked) {}
	public ResInfo(string resinfo, bool isLinked) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public string filename;
	public string fullpath;
	public string name;
	public bool isPublic;
	public bool isLinked;
}

