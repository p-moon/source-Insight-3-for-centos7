public interface IProduct
{

	// Properties
	public ProductBuilder ProductBuilder { get{} }
	public string Name { get{} }
	public string ProductCode { get{} }
	public ProductCollection Includes { get{} }
}

