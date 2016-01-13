public class ModuleBuilder : System.Reflection.Module, System.Runtime.InteropServices._Module, System.Runtime.Serialization.ISerializable, System.Reflection.ICustomAttributeProvider, System.Runtime.InteropServices._ModuleBuilder
{

	// Methods
	public virtual Type[] GetTypes() {}
	public virtual Type GetType(string className) {}
	public virtual Type GetType(string className, bool ignoreCase) {}
	public virtual Type GetType(string className, bool throwOnError, bool ignoreCase) {}
	public TypeBuilder DefineType(string name) {}
	public TypeBuilder DefineType(string name, System.Reflection.TypeAttributes attr) {}
	public TypeBuilder DefineType(string name, System.Reflection.TypeAttributes attr, Type parent) {}
	public TypeBuilder DefineType(string name, System.Reflection.TypeAttributes attr, Type parent, int typesize) {}
	public TypeBuilder DefineType(string name, System.Reflection.TypeAttributes attr, Type parent, PackingSize packingSize, int typesize) {}
	public TypeBuilder DefineType(string name, System.Reflection.TypeAttributes attr, Type parent, Type[] interfaces) {}
	public TypeBuilder DefineType(string name, System.Reflection.TypeAttributes attr, Type parent, PackingSize packsize) {}
	public EnumBuilder DefineEnum(string name, System.Reflection.TypeAttributes visibility, Type underlyingType) {}
	public System.Resources.IResourceWriter DefineResource(string name, string description) {}
	public System.Resources.IResourceWriter DefineResource(string name, string description, System.Reflection.ResourceAttributes attribute) {}
	public void DefineManifestResource(string name, System.IO.Stream stream, System.Reflection.ResourceAttributes attribute) {}
	public void DefineUnmanagedResource(byte[] resource) {}
	public void DefineUnmanagedResource(string resourceFileName) {}
	public MethodBuilder DefineGlobalMethod(string name, System.Reflection.MethodAttributes attributes, Type returnType, Type[] parameterTypes) {}
	public MethodBuilder DefineGlobalMethod(string name, System.Reflection.MethodAttributes attributes, System.Reflection.CallingConventions callingConvention, Type returnType, Type[] parameterTypes) {}
	public MethodBuilder DefineGlobalMethod(string name, System.Reflection.MethodAttributes attributes, System.Reflection.CallingConventions callingConvention, Type returnType, Type[] requiredReturnTypeCustomModifiers, Type[] optionalReturnTypeCustomModifiers, Type[] parameterTypes, Type[][] requiredParameterTypeCustomModifiers, Type[][] optionalParameterTypeCustomModifiers) {}
	public MethodBuilder DefinePInvokeMethod(string name, string dllName, System.Reflection.MethodAttributes attributes, System.Reflection.CallingConventions callingConvention, Type returnType, Type[] parameterTypes, System.Runtime.InteropServices.CallingConvention nativeCallConv, System.Runtime.InteropServices.CharSet nativeCharSet) {}
	public MethodBuilder DefinePInvokeMethod(string name, string dllName, string entryName, System.Reflection.MethodAttributes attributes, System.Reflection.CallingConventions callingConvention, Type returnType, Type[] parameterTypes, System.Runtime.InteropServices.CallingConvention nativeCallConv, System.Runtime.InteropServices.CharSet nativeCharSet) {}
	public void CreateGlobalFunctions() {}
	public FieldBuilder DefineInitializedData(string name, byte[] data, System.Reflection.FieldAttributes attributes) {}
	public FieldBuilder DefineUninitializedData(string name, int size, System.Reflection.FieldAttributes attributes) {}
	public TypeToken GetTypeToken(Type type) {}
	public TypeToken GetTypeToken(string name) {}
	public MethodToken GetMethodToken(System.Reflection.MethodInfo method) {}
	public MethodToken GetArrayMethodToken(Type arrayClass, string methodName, System.Reflection.CallingConventions callingConvention, Type returnType, Type[] parameterTypes) {}
	public System.Reflection.MethodInfo GetArrayMethod(Type arrayClass, string methodName, System.Reflection.CallingConventions callingConvention, Type returnType, Type[] parameterTypes) {}
	public MethodToken GetConstructorToken(System.Reflection.ConstructorInfo con) {}
	public FieldToken GetFieldToken(System.Reflection.FieldInfo field) {}
	public StringToken GetStringConstant(string str) {}
	public SignatureToken GetSignatureToken(SignatureHelper sigHelper) {}
	public SignatureToken GetSignatureToken(byte[] sigBytes, int sigLength) {}
	public void SetCustomAttribute(System.Reflection.ConstructorInfo con, byte[] binaryAttribute) {}
	public void SetCustomAttribute(CustomAttributeBuilder customBuilder) {}
	public System.Diagnostics.SymbolStore.ISymbolWriter GetSymWriter() {}
	public System.Diagnostics.SymbolStore.ISymbolDocumentWriter DefineDocument(string url, System.Guid language, System.Guid languageVendor, System.Guid documentType) {}
	public void SetUserEntryPoint(System.Reflection.MethodInfo entryPoint) {}
	public void SetSymCustomAttribute(string name, byte[] data) {}
	public bool IsTransient() {}
	public System.Reflection.MethodBase ResolveMethod(int metadataToken) {}
	public byte[] ResolveSignature(int metadataToken) {}
	public System.Reflection.MethodBase ResolveMethod(int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments) {}
	public System.Reflection.FieldInfo ResolveField(int metadataToken) {}
	public System.Reflection.FieldInfo ResolveField(int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments) {}
	public Type ResolveType(int metadataToken) {}
	public Type ResolveType(int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments) {}
	public System.Reflection.MemberInfo ResolveMember(int metadataToken) {}
	public System.Reflection.MemberInfo ResolveMember(int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments) {}
	public string ResolveString(int metadataToken) {}
	public void GetPEKind(out System.Reflection.PortableExecutableKinds& peKindout , System.Reflection.ImageFileMachine& machine) {}
	public virtual bool Equals(object o) {}
	public virtual int GetHashCode() {}
	public virtual object[] GetCustomAttributes(bool inherit) {}
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) {}
	public virtual bool IsDefined(Type attributeType, bool inherit) {}
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public virtual Type[] FindTypes(System.Reflection.TypeFilter filter, object filterCriteria) {}
	public bool IsResource() {}
	public System.Reflection.FieldInfo[] GetFields() {}
	public System.Reflection.FieldInfo[] GetFields(System.Reflection.BindingFlags bindingFlags) {}
	public System.Reflection.FieldInfo GetField(string name) {}
	public System.Reflection.FieldInfo GetField(string name, System.Reflection.BindingFlags bindingAttr) {}
	public System.Reflection.MethodInfo[] GetMethods() {}
	public System.Reflection.MethodInfo[] GetMethods(System.Reflection.BindingFlags bindingFlags) {}
	public System.Reflection.MethodInfo GetMethod(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Reflection.CallingConventions callConvention, Type[] types, System.Reflection.ParameterModifier[] modifiers) {}
	public System.Reflection.MethodInfo GetMethod(string name, Type[] types) {}
	public System.Reflection.MethodInfo GetMethod(string name) {}
	public virtual string ToString() {}
	public System.Security.Cryptography.X509Certificates.X509Certificate GetSignerCertificate() {}
	public Type GetType() {}

	// Properties
	public string FullyQualifiedName { get{} }
	public int MDStreamVersion { get{} }
	public System.Guid ModuleVersionId { get{} }
	public int MetadataToken { get{} }
	public string ScopeName { get{} }
	public string Name { get{} }
	public System.Reflection.Assembly Assembly { get{} }
	public System.ModuleHandle ModuleHandle { get{} }
}

