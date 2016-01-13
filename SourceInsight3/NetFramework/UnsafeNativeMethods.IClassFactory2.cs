public interface IClassFactory2
{

	// Methods
	public abstract virtual void CreateInstance(object unused, System.Guid& refiidout , object[] ppunk) {}
	public abstract virtual void LockServer(int fLock) {}
	public abstract virtual void GetLicInfo(out tagLICINFO licInfo) {}
	public abstract virtual void RequestLicKey(int dwReservedout , string[] pBstrKey) {}
	public abstract virtual void CreateInstanceLic(object pUnkOuter, object pUnkReserved, System.Guid& riid, string bstrKeyout , System.Object& ppVal) {}
}

