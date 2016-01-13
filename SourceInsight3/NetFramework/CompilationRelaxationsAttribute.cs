public class CompilationRelaxationsAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public CompilationRelaxationsAttribute(int relaxations) {}
	public CompilationRelaxationsAttribute(CompilationRelaxations relaxations) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public int CompilationRelaxations { get{} }
	public object TypeId { get{} }
}

