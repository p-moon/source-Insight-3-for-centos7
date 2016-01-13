public class ObjectPersistData
{

	// Constructors
	public ObjectPersistData(ControlBuilder builder, System.Collections.IDictionary builtObjects) {}

	// Methods
	public void AddToObjectControlBuilderTable(System.Collections.IDictionary table) {}
	public PropertyEntry GetFilteredProperty(string filter, string name) {}
	public System.Collections.IDictionary GetFilteredProperties(string filter) {}
	public System.Collections.ICollection GetPropertyAllFilters(string name) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Collections.ICollection AllPropertyEntries { get{} }
	public System.Collections.IDictionary BuiltObjects { get{} }
	public System.Collections.ICollection CollectionItems { get{} }
	public System.Collections.ICollection EventEntries { get{} }
	public bool IsCollection { get{} }
	public bool Localize { get{} }
	public Type ObjectType { get{} }
	public string ResourceKey { get{} }
}

