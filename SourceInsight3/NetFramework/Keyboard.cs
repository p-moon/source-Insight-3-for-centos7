public class Keyboard
{

	// Constructors
	public Keyboard() {}

	// Methods
	public void SendKeys(string keys) {}
	public void SendKeys(string keys, bool wait) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool ShiftKeyDown { get{} }
	public bool AltKeyDown { get{} }
	public bool CtrlKeyDown { get{} }
	public bool CapsLock { get{} }
	public bool NumLock { get{} }
	public bool ScrollLock { get{} }
}

