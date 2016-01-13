public class ItemCheckEventArgs : System.EventArgs
{

	// Constructors
	public ItemCheckEventArgs(int index, CheckState newCheckValue, CheckState currentValue) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Index { get{} }
	public CheckState NewValue { get{} set{} }
	public CheckState CurrentValue { get{} }
}

