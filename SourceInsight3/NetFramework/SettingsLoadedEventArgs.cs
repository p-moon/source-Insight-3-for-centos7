public class SettingsLoadedEventArgs : System.EventArgs
{

	// Constructors
	public SettingsLoadedEventArgs(SettingsProvider provider) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public SettingsProvider Provider { get{} }
}

