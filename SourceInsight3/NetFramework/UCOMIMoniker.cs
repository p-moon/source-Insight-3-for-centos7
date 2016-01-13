public interface UCOMIMoniker
{

	// Methods
	public abstract virtual void GetClassID(out System.Guid& pClassID) {}
	public abstract virtual int IsDirty() {}
	public abstract virtual void Load(UCOMIStream pStm) {}
	public abstract virtual void Save(UCOMIStream pStm, bool fClearDirty) {}
	public abstract virtual void GetSizeMax(out System.Int64& pcbSize) {}
	public abstract virtual void BindToObject(UCOMIBindCtx pbc, UCOMIMoniker pmkToLeft, System.Guid& riidResultout , System.Object& ppvResult) {}
	public abstract virtual void BindToStorage(UCOMIBindCtx pbc, UCOMIMoniker pmkToLeft, System.Guid& riidout , System.Object& ppvObj) {}
	public abstract virtual void Reduce(UCOMIBindCtx pbc, int dwReduceHowFar, UCOMIMoniker& ppmkToLeftout , UCOMIMoniker& ppmkReduced) {}
	public abstract virtual void ComposeWith(UCOMIMoniker pmkRight, bool fOnlyIfNotGenericout , UCOMIMoniker& ppmkComposite) {}
	public abstract virtual void Enum(bool fForwardout , UCOMIEnumMoniker& ppenumMoniker) {}
	public abstract virtual void IsEqual(UCOMIMoniker pmkOtherMoniker) {}
	public abstract virtual void Hash(out System.Int32& pdwHash) {}
	public abstract virtual void IsRunning(UCOMIBindCtx pbc, UCOMIMoniker pmkToLeft, UCOMIMoniker pmkNewlyRunning) {}
	public abstract virtual void GetTimeOfLastChange(UCOMIBindCtx pbc, UCOMIMoniker pmkToLeftout , FILETIME& pFileTime) {}
	public abstract virtual void Inverse(out UCOMIMoniker& ppmk) {}
	public abstract virtual void CommonPrefixWith(UCOMIMoniker pmkOtherout , UCOMIMoniker& ppmkPrefix) {}
	public abstract virtual void RelativePathTo(UCOMIMoniker pmkOtherout , UCOMIMoniker& ppmkRelPath) {}
	public abstract virtual void GetDisplayName(UCOMIBindCtx pbc, UCOMIMoniker pmkToLeftout , System.String& ppszDisplayName) {}
	public abstract virtual void ParseDisplayName(UCOMIBindCtx pbc, UCOMIMoniker pmkToLeft, string pszDisplayNameout , System.Int32& pchEatenout , UCOMIMoniker& ppmkOut) {}
	public abstract virtual void IsSystemMoniker(out System.Int32& pdwMksys) {}
}

