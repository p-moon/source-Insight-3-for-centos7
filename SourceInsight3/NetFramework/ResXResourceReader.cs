public class ResXResourceReader : IResourceReader, System.Collections.IEnumerable, System.IDisposable
{

	// Constructors
	public ResXResourceReader(string fileName) {}
	public ResXResourceReader(string fileName, System.ComponentModel.Design.ITypeResolutionService typeResolver) {}
	public ResXResourceReader(System.IO.TextReader reader) {}
	public ResXResourceReader(System.IO.TextReader reader, System.ComponentModel.Design.ITypeResolutionService typeResolver) {}
	public ResXResourceReader(System.IO.Stream stream) {}
	public ResXResourceReader(System.IO.Stream stream, System.ComponentModel.Design.ITypeResolutionService typeResolver) {}
	public ResXResourceReader(System.IO.Stream stream, System.Reflection.AssemblyName[] assemblyNames) {}
	public ResXResourceReader(System.IO.TextReader reader, System.Reflection.AssemblyName[] assemblyNames) {}
	public ResXResourceReader(string fileName, System.Reflection.AssemblyName[] assemblyNames) {}

	// Methods
	public virtual void Close() {}
	public static ResXResourceReader FromFileContents(string fileContents) {}
	public static ResXResourceReader FromFileContents(string fileContents, System.ComponentModel.Design.ITypeResolutionService typeResolver) {}
	public static ResXResourceReader FromFileContents(string fileContents, System.Reflection.AssemblyName[] assemblyNames) {}
	public virtual System.Collections.IDictionaryEnumerator GetEnumerator() {}
	public System.Collections.IDictionaryEnumerator GetMetadataEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string BasePath { get{} set{} }
	public bool UseResXDataNodes { get{} set{} }
}

