public class BuildProperty
{

	// Constructors
	public BuildProperty(string propertyName, string propertyValue) {}

	// Methods
	public BuildProperty Clone(bool deepClone) {}
	public virtual string ToString() {}
	public static string op_Explicit(BuildProperty propertyToCast) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Name { get{} }
	public string Value { get{} set{} }
	public string FinalValue { get{} }
	public bool IsImported { get{} }
	public string Condition { get{} set{} }
}

