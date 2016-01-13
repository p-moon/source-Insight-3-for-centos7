public interface IPersistStreamInit
{

	// Methods
	public abstract virtual void GetClassID(out System.Guid& pClassID) {}
	public abstract virtual int IsDirty() {}
	public abstract virtual void Load(IStream pstm) {}
	public abstract virtual void Save(IStream pstm, bool fClearDirty) {}
	public abstract virtual void GetSizeMax(out long pcbSize) {}
	public abstract virtual void InitNew() {}
}

