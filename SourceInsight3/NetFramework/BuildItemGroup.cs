public class BuildItemGroup : IItemPropertyGrouping, System.Collections.IEnumerable
{

	// Constructors
	public BuildItemGroup() {}

	// Methods
	public BuildItem[] ToArray() {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public BuildItem AddNewItem(string itemName, string itemInclude) {}
	public BuildItem AddNewItem(string itemName, string itemInclude, bool treatItemIncludeAsLiteral) {}
	public void RemoveItem(BuildItem itemToRemove) {}
	public void RemoveItemAt(int index) {}
	public BuildItemGroup Clone(bool deepClone) {}
	public void Clear() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool IsImported { get{} }
	public string Condition { get{} set{} }
	public int Count { get{} }
	public BuildItem Item { get{} }
}

