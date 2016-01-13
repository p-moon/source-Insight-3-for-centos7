public class SelectedGridItemChangedEventArgs : System.EventArgs
{

	// Constructors
	public SelectedGridItemChangedEventArgs(GridItem oldSel, GridItem newSel) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public GridItem NewSelection { get{} }
	public GridItem OldSelection { get{} }
}

