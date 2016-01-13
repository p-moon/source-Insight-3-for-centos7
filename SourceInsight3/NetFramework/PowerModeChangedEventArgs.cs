public class PowerModeChangedEventArgs : System.EventArgs
{

	// Constructors
	public PowerModeChangedEventArgs(PowerModes mode) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public PowerModes Mode { get{} }
}

