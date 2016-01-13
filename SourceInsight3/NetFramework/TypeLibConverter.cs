public class TypeLibConverter : ITypeLibConverter
{

	// Constructors
	public TypeLibConverter() {}

	// Methods
	public virtual System.Reflection.Emit.AssemblyBuilder ConvertTypeLibToAssembly(object typeLib, string asmFileName, int flags, ITypeLibImporterNotifySink notifySink, byte[] publicKey, System.Reflection.StrongNameKeyPair keyPair, bool unsafeInterfaces) {}
	public virtual System.Reflection.Emit.AssemblyBuilder ConvertTypeLibToAssembly(object typeLib, string asmFileName, TypeLibImporterFlags flags, ITypeLibImporterNotifySink notifySink, byte[] publicKey, System.Reflection.StrongNameKeyPair keyPair, string asmNamespace, System.Version asmVersion) {}
	public virtual object ConvertAssemblyToTypeLib(System.Reflection.Assembly assembly, string strTypeLibName, TypeLibExporterFlags flags, ITypeLibExporterNotifySink notifySink) {}
	public virtual bool GetPrimaryInteropAssembly(System.Guid g, int major, int minor, int lcidout , System.String& asmNameout , System.String& asmCodeBase) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

