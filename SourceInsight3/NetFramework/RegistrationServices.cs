public class RegistrationServices : IRegistrationServices
{

	// Constructors
	public RegistrationServices() {}

	// Methods
	public virtual bool RegisterAssembly(System.Reflection.Assembly assembly, AssemblyRegistrationFlags flags) {}
	public virtual bool UnregisterAssembly(System.Reflection.Assembly assembly) {}
	public virtual Type[] GetRegistrableTypesInAssembly(System.Reflection.Assembly assembly) {}
	public virtual string GetProgIdForType(Type type) {}
	public virtual void RegisterTypeForComClients(Type type, System.Guid& g) {}
	public virtual System.Guid GetManagedCategoryGuid() {}
	public virtual bool TypeRequiresRegistration(Type type) {}
	public virtual bool TypeRepresentsComType(Type type) {}
	public virtual int RegisterTypeForComClients(Type type, RegistrationClassContext classContext, RegistrationConnectionType flags) {}
	public virtual void UnregisterTypeForComClients(int cookie) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

