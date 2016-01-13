public class UserPreferenceChangedEventArgs : System.EventArgs
{

	// Constructors
	public UserPreferenceChangedEventArgs(UserPreferenceCategory category) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public UserPreferenceCategory Category { get{} }
}

