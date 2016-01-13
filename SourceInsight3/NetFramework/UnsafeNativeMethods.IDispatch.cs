public interface IDispatch
{

	// Methods
	public abstract virtual int GetTypeInfoCount() {}
	public abstract virtual ITypeInfo GetTypeInfo(int iTInfo, int lcid) {}
	public abstract virtual int GetIDsOfNames(System.Guid& riid, string[] rgszNames, int cNames, int lcidout , int[] rgDispId) {}
	public abstract virtual int Invoke(int dispIdMember, System.Guid& riid, int lcid, int dwFlagsout , tagDISPPARAMS pDispParamsout , object[] pVarResultout , tagEXCEPINFO pExcepInfoout , System.IntPtr[] pArgErr) {}
}

