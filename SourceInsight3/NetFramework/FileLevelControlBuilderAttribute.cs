public class FileLevelControlBuilderAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public FileLevelControlBuilderAttribute(Type builderType) {}

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public virtual bool Match(object obj) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public FileLevelControlBuilderAttribute Default;

	// Properties
	public Type BuilderType { get{} }
	public object TypeId { get{} }
}

