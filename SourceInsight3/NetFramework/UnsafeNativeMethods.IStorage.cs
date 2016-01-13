public interface IStorage
{

	// Methods
	public abstract virtual IStream CreateStream(string pwcsName, int grfMode, int reserved1, int reserved2) {}
	public abstract virtual IStream OpenStream(string pwcsName, System.IntPtr reserved1, int grfMode, int reserved2) {}
	public abstract virtual IStorage CreateStorage(string pwcsName, int grfMode, int reserved1, int reserved2) {}
	public abstract virtual IStorage OpenStorage(string pwcsName, System.IntPtr pstgPriority, int grfMode, System.IntPtr snbExclude, int reserved) {}
	public abstract virtual void CopyTo(int ciidExclude, System.Guid[] pIIDExclude, System.IntPtr snbExclude, IStorage stgDest) {}
	public abstract virtual void MoveElementTo(string pwcsName, IStorage stgDest, string pwcsNewName, int grfFlags) {}
	public abstract virtual void Commit(int grfCommitFlags) {}
	public abstract virtual void Revert() {}
	public abstract virtual void EnumElements(int reserved1, System.IntPtr reserved2, int reserved3out , System.Object& ppVal) {}
	public abstract virtual void DestroyElement(string pwcsName) {}
	public abstract virtual void RenameElement(string pwcsOldName, string pwcsNewName) {}
	public abstract virtual void SetElementTimes(string pwcsName, FILETIME pctime, FILETIME patime, FILETIME pmtime) {}
	public abstract virtual void SetClass(System.Guid& clsid) {}
	public abstract virtual void SetStateBits(int grfStateBits, int grfMask) {}
	public abstract virtual void Stat(out STATSTG pStatStg, int grfStatFlag) {}
}

