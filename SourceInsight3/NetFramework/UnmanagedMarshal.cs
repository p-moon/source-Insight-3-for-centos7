public class UnmanagedMarshal
{

	// Methods
	public static UnmanagedMarshal DefineUnmanagedMarshal(System.Runtime.InteropServices.UnmanagedType unmanagedType) {}
	public static UnmanagedMarshal DefineByValTStr(int elemCount) {}
	public static UnmanagedMarshal DefineSafeArray(System.Runtime.InteropServices.UnmanagedType elemType) {}
	public static UnmanagedMarshal DefineByValArray(int elemCount) {}
	public static UnmanagedMarshal DefineLPArray(System.Runtime.InteropServices.UnmanagedType elemType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Runtime.InteropServices.UnmanagedType GetUnmanagedType { get{} }
	public System.Guid IIDGuid { get{} }
	public int ElementCount { get{} }
	public System.Runtime.InteropServices.UnmanagedType BaseType { get{} }
}

