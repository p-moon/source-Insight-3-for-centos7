public interface _MemberInfo
{

	// Methods
	public abstract virtual void GetTypeInfoCount(out System.UInt32& pcTInfo) {}
	public abstract virtual void GetTypeInfo(uint iTInfo, uint lcid, System.IntPtr ppTInfo) {}
	public abstract virtual void GetIDsOfNames(System.Guid& riid, System.IntPtr rgszNames, uint cNames, uint lcid, System.IntPtr rgDispId) {}
	public abstract virtual void Invoke(uint dispIdMember, System.Guid& riid, uint lcid, short wFlags, System.IntPtr pDispParams, System.IntPtr pVarResult, System.IntPtr pExcepInfo, System.IntPtr puArgErr) {}
	public abstract virtual string ToString() {}
	public abstract virtual bool Equals(object other) {}
	public abstract virtual int GetHashCode() {}
	public abstract virtual Type GetType() {}
	public abstract virtual object[] GetCustomAttributes(Type attributeType, bool inherit) {}
	public abstract virtual object[] GetCustomAttributes(bool inherit) {}
	public abstract virtual bool IsDefined(Type attributeType, bool inherit) {}

	// Properties
	public System.Reflection.MemberTypes MemberType { get{} }
	public string Name { get{} }
	public Type DeclaringType { get{} }
	public Type ReflectedType { get{} }
}

