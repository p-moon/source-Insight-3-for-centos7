public class TabControlEventArgs : System.EventArgs
{

	// Constructors
	public TabControlEventArgs(TabPage tabPage, int tabPageIndex, TabControlAction action) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public TabPage TabPage { get{} }
	public int TabPageIndex { get{} }
	public TabControlAction Action { get{} }
}

