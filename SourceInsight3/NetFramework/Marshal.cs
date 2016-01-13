public class Marshal
{

	// Methods
	public static byte ReadByte(object ptr, int ofs) {}
	public static byte ReadByte(System.IntPtr ptr, int ofs) {}
	public static short ReadInt16(object ptr, int ofs) {}
	public static short ReadInt16(System.IntPtr ptr, int ofs) {}
	public static int ReadInt32(System.IntPtr ptr, int ofs) {}
	public static void WriteByte(out object ptr, int ofs, byte val) {}
	public static void WriteInt16(out object ptr, int ofs, short val) {}
	public static void WriteInt32(out object ptr, int ofs, int val) {}
	public static int ReadInt32(object ptr, int ofs) {}
	public static long ReadInt64(object ptr, int ofs) {}
	public static long ReadInt64(System.IntPtr ptr, int ofs) {}
	public static void WriteByte(System.IntPtr ptr, int ofs, byte val) {}
	public static void WriteInt16(System.IntPtr ptr, int ofs, short val) {}
	public static void WriteInt32(System.IntPtr ptr, int ofs, int val) {}
	public static void WriteInt64(System.IntPtr ptr, int ofs, long val) {}
	public static void WriteInt64(out object ptr, int ofs, long val) {}
	public static int GetLastWin32Error() {}
	public static string PtrToStringAnsi(System.IntPtr ptr, int len) {}
	public static string PtrToStringUni(System.IntPtr ptr, int len) {}
	public static int SizeOf(object structure) {}
	public static int SizeOf(Type t) {}
	public static System.IntPtr UnsafeAddrOfPinnedArrayElement(System.Array arr, int index) {}
	public static System.IntPtr GetExceptionPointers() {}
	public static int GetExceptionCode() {}
	public static void StructureToPtr(object structure, System.IntPtr ptr, bool fDeleteOld) {}
	public static void DestroyStructure(System.IntPtr ptr, Type structuretype) {}
	public static int GetHRForException(System.Exception e) {}
	public static System.IntPtr GetUnmanagedThunkForManagedMethodPtr(System.IntPtr pfnMethodToWrap, System.IntPtr pbSignature, int cbSignature) {}
	public static System.IntPtr GetManagedThunkForUnmanagedMethodPtr(System.IntPtr pfnMethodToWrap, System.IntPtr pbSignature, int cbSignature) {}
	public static int GetTypeLibLcid(System.Runtime.InteropServices.ComTypes.ITypeLib typelib) {}
	public static System.IntPtr GetITypeInfoForType(Type t) {}
	public static object GetObjectForIUnknown(System.IntPtr pUnk) {}
	public static object GetUniqueObjectForIUnknown(System.IntPtr unknown) {}
	public static object GetTypedObjectForIUnknown(System.IntPtr pUnk, Type t) {}
	public static System.IntPtr CreateAggregatedObject(System.IntPtr pOuter, object o) {}
	public static bool IsComObject(object o) {}
	public static bool IsTypeVisibleFromCom(Type t) {}
	public static int QueryInterface(System.IntPtr pUnk, System.Guid& iidout , System.IntPtr& ppv) {}
	public static int AddRef(System.IntPtr pUnk) {}
	public static int Release(System.IntPtr pUnk) {}
	public static void GetNativeVariantForObject(object obj, System.IntPtr pDstNativeVariant) {}
	public static object GetObjectForNativeVariant(System.IntPtr pSrcNativeVariant) {}
	public static object[] GetObjectsForNativeVariants(System.IntPtr aSrcNativeVariant, int cVars) {}
	public static int GetStartComSlot(Type t) {}
	public static int GetEndComSlot(Type t) {}
	public static System.Reflection.MemberInfo GetMethodInfoForComSlot(Type t, int slot, ComMemberType& memberType) {}
	public static void ChangeWrapperHandleStrength(object otp, bool fIsWeak) {}
	public static string PtrToStringAnsi(System.IntPtr ptr) {}
	public static string PtrToStringAuto(System.IntPtr ptr, int len) {}
	public static string PtrToStringUni(System.IntPtr ptr) {}
	public static string PtrToStringAuto(System.IntPtr ptr) {}
	public static System.IntPtr OffsetOf(Type t, string fieldName) {}
	public static void Copy(int[] source, int startIndex, System.IntPtr destination, int length) {}
	public static void Copy(char[] source, int startIndex, System.IntPtr destination, int length) {}
	public static void Copy(short[] source, int startIndex, System.IntPtr destination, int length) {}
	public static void Copy(long[] source, int startIndex, System.IntPtr destination, int length) {}
	public static void Copy(float[] source, int startIndex, System.IntPtr destination, int length) {}
	public static void Copy(double[] source, int startIndex, System.IntPtr destination, int length) {}
	public static void Copy(byte[] source, int startIndex, System.IntPtr destination, int length) {}
	public static void Copy(System.IntPtr[] source, int startIndex, System.IntPtr destination, int length) {}
	public static void Copy(System.IntPtr source, int[] destination, int startIndex, int length) {}
	public static void Copy(System.IntPtr source, char[] destination, int startIndex, int length) {}
	public static void Copy(System.IntPtr source, short[] destination, int startIndex, int length) {}
	public static void Copy(System.IntPtr source, long[] destination, int startIndex, int length) {}
	public static void Copy(System.IntPtr source, float[] destination, int startIndex, int length) {}
	public static void Copy(System.IntPtr source, double[] destination, int startIndex, int length) {}
	public static void Copy(System.IntPtr source, byte[] destination, int startIndex, int length) {}
	public static void Copy(System.IntPtr source, System.IntPtr[] destination, int startIndex, int length) {}
	public static byte ReadByte(System.IntPtr ptr) {}
	public static short ReadInt16(System.IntPtr ptr) {}
	public static int ReadInt32(System.IntPtr ptr) {}
	public static System.IntPtr ReadIntPtr(object ptr, int ofs) {}
	public static System.IntPtr ReadIntPtr(System.IntPtr ptr, int ofs) {}
	public static System.IntPtr ReadIntPtr(System.IntPtr ptr) {}
	public static long ReadInt64(System.IntPtr ptr) {}
	public static void WriteByte(System.IntPtr ptr, byte val) {}
	public static void WriteInt16(System.IntPtr ptr, short val) {}
	public static void WriteInt16(System.IntPtr ptr, int ofs, char val) {}
	public static void WriteInt16(out object ptr, int ofs, char val) {}
	public static void WriteInt16(System.IntPtr ptr, char val) {}
	public static void WriteInt32(System.IntPtr ptr, int val) {}
	public static void WriteIntPtr(System.IntPtr ptr, int ofs, System.IntPtr val) {}
	public static void WriteIntPtr(out object ptr, int ofs, System.IntPtr val) {}
	public static void WriteIntPtr(System.IntPtr ptr, System.IntPtr val) {}
	public static void WriteInt64(System.IntPtr ptr, long val) {}
	public static int GetHRForLastWin32Error() {}
	public static void Prelink(System.Reflection.MethodInfo m) {}
	public static void PrelinkAll(Type c) {}
	public static int NumParamBytes(System.Reflection.MethodInfo m) {}
	public static void PtrToStructure(System.IntPtr ptr, object structure) {}
	public static object PtrToStructure(System.IntPtr ptr, Type structureType) {}
	public static System.IntPtr GetHINSTANCE(System.Reflection.Module m) {}
	public static void ThrowExceptionForHR(int errorCode) {}
	public static void ThrowExceptionForHR(int errorCode, System.IntPtr errorInfo) {}
	public static System.Exception GetExceptionForHR(int errorCode) {}
	public static System.Exception GetExceptionForHR(int errorCode, System.IntPtr errorInfo) {}
	public static System.Threading.Thread GetThreadFromFiberCookie(int cookie) {}
	public static System.IntPtr AllocHGlobal(System.IntPtr cb) {}
	public static System.IntPtr AllocHGlobal(int cb) {}
	public static void FreeHGlobal(System.IntPtr hglobal) {}
	public static System.IntPtr ReAllocHGlobal(System.IntPtr pv, System.IntPtr cb) {}
	public static System.IntPtr StringToHGlobalAnsi(string s) {}
	public static System.IntPtr StringToCoTaskMemAnsi(string s) {}
	public static System.IntPtr StringToHGlobalUni(string s) {}
	public static System.IntPtr StringToHGlobalAuto(string s) {}
	public static string GetTypeLibName(UCOMITypeLib pTLB) {}
	public static string GetTypeLibName(System.Runtime.InteropServices.ComTypes.ITypeLib typelib) {}
	public static System.Guid GetTypeLibGuid(UCOMITypeLib pTLB) {}
	public static System.Guid GetTypeLibGuid(System.Runtime.InteropServices.ComTypes.ITypeLib typelib) {}
	public static int GetTypeLibLcid(UCOMITypeLib pTLB) {}
	public static System.Guid GetTypeLibGuidForAssembly(System.Reflection.Assembly asm) {}
	public static void GetTypeLibVersionForAssembly(System.Reflection.Assembly inputAssemblyout , System.Int32& majorVersionout , System.Int32& minorVersion) {}
	public static string GetTypeInfoName(UCOMITypeInfo pTI) {}
	public static string GetTypeInfoName(System.Runtime.InteropServices.ComTypes.ITypeInfo typeInfo) {}
	public static Type GetTypeForITypeInfo(System.IntPtr piTypeInfo) {}
	public static System.IntPtr GetIUnknownForObject(object o) {}
	public static System.IntPtr GetIUnknownForObjectInContext(object o) {}
	public static System.IntPtr GetIDispatchForObject(object o) {}
	public static System.IntPtr GetIDispatchForObjectInContext(object o) {}
	public static System.IntPtr GetComInterfaceForObject(object o, Type T) {}
	public static System.IntPtr GetComInterfaceForObjectInContext(object o, Type t) {}
	public static int ReleaseComObject(object o) {}
	public static int FinalReleaseComObject(object o) {}
	public static object GetComObjectData(object obj, object key) {}
	public static bool SetComObjectData(object obj, object key, object data) {}
	public static object CreateWrapperOfType(object o, Type t) {}
	public static void ReleaseThreadCache() {}
	public static System.IntPtr AllocCoTaskMem(int cb) {}
	public static System.IntPtr ReAllocCoTaskMem(System.IntPtr pv, int cb) {}
	public static void FreeCoTaskMem(System.IntPtr ptr) {}
	public static void FreeBSTR(System.IntPtr ptr) {}
	public static System.IntPtr StringToCoTaskMemUni(string s) {}
	public static System.IntPtr StringToCoTaskMemAuto(string s) {}
	public static System.IntPtr StringToBSTR(string s) {}
	public static string PtrToStringBSTR(System.IntPtr ptr) {}
	public static int GetComSlotForMethodInfo(System.Reflection.MemberInfo m) {}
	public static System.Guid GenerateGuidForType(Type type) {}
	public static string GenerateProgIdForType(Type type) {}
	public static object BindToMoniker(string monikerName) {}
	public static object GetActiveObject(string progID) {}
	public static System.Delegate GetDelegateForFunctionPointer(System.IntPtr ptr, Type t) {}
	public static System.IntPtr GetFunctionPointerForDelegate(System.Delegate d) {}
	public static System.IntPtr SecureStringToBSTR(System.Security.SecureString s) {}
	public static System.IntPtr SecureStringToCoTaskMemAnsi(System.Security.SecureString s) {}
	public static System.IntPtr SecureStringToGlobalAllocAnsi(System.Security.SecureString s) {}
	public static System.IntPtr SecureStringToCoTaskMemUnicode(System.Security.SecureString s) {}
	public static System.IntPtr SecureStringToGlobalAllocUnicode(System.Security.SecureString s) {}
	public static void ZeroFreeBSTR(System.IntPtr s) {}
	public static void ZeroFreeCoTaskMemAnsi(System.IntPtr s) {}
	public static void ZeroFreeGlobalAllocAnsi(System.IntPtr s) {}
	public static void ZeroFreeCoTaskMemUnicode(System.IntPtr s) {}
	public static void ZeroFreeGlobalAllocUnicode(System.IntPtr s) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int SystemDefaultCharSize;
	public int SystemMaxDBCSCharSize;
}

