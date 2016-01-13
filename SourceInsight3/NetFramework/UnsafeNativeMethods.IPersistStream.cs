public interface IPersistStream
{

	// Methods
	public abstract virtual void GetClassID(out System.Guid& pClassId) {}
	public abstract virtual int IsDirty() {}
	public abstract virtual void Load(IStream pstm) {}
	public abstract virtual void Save(IStream pstm, bool fClearDirty) {}
	public abstract virtual long GetSizeMax() {}
}

