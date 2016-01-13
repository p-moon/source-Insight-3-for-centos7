public class AssemblyName : System.Runtime.InteropServices._AssemblyName, System.ICloneable, System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IDeserializationCallback
{

	// Constructors
	public AssemblyName() {}
	public AssemblyName(string assemblyName) {}

	// Methods
	public static bool ReferenceMatchesDefinition(AssemblyName reference, AssemblyName definition) {}
	public virtual object Clone() {}
	public static AssemblyName GetAssemblyName(string assemblyFile) {}
	public byte[] GetPublicKey() {}
	public void SetPublicKey(byte[] publicKey) {}
	public byte[] GetPublicKeyToken() {}
	public void SetPublicKeyToken(byte[] publicKeyToken) {}
	public virtual string ToString() {}
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public virtual void OnDeserialization(object sender) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Name { get{} set{} }
	public System.Version Version { get{} set{} }
	public System.Globalization.CultureInfo CultureInfo { get{} set{} }
	public string CodeBase { get{} set{} }
	public string EscapedCodeBase { get{} }
	public ProcessorArchitecture ProcessorArchitecture { get{} set{} }
	public AssemblyNameFlags Flags { get{} set{} }
	public System.Configuration.Assemblies.AssemblyHashAlgorithm HashAlgorithm { get{} set{} }
	public System.Configuration.Assemblies.AssemblyVersionCompatibility VersionCompatibility { get{} set{} }
	public StrongNameKeyPair KeyPair { get{} set{} }
	public string FullName { get{} }
}

