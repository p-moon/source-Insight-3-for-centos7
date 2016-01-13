public class LoaderOptimizationAttribute : Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public LoaderOptimizationAttribute(byte value) {}
	public LoaderOptimizationAttribute(LoaderOptimization value) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public LoaderOptimization Value { get{} }
	public object TypeId { get{} }
}

