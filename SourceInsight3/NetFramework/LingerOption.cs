public class LingerOption
{

	// Constructors
	public LingerOption(bool enable, int seconds) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool Enabled { get{} set{} }
	public int LingerTime { get{} set{} }
}

