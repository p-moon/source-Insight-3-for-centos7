public class Pen : System.MarshalByRefObject, System.Drawing.Internal.ISystemColorTracker, System.ICloneable, System.IDisposable
{

	// Constructors
	public Pen(Color color) {}
	public Pen(Color color, float width) {}
	public Pen(Brush brush) {}
	public Pen(Brush brush, float width) {}

	// Methods
	public virtual object Clone() {}
	public virtual void Dispose() {}
	public void SetLineCap(System.Drawing.Drawing2D.LineCap startCap, System.Drawing.Drawing2D.LineCap endCap, System.Drawing.Drawing2D.DashCap dashCap) {}
	public void ResetTransform() {}
	public void MultiplyTransform(System.Drawing.Drawing2D.Matrix matrix) {}
	public void MultiplyTransform(System.Drawing.Drawing2D.Matrix matrix, System.Drawing.Drawing2D.MatrixOrder order) {}
	public void TranslateTransform(float dx, float dy) {}
	public void TranslateTransform(float dx, float dy, System.Drawing.Drawing2D.MatrixOrder order) {}
	public void ScaleTransform(float sx, float sy) {}
	public void ScaleTransform(float sx, float sy, System.Drawing.Drawing2D.MatrixOrder order) {}
	public void RotateTransform(float angle) {}
	public void RotateTransform(float angle, System.Drawing.Drawing2D.MatrixOrder order) {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public float Width { get{} set{} }
	public System.Drawing.Drawing2D.LineCap StartCap { get{} set{} }
	public System.Drawing.Drawing2D.LineCap EndCap { get{} set{} }
	public System.Drawing.Drawing2D.DashCap DashCap { get{} set{} }
	public System.Drawing.Drawing2D.LineJoin LineJoin { get{} set{} }
	public System.Drawing.Drawing2D.CustomLineCap CustomStartCap { get{} set{} }
	public System.Drawing.Drawing2D.CustomLineCap CustomEndCap { get{} set{} }
	public float MiterLimit { get{} set{} }
	public System.Drawing.Drawing2D.PenAlignment Alignment { get{} set{} }
	public System.Drawing.Drawing2D.Matrix Transform { get{} set{} }
	public System.Drawing.Drawing2D.PenType PenType { get{} }
	public Color Color { get{} set{} }
	public Brush Brush { get{} set{} }
	public System.Drawing.Drawing2D.DashStyle DashStyle { get{} set{} }
	public float DashOffset { get{} set{} }
	public float[] DashPattern { get{} set{} }
	public float[] CompoundArray { get{} set{} }
}

