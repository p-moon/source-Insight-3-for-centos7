public class ComponentEditor
{

	// Methods
	public bool EditComponent(object component) {}
	public abstract virtual bool EditComponent(ITypeDescriptorContext context, object component) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

