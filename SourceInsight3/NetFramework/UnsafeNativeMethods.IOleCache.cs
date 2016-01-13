public interface IOleCache
{

	// Methods
	public abstract virtual int Cache(System.Runtime.InteropServices.ComTypes.FORMATETC& pformatetc, int advf) {}
	public abstract virtual void Uncache(int dwConnection) {}
	public abstract virtual object EnumCache() {}
	public abstract virtual void InitCache(System.Runtime.InteropServices.ComTypes.IDataObject pDataObject) {}
	public abstract virtual void SetData(System.Runtime.InteropServices.ComTypes.FORMATETC& pformatetc, System.Runtime.InteropServices.ComTypes.STGMEDIUM& pmedium, bool fRelease) {}
}

