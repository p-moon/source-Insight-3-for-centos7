public interface IHTMLWindow3
{

	// Methods
	public abstract virtual int GetScreenLeft() {}
	public abstract virtual int GetScreenTop() {}
	public abstract virtual bool AttachEvent(string ev, object pdisp) {}
	public abstract virtual void DetachEvent(string ev, object pdisp) {}
	public abstract virtual int SetTimeout(System.Object& expression, int msec, System.Object& language) {}
	public abstract virtual int SetInterval(System.Object& expression, int msec, System.Object& language) {}
	public abstract virtual void Print() {}
	public abstract virtual void SetBeforePrint(object o) {}
	public abstract virtual object GetBeforePrint() {}
	public abstract virtual void SetAfterPrint(object o) {}
	public abstract virtual object GetAfterPrint() {}
	public abstract virtual object GetClipboardData() {}
	public abstract virtual object ShowModelessDialog(string url, object varArgIn, object options) {}
}

