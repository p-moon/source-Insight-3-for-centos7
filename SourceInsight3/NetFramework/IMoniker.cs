public interface IMoniker
{

	// Methods
	public abstract virtual void GetClassID(out System.Guid& pClassID) {}
	public abstract virtual int IsDirty() {}
	public abstract virtual void Load(IStream pStm) {}
	public abstract virtual void Save(IStream pStm, bool fClearDirty) {}
	public abstract virtual void GetSizeMax(out System.Int64& pcbSize) {}
	public abstract virtual void BindToObject(IBindCtx pbc, IMoniker pmkToLeft, System.Guid& riidResultout , System.Object& ppvResult) {}
	public abstract virtual void BindToStorage(IBindCtx pbc, IMoniker pmkToLeft, System.Guid& riidout , System.Object& ppvObj) {}
	public abstract virtual void Reduce(IBindCtx pbc, int dwReduceHowFar, IMoniker& ppmkToLeftout , IMoniker& ppmkReduced) {}
	public abstract virtual void ComposeWith(IMoniker pmkRight, bool fOnlyIfNotGenericout , IMoniker& ppmkComposite) {}
	public abstract virtual void Enum(bool fForwardout , IEnumMoniker& ppenumMoniker) {}
	public abstract virtual int IsEqual(IMoniker pmkOtherMoniker) {}
	public abstract virtual void Hash(out System.Int32& pdwHash) {}
	public abstract virtual int IsRunning(IBindCtx pbc, IMoniker pmkToLeft, IMoniker pmkNewlyRunning) {}
	public abstract virtual void GetTimeOfLastChange(IBindCtx pbc, IMoniker pmkToLeftout , FILETIME& pFileTime) {}
	public abstract virtual void Inverse(out IMoniker& ppmk) {}
	public abstract virtual void CommonPrefixWith(IMoniker pmkOtherout , IMoniker& ppmkPrefix) {}
	public abstract virtual void RelativePathTo(IMoniker pmkOtherout , IMoniker& ppmkRelPath) {}
	public abstract virtual void GetDisplayName(IBindCtx pbc, IMoniker pmkToLeftout , System.String& ppszDisplayName) {}
	public abstract virtual void ParseDisplayName(IBindCtx pbc, IMoniker pmkToLeft, string pszDisplayNameout , System.Int32& pchEatenout , IMoniker& ppmkOut) {}
	public abstract virtual int IsSystemMoniker(out System.Int32& pdwMksys) {}
}

