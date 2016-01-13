public class Module : System.Runtime.InteropServices._Module, System.Runtime.Serialization.ISerializable, ICustomAttributeProvider
{

	// Methods
	public MethodBase ResolveMethod(int metadataToken) {}
	public byte[] ResolveSignature(int metadataToken) {}
	public MethodBase ResolveMethod(int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments) {}
	public FieldInfo ResolveField(int metadataToken) {}
	public FieldInfo ResolveField(int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments) {}
	public Type ResolveType(int metadataToken) {}
	public Type ResolveType(int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments) {}
	public MemberInfo ResolveMember(int metadataToken) {}
	public MemberInfo ResolveMember(int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments) {}
	public string ResolveString(int metadataToken) {}
	public void GetPEKind(out PortableExecutableKinds& peKindout , ImageFileMachine& machine) {}
	public virtual bool Equals(object o) {}
	public virtual int GetHashCode() {}
	public virtual object[] GetCustomAttributes(bool inherit) {}
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) {}
	public virtual bool IsDefined(Type attributeType, bool inherit) {}
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public virtual Type GetType(string className, bool ignoreCase) {}
	public virtual Type GetType(string className) {}
	public virtual Type GetType(string className, bool throwOnError, bool ignoreCase) {}
	public virtual Type[] FindTypes(TypeFilter filter, object filterCriteria) {}
	public virtual Type[] GetTypes() {}
	public bool IsResource() {}
	public FieldInfo[] GetFields() {}
	public FieldInfo[] GetFields(BindingFlags bindingFlags) {}
	public FieldInfo GetField(string name) {}
	public FieldInfo GetField(string name, BindingFlags bindingAttr) {}
	public MethodInfo[] GetMethods() {}
	public MethodInfo[] GetMethods(BindingFlags bindingFlags) {}
	public MethodInfo GetMethod(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) {}
	public MethodInfo GetMethod(string name, Type[] types) {}
	public MethodInfo GetMethod(string name) {}
	public virtual string ToString() {}
	public System.Security.Cryptography.X509Certificates.X509Certificate GetSignerCertificate() {}
	public Type GetType() {}

	// Fields
	public TypeFilter FilterTypeName;
	public TypeFilter FilterTypeNameIgnoreCase;

	// Properties
	public int MDStreamVersion { get{} }
	public string FullyQualifiedName { get{} }
	public System.Guid ModuleVersionId { get{} }
	public int MetadataToken { get{} }
	public string ScopeName { get{} }
	public string Name { get{} }
	public Assembly Assembly { get{} }
	public System.ModuleHandle ModuleHandle { get{} }
}

