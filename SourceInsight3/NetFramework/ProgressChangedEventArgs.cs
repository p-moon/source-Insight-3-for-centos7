public class ProgressChangedEventArgs : System.EventArgs
{

	// Constructors
	public ProgressChangedEventArgs(int progressPercentage, object userState) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int ProgressPercentage { get{} }
	public object UserState { get{} }
}

