public interface IEnumerator
{

	// Methods
	public abstract virtual bool MoveNext() {}
	public abstract virtual void Reset() {}

	// Properties
	public object Current { get{} }
}

