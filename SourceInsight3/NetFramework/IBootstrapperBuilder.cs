public interface IBootstrapperBuilder
{

	// Methods
	public abstract virtual BuildResults Build(BuildSettings settings) {}

	// Properties
	public string Path { get{} set{} }
	public ProductCollection Products { get{} }
}

