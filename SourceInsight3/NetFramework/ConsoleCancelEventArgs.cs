public class ConsoleCancelEventArgs : EventArgs
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool Cancel { get{} set{} }
	public ConsoleSpecialKey SpecialKey { get{} }
}

