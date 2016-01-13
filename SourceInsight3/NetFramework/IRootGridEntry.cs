public interface IRootGridEntry
{

	// Methods
	public abstract virtual void ResetBrowsableAttributes() {}
	public abstract virtual void ShowCategories(bool showCategories) {}

	// Properties
	public System.ComponentModel.AttributeCollection BrowsableAttributes { get{} set{} }
}

