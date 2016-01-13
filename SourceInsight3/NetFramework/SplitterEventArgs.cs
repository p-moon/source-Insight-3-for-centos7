public class SplitterEventArgs : System.EventArgs
{

	// Constructors
	public SplitterEventArgs(int x, int y, int splitX, int splitY) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int X { get{} }
	public int Y { get{} }
	public int SplitX { get{} set{} }
	public int SplitY { get{} set{} }
}

