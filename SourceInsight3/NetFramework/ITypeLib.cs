public interface ITypeLib
{

	// Methods
	public abstract virtual int GetTypeInfoCount() {}
	public abstract virtual void GetTypeInfo(int indexout , ITypeInfo& ppTI) {}
	public abstract virtual void GetTypeInfoType(int indexout , TYPEKIND& pTKind) {}
	public abstract virtual void GetTypeInfoOfGuid(System.Guid& guidout , ITypeInfo& ppTInfo) {}
	public abstract virtual void GetLibAttr(out System.IntPtr& ppTLibAttr) {}
	public abstract virtual void GetTypeComp(out ITypeComp& ppTComp) {}
	public abstract virtual void GetDocumentation(int indexout , System.String& strNameout , System.String& strDocStringout , System.Int32& dwHelpContextout , System.String& strHelpFile) {}
	public abstract virtual bool IsName(string szNameBuf, int lHashVal) {}
	public abstract virtual void FindName(string szNameBuf, int lHashValout , ITypeInfo[] ppTInfoout , int[] rgMemId, System.Int16& pcFound) {}
	public abstract virtual void ReleaseTLibAttr(System.IntPtr pTLibAttr) {}
}

