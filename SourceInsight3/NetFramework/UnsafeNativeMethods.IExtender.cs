public interface IExtender
{

	// Methods
	public abstract virtual void Move(object left, object top, object width, object height) {}

	// Properties
	public int Align { get{} set{} }
	public bool Enabled { get{} set{} }
	public int Height { get{} set{} }
	public int Left { get{} set{} }
	public bool TabStop { get{} set{} }
	public int Top { get{} set{} }
	public bool Visible { get{} set{} }
	public int Width { get{} set{} }
	public string Name { get{} }
	public object Parent { get{} }
	public System.IntPtr Hwnd { get{} }
	public object Container { get{} }
}

