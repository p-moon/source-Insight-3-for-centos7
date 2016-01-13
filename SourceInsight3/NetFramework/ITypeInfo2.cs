public interface ITypeInfo2 : ITypeInfo
{

	// Methods
	public abstract virtual void GetTypeAttr(out System.IntPtr& ppTypeAttr) {}
	public abstract virtual void GetTypeComp(out ITypeComp& ppTComp) {}
	public abstract virtual void GetFuncDesc(int indexout , System.IntPtr& ppFuncDesc) {}
	public abstract virtual void GetVarDesc(int indexout , System.IntPtr& ppVarDesc) {}
	public abstract virtual void GetNames(int memidout , string[] rgBstrNames, int cMaxNamesout , System.Int32& pcNames) {}
	public abstract virtual void GetRefTypeOfImplType(int indexout , System.Int32& href) {}
	public abstract virtual void GetImplTypeFlags(int indexout , IMPLTYPEFLAGS& pImplTypeFlags) {}
	public abstract virtual void GetIDsOfNames(string[] rgszNames, int cNamesout , int[] pMemId) {}
	public abstract virtual void Invoke(object pvInstance, int memid, short wFlags, DISPPARAMS& pDispParams, System.IntPtr pVarResult, System.IntPtr pExcepInfoout , System.Int32& puArgErr) {}
	public abstract virtual void GetDocumentation(int indexout , System.String& strNameout , System.String& strDocStringout , System.Int32& dwHelpContextout , System.String& strHelpFile) {}
	public abstract virtual void GetDllEntry(int memid, INVOKEKIND invKind, System.IntPtr pBstrDllName, System.IntPtr pBstrName, System.IntPtr pwOrdinal) {}
	public abstract virtual void GetRefTypeInfo(int hRefout , ITypeInfo& ppTI) {}
	public abstract virtual void AddressOfMember(int memid, INVOKEKIND invKindout , System.IntPtr& ppv) {}
	public abstract virtual void CreateInstance(object pUnkOuter, System.Guid& riidout , System.Object& ppvObj) {}
	public abstract virtual void GetMops(int memidout , System.String& pBstrMops) {}
	public abstract virtual void GetContainingTypeLib(out ITypeLib& ppTLBout , System.Int32& pIndex) {}
	public abstract virtual void ReleaseTypeAttr(System.IntPtr pTypeAttr) {}
	public abstract virtual void ReleaseFuncDesc(System.IntPtr pFuncDesc) {}
	public abstract virtual void ReleaseVarDesc(System.IntPtr pVarDesc) {}
	public abstract virtual void GetTypeKind(out TYPEKIND& pTypeKind) {}
	public abstract virtual void GetTypeFlags(out System.Int32& pTypeFlags) {}
	public abstract virtual void GetFuncIndexOfMemId(int memid, INVOKEKIND invKindout , System.Int32& pFuncIndex) {}
	public abstract virtual void GetVarIndexOfMemId(int memidout , System.Int32& pVarIndex) {}
	public abstract virtual void GetCustData(System.Guid& guidout , System.Object& pVarVal) {}
	public abstract virtual void GetFuncCustData(int index, System.Guid& guidout , System.Object& pVarVal) {}
	public abstract virtual void GetParamCustData(int indexFunc, int indexParam, System.Guid& guidout , System.Object& pVarVal) {}
	public abstract virtual void GetVarCustData(int index, System.Guid& guidout , System.Object& pVarVal) {}
	public abstract virtual void GetImplTypeCustData(int index, System.Guid& guidout , System.Object& pVarVal) {}
	public abstract virtual void GetDocumentation2(int memidout , System.String& pbstrHelpStringout , System.Int32& pdwHelpStringContextout , System.String& pbstrHelpStringDll) {}
	public abstract virtual void GetAllCustData(System.IntPtr pCustData) {}
	public abstract virtual void GetAllFuncCustData(int index, System.IntPtr pCustData) {}
	public abstract virtual void GetAllParamCustData(int indexFunc, int indexParam, System.IntPtr pCustData) {}
	public abstract virtual void GetAllVarCustData(int index, System.IntPtr pCustData) {}
	public abstract virtual void GetAllImplTypeCustData(int index, System.IntPtr pCustData) {}
}

