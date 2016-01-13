public class InstanceCreationEditor
{

	// Methods
	public abstract virtual object CreateInstance(ITypeDescriptorContext context, Type instanceType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Text { get{} }
}

