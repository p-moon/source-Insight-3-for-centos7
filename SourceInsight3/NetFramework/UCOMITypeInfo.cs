public interface UCOMITypeInfo
{

	// Methods
	public abstract virtual void GetTypeAttr(out System.IntPtr& ppTypeAttr) {}
	public abstract virtual void GetTypeComp(out UCOMITypeComp& ppTComp) {}
	public abstract virtual void GetFuncDesc(int indexout , System.IntPtr& ppFuncDesc) {}
	public abstract virtual void GetVarDesc(int indexout , System.IntPtr& ppVarDesc) {}
	public abstract virtual void GetNames(int memidout , string[] rgBstrNames, int cMaxNamesout , System.Int32& pcNames) {}
	public abstract virtual void GetRefTypeOfImplType(int indexout , System.Int32& href) {}
	public abstract virtual void GetImplTypeFlags(int indexout , System.Int32& pImplTypeFlags) {}
	public abstract virtual void GetIDsOfNames(string[] rgszNames, int cNamesout , int[] pMemId) {}
	public abstract virtual void Invoke(object pvInstance, int memid, short wFlags, DISPPARAMS& pDispParamsout , System.Object& pVarResultout , EXCEPINFO& pExcepInfoout , System.Int32& puArgErr) {}
	public abstract virtual void GetDocumentation(int indexout , System.String& strNameout , System.String& strDocStringout , System.Int32& dwHelpContextout , System.String& strHelpFile) {}
	public abstract virtual void GetDllEntry(int memid, INVOKEKIND invKindout , System.String& pBstrDllNameout , System.String& pBstrNameout , System.Int16& pwOrdinal) {}
	public abstract virtual void GetRefTypeInfo(int hRefout , UCOMITypeInfo& ppTI) {}
	public abstract virtual void AddressOfMember(int memid, INVOKEKIND invKindout , System.IntPtr& ppv) {}
	public abstract virtual void CreateInstance(object pUnkOuter, System.Guid& riidout , System.Object& ppvObj) {}
	public abstract virtual void GetMops(int memidout , System.String& pBstrMops) {}
	public abstract virtual void GetContainingTypeLib(out UCOMITypeLib& ppTLBout , System.Int32& pIndex) {}
	public abstract virtual void ReleaseTypeAttr(System.IntPtr pTypeAttr) {}
	public abstract virtual void ReleaseFuncDesc(System.IntPtr pFuncDesc) {}
	public abstract virtual void ReleaseVarDesc(System.IntPtr pVarDesc) {}
}

