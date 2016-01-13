public interface IPersistFile
{

	// Methods
	public abstract virtual void GetClassID(out System.Guid& pClassID) {}
	public abstract virtual int IsDirty() {}
	public abstract virtual void Load(string pszFileName, int dwMode) {}
	public abstract virtual void Save(string pszFileName, bool fRemember) {}
	public abstract virtual void SaveCompleted(string pszFileName) {}
	public abstract virtual void GetCurFile(out System.String& ppszFileName) {}
}

