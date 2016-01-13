public class CodeIdentifiers
{

	// Constructors
	public CodeIdentifiers() {}
	public CodeIdentifiers(bool caseSensitive) {}

	// Methods
	public void Clear() {}
	public string MakeRightCase(string identifier) {}
	public string MakeUnique(string identifier) {}
	public void AddReserved(string identifier) {}
	public void RemoveReserved(string identifier) {}
	public string AddUnique(string identifier, object value) {}
	public bool IsInUse(string identifier) {}
	public void Add(string identifier, object value) {}
	public void Remove(string identifier) {}
	public object ToArray(Type type) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool UseCamelCasing { get{} set{} }
}

