public interface _SignatureHelper
{

	// Methods
	public abstract virtual void GetTypeInfoCount(out System.UInt32& pcTInfo) {}
	public abstract virtual void GetTypeInfo(uint iTInfo, uint lcid, System.IntPtr ppTInfo) {}
	public abstract virtual void GetIDsOfNames(System.Guid& riid, System.IntPtr rgszNames, uint cNames, uint lcid, System.IntPtr rgDispId) {}
	public abstract virtual void Invoke(uint dispIdMember, System.Guid& riid, uint lcid, short wFlags, System.IntPtr pDispParams, System.IntPtr pVarResult, System.IntPtr pExcepInfo, System.IntPtr puArgErr) {}
}

