public class Product : NameMap
{

	// Constructors
	public Product(string Name, uint Mask) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public string name;
	public uint mask;
}

