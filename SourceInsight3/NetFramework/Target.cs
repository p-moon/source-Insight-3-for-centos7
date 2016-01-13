public class Target : System.Collections.IEnumerable
{

	// Methods
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public BuildTask AddNewTask(string taskName) {}
	public void RemoveTask(BuildTask taskElement) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Name { get{} }
	public string DependsOnTargets { get{} set{} }
	public string Condition { get{} set{} }
	public bool IsImported { get{} }
}

