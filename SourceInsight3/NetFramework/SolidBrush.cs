public class SolidBrush : Brush, System.ICloneable, System.IDisposable, System.Drawing.Internal.ISystemColorTracker
{

	// Constructors
	public SolidBrush(Color color) {}

	// Methods
	public virtual object Clone() {}
	public virtual void Dispose() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Color Color { get{} set{} }
}

