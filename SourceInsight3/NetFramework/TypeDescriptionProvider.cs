public class TypeDescriptionProvider
{

	// Methods
	public virtual object CreateInstance(System.IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) {}
	public virtual System.Collections.IDictionary GetCache(object instance) {}
	public virtual ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) {}
	public virtual string GetFullComponentName(object component) {}
	public Type GetReflectionType(Type objectType) {}
	public Type GetReflectionType(object instance) {}
	public virtual Type GetReflectionType(Type objectType, object instance) {}
	public ICustomTypeDescriptor GetTypeDescriptor(Type objectType) {}
	public ICustomTypeDescriptor GetTypeDescriptor(object instance) {}
	public virtual ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

