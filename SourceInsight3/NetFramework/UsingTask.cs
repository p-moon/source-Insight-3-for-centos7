public class UsingTask
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool IsImported { get{} }
	public string TaskName { get{} }
	public string AssemblyName { get{} }
	public string AssemblyFile { get{} }
	public string Condition { get{} }
}

