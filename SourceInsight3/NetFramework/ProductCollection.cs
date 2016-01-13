public class ProductCollection : IProductCollection, System.Collections.IEnumerable
{

	// Methods
	public virtual Product Item(int index) {}
	public virtual Product Product(string productCode) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
}

