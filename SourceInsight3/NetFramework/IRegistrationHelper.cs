public interface IRegistrationHelper
{

	// Methods
	public abstract virtual void InstallAssembly(string assemblyout , System.String& applicationout , System.String& tlb, InstallationFlags installFlags) {}
	public abstract virtual void UninstallAssembly(string assembly, string application) {}
}

