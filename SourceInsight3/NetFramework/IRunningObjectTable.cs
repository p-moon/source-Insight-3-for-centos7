public interface IRunningObjectTable
{

	// Methods
	public abstract virtual int Register(int grfFlags, object punkObject, IMoniker pmkObjectName) {}
	public abstract virtual void Revoke(int dwRegister) {}
	public abstract virtual int IsRunning(IMoniker pmkObjectName) {}
	public abstract virtual int GetObject(IMoniker pmkObjectNameout , System.Object& ppunkObject) {}
	public abstract virtual void NoteChangeTime(int dwRegister, FILETIME& pfiletime) {}
	public abstract virtual int GetTimeOfLastChange(IMoniker pmkObjectNameout , FILETIME& pfiletime) {}
	public abstract virtual void EnumRunning(out IEnumMoniker& ppenumMoniker) {}
}

