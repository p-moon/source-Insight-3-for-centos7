public class AssemblyReferenceCollection : System.Collections.IEnumerable
{

	// Methods
	public AssemblyReference Add(string path) {}
	public AssemblyReference Add(AssemblyReference assembly) {}
	public void Clear() {}
	public AssemblyReference Find(string name) {}
	public AssemblyReference Find(AssemblyIdentity identity) {}
	public AssemblyReference FindTargetPath(string targetPath) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public void Remove(AssemblyReference assemblyReference) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public AssemblyReference Item { get{} }
	public int Count { get{} }
}

