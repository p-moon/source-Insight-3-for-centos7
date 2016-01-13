public class BasicProfileViolationEnumerator : IEnumerator<System.Web.Services.Description.BasicProfileViolation>, System.IDisposable, System.Collections.IEnumerator
{

	// Constructors
	public BasicProfileViolationEnumerator(BasicProfileViolationCollection list) {}

	// Methods
	public virtual void Dispose() {}
	public virtual bool MoveNext() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public BasicProfileViolation Current { get{} }
}

