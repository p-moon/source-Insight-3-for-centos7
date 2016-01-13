public class BuildPropertyGroup : IItemPropertyGrouping, System.Collections.IEnumerable
{

	// Constructors
	public BuildPropertyGroup() {}

	// Methods
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public BuildPropertyGroup Clone(bool deepClone) {}
	public void SetProperty(string propertyName, string propertyValue) {}
	public void SetProperty(string propertyName, string propertyValue, bool treatPropertyValueAsLiteral) {}
	public BuildProperty AddNewProperty(string propertyName, string propertyValue) {}
	public BuildProperty AddNewProperty(string propertyName, string propertyValue, bool treatPropertyValueAsLiteral) {}
	public void RemoveProperty(BuildProperty property) {}
	public void RemoveProperty(string propertyName) {}
	public void Clear() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool IsImported { get{} }
	public string Condition { get{} set{} }
	public int Count { get{} }
	public BuildProperty Item { get{} set{} }
}

