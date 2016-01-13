public interface ICollection : IEnumerable
{

	// Methods
	public abstract virtual void CopyTo(System.Array array, int index) {}

	// Properties
	public int Count { get{} }
	public object SyncRoot { get{} }
	public bool IsSynchronized { get{} }
}

