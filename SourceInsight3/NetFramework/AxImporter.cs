public class AxImporter
{

	// Constructors
	public AxImporter(Options options) {}

	// Methods
	public static string GetFileOfTypeLib(System.Runtime.InteropServices.TYPELIBATTR& tlibattr) {}
	public string GenerateFromFile(System.IO.FileInfo file) {}
	public string GenerateFromTypeLibrary(System.Runtime.InteropServices.UCOMITypeLib typeLib) {}
	public string GenerateFromTypeLibrary(System.Runtime.InteropServices.UCOMITypeLib typeLib, System.Guid clsid) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string[] GeneratedAssemblies { get{} }
	public System.Runtime.InteropServices.TYPELIBATTR[] GeneratedTypeLibAttributes { get{} }
	public string[] GeneratedSources { get{} }
}

