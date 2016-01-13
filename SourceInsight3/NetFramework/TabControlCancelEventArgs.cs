public class TabControlCancelEventArgs : System.ComponentModel.CancelEventArgs
{

	// Constructors
	public TabControlCancelEventArgs(TabPage tabPage, int tabPageIndex, bool cancel, TabControlAction action) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public TabPage TabPage { get{} }
	public int TabPageIndex { get{} }
	public TabControlAction Action { get{} }
	public bool Cancel { get{} set{} }
}

