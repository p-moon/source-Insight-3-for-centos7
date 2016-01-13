public class MouseEventArgs : System.EventArgs
{

	// Constructors
	public MouseEventArgs(MouseButtons button, int clicks, int x, int y, int delta) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public MouseButtons Button { get{} }
	public int Clicks { get{} }
	public int X { get{} }
	public int Y { get{} }
	public int Delta { get{} }
	public System.Drawing.Point Location { get{} }
}

