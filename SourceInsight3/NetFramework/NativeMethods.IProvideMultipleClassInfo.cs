public interface IProvideMultipleClassInfo
{

	// Methods
	public abstract virtual ITypeInfo GetClassInfo() {}
	public abstract virtual int GetGUID(int dwGuidKindout , System.Guid& pGuid) {}
	public abstract virtual int GetMultiTypeInfoCount(out System.Int32& pcti) {}
	public abstract virtual int GetInfoOfIndex(int iti, int dwFlagsout , ITypeInfo& pTypeInfo, int pTIFlags, int pcdispidReserved, System.IntPtr piidPrimary, System.IntPtr piidSource) {}
}

