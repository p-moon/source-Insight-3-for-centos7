public interface IListSource
{

	// Methods
	public abstract virtual System.Collections.IList GetList() {}

	// Properties
	public bool ContainsListCollection { get{} }
}

