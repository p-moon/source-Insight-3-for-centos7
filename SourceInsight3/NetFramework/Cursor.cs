public class Cursor : System.IDisposable, System.Runtime.Serialization.ISerializable
{

	// Constructors
	public Cursor(System.IntPtr handle) {}
	public Cursor(string fileName) {}
	public Cursor(Type type, string resource) {}
	public Cursor(System.IO.Stream stream) {}

	// Methods
	public System.IntPtr CopyHandle() {}
	public virtual void Dispose() {}
	public void Draw(System.Drawing.Graphics g, System.Drawing.Rectangle targetRect) {}
	public void DrawStretched(System.Drawing.Graphics g, System.Drawing.Rectangle targetRect) {}
	public static void Hide() {}
	public static void Show() {}
	public virtual string ToString() {}
	public static bool op_Equality(Cursor left, Cursor right) {}
	public static bool op_Inequality(Cursor left, Cursor right) {}
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public Type GetType() {}

	// Properties
	public System.Drawing.Rectangle Clip { get{} set{} }
	public Cursor Current { get{} set{} }
	public System.IntPtr Handle { get{} }
	public System.Drawing.Point HotSpot { get{} }
	public System.Drawing.Point Position { get{} set{} }
	public System.Drawing.Size Size { get{} }
	public object Tag { get{} set{} }
}

