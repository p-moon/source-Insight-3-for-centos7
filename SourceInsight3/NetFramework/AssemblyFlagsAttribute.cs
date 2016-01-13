public class AssemblyFlagsAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public AssemblyFlagsAttribute(uint flags) {}
	public AssemblyFlagsAttribute(int assemblyFlags) {}
	public AssemblyFlagsAttribute(AssemblyNameFlags assemblyFlags) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public uint Flags { get{} }
	public int AssemblyFlags { get{} }
	public object TypeId { get{} }
}

