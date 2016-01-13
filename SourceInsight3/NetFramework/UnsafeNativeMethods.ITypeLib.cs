public interface ITypeLib
{

	// Methods
	public abstract virtual void RemoteGetTypeInfoCount(out int[] pcTInfo) {}
	public abstract virtual void GetTypeInfo(int indexout , ITypeInfo[] ppTInfo) {}
	public abstract virtual void GetTypeInfoType(int indexout , System.Runtime.InteropServices.ComTypes.TYPEKIND[] pTKind) {}
	public abstract virtual void GetTypeInfoOfGuid(System.Guid& guidout , ITypeInfo[] ppTInfo) {}
	public abstract virtual void RemoteGetLibAttr(out tagTLIBATTR[] ppTLibAttrout , int[] pDummy) {}
	public abstract virtual void GetTypeComp(out ITypeComp[] ppTComp) {}
	public abstract virtual void RemoteGetDocumentation(int index, int refPtrFlagsout , string[] pBstrNameout , string[] pBstrDocStringout , int[] pdwHelpContextout , string[] pBstrHelpFile) {}
	public abstract virtual void RemoteIsName(string szNameBuf, int lHashValout , System.IntPtr[] pfNameout , string[] pBstrLibName) {}
	public abstract virtual void RemoteFindName(string szNameBuf, int lHashValout , ITypeInfo[] ppTInfoout , int[] rgMemIdout , short[] pcFoundout , string[] pBstrLibName) {}
	public abstract virtual void LocalReleaseTLibAttr() {}
}

