public class HandleCollector
{

	// Constructors
	public HandleCollector(string name, int initialThreshold) {}
	public HandleCollector(string name, int initialThreshold, int maximumThreshold) {}

	// Methods
	public void Add() {}
	public void Remove() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public int InitialThreshold { get{} }
	public int MaximumThreshold { get{} }
	public string Name { get{} }
}

