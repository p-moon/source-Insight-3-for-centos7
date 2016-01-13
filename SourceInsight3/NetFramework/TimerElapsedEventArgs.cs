public class TimerElapsedEventArgs : System.EventArgs
{

	// Constructors
	public TimerElapsedEventArgs(System.IntPtr timerId) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.IntPtr TimerId { get{} }
}

