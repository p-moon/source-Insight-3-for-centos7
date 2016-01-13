public class AdjustableArrowCap : CustomLineCap, System.ICloneable, System.IDisposable
{

	// Constructors
	public AdjustableArrowCap(float width, float height) {}
	public AdjustableArrowCap(float width, float height, bool isFilled) {}

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
	public float Height { get{} set{} }
	public float Width { get{} set{} }
	public float MiddleInset { get{} set{} }
	public bool Filled { get{} set{} }
	public LineJoin StrokeJoin { get{} set{} }
	public LineCap BaseCap { get{} set{} }
	public float BaseInset { get{} set{} }
	public float WidthScale { get{} set{} }
}

