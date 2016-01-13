public class TextReader : System.MarshalByRefObject, System.IDisposable
{

	// Methods
	public virtual void Close() {}
	public virtual void Dispose() {}
	public virtual int Peek() {}
	public virtual int Read() {}
	public virtual int Read(out char[] buffer, int index, int count) {}
	public virtual string ReadToEnd() {}
	public virtual int ReadBlock(out char[] buffer, int index, int count) {}
	public virtual string ReadLine() {}
	public static TextReader Synchronized(TextReader reader) {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public TextReader Null;
}

