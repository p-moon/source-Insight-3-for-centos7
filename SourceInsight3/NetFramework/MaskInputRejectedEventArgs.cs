public class MaskInputRejectedEventArgs : System.EventArgs
{

	// Constructors
	public MaskInputRejectedEventArgs(int position, System.ComponentModel.MaskedTextResultHint rejectionHint) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Position { get{} }
	public System.ComponentModel.MaskedTextResultHint RejectionHint { get{} }
}

