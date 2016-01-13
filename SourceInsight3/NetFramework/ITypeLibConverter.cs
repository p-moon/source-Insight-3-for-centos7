public interface ITypeLibConverter
{

	// Methods
	public abstract virtual System.Reflection.Emit.AssemblyBuilder ConvertTypeLibToAssembly(object typeLib, string asmFileName, TypeLibImporterFlags flags, ITypeLibImporterNotifySink notifySink, byte[] publicKey, System.Reflection.StrongNameKeyPair keyPair, string asmNamespace, System.Version asmVersion) {}
	public abstract virtual object ConvertAssemblyToTypeLib(System.Reflection.Assembly assembly, string typeLibName, TypeLibExporterFlags flags, ITypeLibExporterNotifySink notifySink) {}
	public abstract virtual bool GetPrimaryInteropAssembly(System.Guid g, int major, int minor, int lcidout , System.String& asmNameout , System.String& asmCodeBase) {}
	public abstract virtual System.Reflection.Emit.AssemblyBuilder ConvertTypeLibToAssembly(object typeLib, string asmFileName, int flags, ITypeLibImporterNotifySink notifySink, byte[] publicKey, System.Reflection.StrongNameKeyPair keyPair, bool unsafeInterfaces) {}
}

