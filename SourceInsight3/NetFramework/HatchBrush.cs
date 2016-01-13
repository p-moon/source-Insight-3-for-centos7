public class HatchBrush : System.Drawing.Brush, System.ICloneable, System.IDisposable
{

	// Constructors
	public HatchBrush(HatchStyle hatchstyle, System.Drawing.Color foreColor) {}
	public HatchBrush(HatchStyle hatchstyle, System.Drawing.Color foreColor, System.Drawing.Color backColor) {}

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
	public HatchStyle HatchStyle { get{} }
	public System.Drawing.Color ForegroundColor { get{} }
	public System.Drawing.Color BackgroundColor { get{} }
}

