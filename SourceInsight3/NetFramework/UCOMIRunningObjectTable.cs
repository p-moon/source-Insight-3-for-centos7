public interface UCOMIRunningObjectTable
{

	// Methods
	public abstract virtual void Register(int grfFlags, object punkObject, UCOMIMoniker pmkObjectNameout , System.Int32& pdwRegister) {}
	public abstract virtual void Revoke(int dwRegister) {}
	public abstract virtual void IsRunning(UCOMIMoniker pmkObjectName) {}
	public abstract virtual void GetObject(UCOMIMoniker pmkObjectNameout , System.Object& ppunkObject) {}
	public abstract virtual void NoteChangeTime(int dwRegister, FILETIME& pfiletime) {}
	public abstract virtual void GetTimeOfLastChange(UCOMIMoniker pmkObjectNameout , FILETIME& pfiletime) {}
	public abstract virtual void EnumRunning(out UCOMIEnumMoniker& ppenumMoniker) {}
}

