public class LabelEditEventArgs : System.EventArgs
{

	// Constructors
	public LabelEditEventArgs(int item) {}
	public LabelEditEventArgs(int item, string label) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Label { get{} }
	public int Item { get{} }
	public bool CancelEdit { get{} set{} }
}

