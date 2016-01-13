public class ConfigurationCollectionAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public ConfigurationCollectionAttribute(Type itemType) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public Type ItemType { get{} }
	public string AddItemName { get{} set{} }
	public string RemoveItemName { get{} set{} }
	public string ClearItemsName { get{} set{} }
	public ConfigurationElementCollectionType CollectionType { get{} set{} }
	public object TypeId { get{} }
}

