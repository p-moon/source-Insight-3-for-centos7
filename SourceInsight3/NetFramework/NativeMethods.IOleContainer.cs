public interface IOleContainer
{

	// Methods
	public abstract virtual void ParseDisplayName(object pbc, string pszDisplayNameout , int[] pchEatenout , object[] ppmkOut) {}
	public abstract virtual void EnumObjects(int grfFlagsout , System.Object& ppenum) {}
	public abstract virtual void LockContainer(int fLock) {}
}

