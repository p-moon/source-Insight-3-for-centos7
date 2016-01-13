public class GraphicsPathIterator : System.MarshalByRefObject, System.IDisposable
{

	// Constructors
	public GraphicsPathIterator(GraphicsPath path) {}

	// Methods
	public virtual void Dispose() {}
	public int NextSubpath(out System.Int32& startIndexout , System.Int32& endIndexout , System.Boolean& isClosed) {}
	public int NextSubpath(GraphicsPath pathout , System.Boolean& isClosed) {}
	public int NextPathType(out System.Byte& pathTypeout , System.Int32& startIndexout , System.Int32& endIndex) {}
	public int NextMarker(out System.Int32& startIndexout , System.Int32& endIndex) {}
	public int NextMarker(GraphicsPath path) {}
	public bool HasCurve() {}
	public void Rewind() {}
	public int Enumerate(System.Drawing.PointF[]& points, System.Byte[]& types) {}
	public int CopyData(System.Drawing.PointF[]& points, System.Byte[]& types, int startIndex, int endIndex) {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public int SubpathCount { get{} }
}

