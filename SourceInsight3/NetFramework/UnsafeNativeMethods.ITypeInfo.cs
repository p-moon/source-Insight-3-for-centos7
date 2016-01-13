public interface ITypeInfo
{

	// Methods
	public abstract virtual int GetTypeAttr(out System.IntPtr& pTypeAttr) {}
	public abstract virtual int GetTypeComp(out ITypeComp& pTComp) {}
	public abstract virtual int GetFuncDesc(int indexout , System.IntPtr& pFuncDesc) {}
	public abstract virtual int GetVarDesc(int indexout , System.IntPtr& pVarDesc) {}
	public abstract virtual int GetNames(int memidout , string[] rgBstrNames, int cMaxNamesout , System.Int32& cNames) {}
	public abstract virtual int GetRefTypeOfImplType(int indexout , System.Int32& pRefType) {}
	public abstract virtual int GetImplTypeFlags(int indexout , int pImplTypeFlags) {}
	public abstract virtual int GetIDsOfNames(System.IntPtr rgszNames, int cNamesout , System.IntPtr& pMemId) {}
	public abstract virtual int Invoke() {}
	public abstract virtual int GetDocumentation(int memidout , System.String& pBstrNameout , System.String& pBstrDocStringout , System.Int32& pdwHelpContextout , System.String& pBstrHelpFile) {}
	public abstract virtual int GetDllEntry(int memid, System.Runtime.InteropServices.ComTypes.INVOKEKIND invkindout , string pBstrDllNameout , string pBstrNameout , short pwOrdinal) {}
	public abstract virtual int GetRefTypeInfo(System.IntPtr hreftypeout , ITypeInfo& pTypeInfo) {}
	public abstract virtual int AddressOfMember() {}
	public abstract virtual int CreateInstance(System.IntPtr& pUnkOuter, System.Guid& riidout , object ppvObj) {}
	public abstract virtual int GetMops(int memidout , string pBstrMops) {}
	public abstract virtual int GetContainingTypeLib(out ITypeLib[] ppTLibout , int[] pIndex) {}
	public abstract virtual void ReleaseTypeAttr(System.IntPtr typeAttr) {}
	public abstract virtual void ReleaseFuncDesc(System.IntPtr funcDesc) {}
	public abstract virtual void ReleaseVarDesc(System.IntPtr varDesc) {}
}

