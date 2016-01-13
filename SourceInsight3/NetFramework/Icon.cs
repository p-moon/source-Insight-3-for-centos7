public class Icon : System.MarshalByRefObject, System.Runtime.Serialization.ISerializable, System.ICloneable, System.IDisposable
{

	// Constructors
	public Icon(Icon original, Size size) {}
	public Icon(Type type, string resource) {}
	public Icon(string fileName) {}
	public Icon(string fileName, Size size) {}
	public Icon(string fileName, int width, int height) {}
	public Icon(Icon original, int width, int height) {}
	public Icon(System.IO.Stream stream) {}
	public Icon(System.IO.Stream stream, Size size) {}
	public Icon(System.IO.Stream stream, int width, int height) {}

	// Methods
	public static Icon ExtractAssociatedIcon(string filePath) {}
	public virtual object Clone() {}
	public virtual void Dispose() {}
	public static Icon FromHandle(System.IntPtr handle) {}
	public void Save(System.IO.Stream outputStream) {}
	public Bitmap ToBitmap() {}
	public virtual string ToString() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.IntPtr Handle { get{} }
	public int Height { get{} }
	public Size Size { get{} }
	public int Width { get{} }
}

