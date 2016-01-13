public class PathGradientBrush : System.Drawing.Brush, System.ICloneable, System.IDisposable
{

	// Constructors
	public PathGradientBrush(System.Drawing.PointF[] points) {}
	public PathGradientBrush(System.Drawing.PointF[] points, WrapMode wrapMode) {}
	public PathGradientBrush(System.Drawing.Point[] points) {}
	public PathGradientBrush(System.Drawing.Point[] points, WrapMode wrapMode) {}
	public PathGradientBrush(GraphicsPath path) {}

	// Methods
	public virtual object Clone() {}
	public void SetSigmaBellShape(float focus) {}
	public void SetSigmaBellShape(float focus, float scale) {}
	public void SetBlendTriangularShape(float focus) {}
	public void SetBlendTriangularShape(float focus, float scale) {}
	public void ResetTransform() {}
	public void MultiplyTransform(Matrix matrix) {}
	public void MultiplyTransform(Matrix matrix, MatrixOrder order) {}
	public void TranslateTransform(float dx, float dy) {}
	public void TranslateTransform(float dx, float dy, MatrixOrder order) {}
	public void ScaleTransform(float sx, float sy) {}
	public void ScaleTransform(float sx, float sy, MatrixOrder order) {}
	public void RotateTransform(float angle) {}
	public void RotateTransform(float angle, MatrixOrder order) {}
	public virtual void Dispose() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Drawing.Color CenterColor { get{} set{} }
	public System.Drawing.Color[] SurroundColors { get{} set{} }
	public System.Drawing.PointF CenterPoint { get{} set{} }
	public System.Drawing.RectangleF Rectangle { get{} }
	public Blend Blend { get{} set{} }
	public ColorBlend InterpolationColors { get{} set{} }
	public Matrix Transform { get{} set{} }
	public System.Drawing.PointF FocusScales { get{} set{} }
	public WrapMode WrapMode { get{} set{} }
}

