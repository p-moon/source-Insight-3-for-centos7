public class SplitterCancelEventArgs : System.ComponentModel.CancelEventArgs
{

	// Constructors
	public SplitterCancelEventArgs(int mouseCursorX, int mouseCursorY, int splitX, int splitY) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int MouseCursorX { get{} }
	public int MouseCursorY { get{} }
	public int SplitX { get{} set{} }
	public int SplitY { get{} set{} }
	public bool Cancel { get{} set{} }
}

