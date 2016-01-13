public interface IProductCollection
{

	// Methods
	public abstract virtual Product Item(int index) {}
	public abstract virtual Product Product(string productCode) {}

	// Properties
	public int Count { get{} }
}

