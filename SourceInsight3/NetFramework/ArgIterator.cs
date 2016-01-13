public class ArgIterator : ValueType
{

	// Constructors
	public ArgIterator(RuntimeArgumentHandle arglist) {}
	public ArgIterator(RuntimeArgumentHandle arglist, void* ptr) {}

	// Methods
	public int GetRemainingCount() {}
	public TypedReference GetNextArg() {}
	public TypedReference GetNextArg(RuntimeTypeHandle rth) {}
	public void End() {}
	public RuntimeTypeHandle GetNextArgType() {}
	public virtual int GetHashCode() {}
	public virtual bool Equals(object o) {}
	public virtual string ToString() {}
	public Type GetType() {}
}

