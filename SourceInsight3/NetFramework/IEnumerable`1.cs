public interface IEnumerable<T> : System.Collections.IEnumerable
{

	// Methods
	public abstract virtual IEnumerator<T> GetEnumerator() {}
}

