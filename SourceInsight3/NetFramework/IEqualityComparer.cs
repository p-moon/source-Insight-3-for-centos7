public interface IEqualityComparer
{

	// Methods
	public abstract virtual bool Equals(object x, object y) {}
	public abstract virtual int GetHashCode(object obj) {}
}

