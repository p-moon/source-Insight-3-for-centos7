public class ProductBuilderCollection : IProductBuilderCollection, System.Collections.IEnumerable
{

	// Methods
	public virtual void Add(ProductBuilder builder) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

