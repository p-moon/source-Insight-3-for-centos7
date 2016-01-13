public class Product : IProduct
{

	// Constructors
	public Product() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ProductBuilder ProductBuilder { get{} }
	public string ProductCode { get{} }
	public string Name { get{} }
	public ProductCollection Includes { get{} }
}

