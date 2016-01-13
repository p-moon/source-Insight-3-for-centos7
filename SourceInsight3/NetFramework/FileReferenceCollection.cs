public class FileReferenceCollection : System.Collections.IEnumerable
{

	// Methods
	public FileReference Add(string path) {}
	public FileReference Add(FileReference file) {}
	public void Clear() {}
	public FileReference FindTargetPath(string targetPath) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public void Remove(FileReference file) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public FileReference Item { get{} }
	public int Count { get{} }
}

