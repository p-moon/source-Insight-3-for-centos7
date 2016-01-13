public class DragEventArgs : System.EventArgs
{

	// Constructors
	public DragEventArgs(IDataObject data, int keyState, int x, int y, DragDropEffects allowedEffect, DragDropEffects effect) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public IDataObject Data { get{} }
	public int KeyState { get{} }
	public int X { get{} }
	public int Y { get{} }
	public DragDropEffects AllowedEffect { get{} }
	public DragDropEffects Effect { get{} set{} }
}

