public class BulletedListEventArgs : System.EventArgs
{

	// Constructors
	public BulletedListEventArgs(int index) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Index { get{} }
}

