public class CustomLineCap : System.MarshalByRefObject, System.ICloneable, System.IDisposable
{

	// Constructors
	public CustomLineCap(GraphicsPath fillPath, GraphicsPath strokePath) {}
	public CustomLineCap(GraphicsPath fillPath, GraphicsPath strokePath, LineCap baseCap) {}
	public CustomLineCap(GraphicsPath fillPath, GraphicsPath strokePath, LineCap baseCap, float baseInset) {}

	// Methods
	public virtual void Dispose() {}
	public virtual object Clone() {}
	public void SetStrokeCaps(LineCap startCap, LineCap endCap) {}
	public void GetStrokeCaps(out LineCap& startCapout , LineCap& endCap) {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public LineJoin StrokeJoin { get{} set{} }
	public LineCap BaseCap { get{} set{} }
	public float BaseInset { get{} set{} }
	public float WidthScale { get{} set{} }
}

