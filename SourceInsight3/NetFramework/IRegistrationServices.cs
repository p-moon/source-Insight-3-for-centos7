public interface IRegistrationServices
{

	// Methods
	public abstract virtual bool RegisterAssembly(System.Reflection.Assembly assembly, AssemblyRegistrationFlags flags) {}
	public abstract virtual bool UnregisterAssembly(System.Reflection.Assembly assembly) {}
	public abstract virtual Type[] GetRegistrableTypesInAssembly(System.Reflection.Assembly assembly) {}
	public abstract virtual string GetProgIdForType(Type type) {}
	public abstract virtual void RegisterTypeForComClients(Type type, System.Guid& g) {}
	public abstract virtual System.Guid GetManagedCategoryGuid() {}
	public abstract virtual bool TypeRequiresRegistration(Type type) {}
	public abstract virtual bool TypeRepresentsComType(Type type) {}
}

