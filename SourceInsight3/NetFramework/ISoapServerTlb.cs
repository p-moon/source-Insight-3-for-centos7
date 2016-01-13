public interface ISoapServerTlb
{

	// Methods
	public abstract virtual void AddServerTlb(string progId, string classId, string interfaceId, string srcTlbPath, string rootWebServer, string baseUrl, string virtualRoot, string clientActivated, string wellKnown, string discoFile, string operationout , System.String& assemblyNameout , System.String& typeName) {}
	public abstract virtual void DeleteServerTlb(string progId, string classId, string interfaceId, string srcTlbPath, string rootWebServer, string baseUrl, string virtualRoot, string operation, string assemblyName, string typeName) {}
}

