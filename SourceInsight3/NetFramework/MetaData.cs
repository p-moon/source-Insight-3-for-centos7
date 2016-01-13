public class MetaData
{

	// Constructors
	public MetaData() {}

	// Methods
	public static void ConvertTypesToSchemaToFile(Type[] types, SdlType sdlType, string path) {}
	public static void ConvertTypesToSchemaToStream(Type[] types, SdlType sdlType, System.IO.Stream outputStream) {}
	public static void ConvertTypesToSchemaToFile(ServiceType[] types, SdlType sdlType, string path) {}
	public static void ConvertTypesToSchemaToStream(ServiceType[] serviceTypes, SdlType sdlType, System.IO.Stream outputStream) {}
	public static void RetrieveSchemaFromUrlToStream(string url, System.IO.Stream outputStream) {}
	public static void RetrieveSchemaFromUrlToFile(string url, string path) {}
	public static void ConvertSchemaStreamToCodeSourceStream(bool clientProxy, string outputDirectory, System.IO.Stream inputStream, System.Collections.ArrayList outCodeStreamList, string proxyUrl, string proxyNamespace) {}
	public static void ConvertSchemaStreamToCodeSourceStream(bool clientProxy, string outputDirectory, System.IO.Stream inputStream, System.Collections.ArrayList outCodeStreamList, string proxyUrl) {}
	public static void ConvertSchemaStreamToCodeSourceStream(bool clientProxy, string outputDirectory, System.IO.Stream inputStream, System.Collections.ArrayList outCodeStreamList) {}
	public static void ConvertCodeSourceStreamToAssemblyFile(System.Collections.ArrayList outCodeStreamList, string assemblyPath, string strongNameFilename) {}
	public static void ConvertCodeSourceFileToAssemblyFile(string codePath, string assemblyPath, string strongNameFilename) {}
	public static void SaveStreamToFile(System.IO.Stream inputStream, string path) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

