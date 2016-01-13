public interface IPersistStorage
{

	// Methods
	public abstract virtual void GetClassID(out System.Guid& pClassID) {}
	public abstract virtual int IsDirty() {}
	public abstract virtual void InitNew(IStorage pstg) {}
	public abstract virtual int Load(IStorage pstg) {}
	public abstract virtual void Save(IStorage pStgSave, bool fSameAsLoad) {}
	public abstract virtual void SaveCompleted(IStorage pStgNew) {}
	public abstract virtual void HandsOffStorage() {}
}

