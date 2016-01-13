public interface IResourceReader : System.Collections.IEnumerable, System.IDisposable
{

	// Methods
	public abstract virtual void Close() {}
	public abstract virtual System.Collections.IDictionaryEnumerator GetEnumerator() {}
}

