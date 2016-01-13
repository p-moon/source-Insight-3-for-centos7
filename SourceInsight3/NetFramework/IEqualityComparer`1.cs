public interface IEqualityComparer<T>
{

	// Methods
	public abstract virtual bool Equals(T x, T y) {}
	public abstract virtual int GetHashCode(T obj) {}
}

