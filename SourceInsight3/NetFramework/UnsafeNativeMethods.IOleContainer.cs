public interface IOleContainer
{

	// Methods
	public abstract virtual int ParseDisplayName(object pbc, string pszDisplayNameout , int[] pchEatenout , object[] ppmkOut) {}
	public abstract virtual int EnumObjects(int grfFlagsout , IEnumUnknown& ppenum) {}
	public abstract virtual int LockContainer(bool fLock) {}
}

