public interface IBindCtx
{

	// Methods
	public abstract virtual void RegisterObjectBound(object punk) {}
	public abstract virtual void RevokeObjectBound(object punk) {}
	public abstract virtual void ReleaseBoundObjects() {}
	public abstract virtual void SetBindOptions(BIND_OPTS& pbindopts) {}
	public abstract virtual void GetBindOptions(BIND_OPTS& pbindopts) {}
	public abstract virtual void GetRunningObjectTable(out IRunningObjectTable& pprot) {}
	public abstract virtual void RegisterObjectParam(string pszKey, object punk) {}
	public abstract virtual void GetObjectParam(string pszKeyout , System.Object& ppunk) {}
	public abstract virtual void EnumObjectParam(out IEnumString& ppenum) {}
	public abstract virtual int RevokeObjectParam(string pszKey) {}
}

