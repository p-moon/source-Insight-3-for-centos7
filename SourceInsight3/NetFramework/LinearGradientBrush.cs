public class LinearGradientBrush : System.Drawing.Brush, System.ICloneable, System.IDisposable
{

	// Constructors
	public LinearGradientBrush(System.Drawing.Rectangle rect, System.Drawing.Color color1, System.Drawing.Color color2, LinearGradientMode linearGradientMode) {}
	public LinearGradientBrush(System.Drawing.PointF point1, System.Drawing.PointF point2, System.Drawing.Color color1, System.Drawing.Color color2) {}
	public LinearGradientBrush(System.Drawing.Point point1, System.Drawing.Point point2, System.Drawing.Color color1, System.Drawing.Color color2) {}
	public LinearGradientBrush(System.Drawing.RectangleF rect, System.Drawing.Color color1, System.Drawing.Color color2, LinearGradientMode linearGradientMode) {}
	public LinearGradientBrush(System.Drawing.RectangleF rect, System.Drawing.Color color1, System.Drawing.Color color2, float angle) {}
	public LinearGradientBrush(System.Drawing.RectangleF rect, System.Drawing.Color color1, System.Drawing.Color color2, float angle, bool isAngleScaleable) {}
	public LinearGradientBrush(System.Drawing.Rectangle rect, System.Drawing.Color color1, System.Drawing.Color color2, float angle) {}
	public LinearGradientBrush(System.Drawing.Rectangle rect, System.Drawing.Color color1, System.Drawing.Color color2, float angle, bool isAngleScaleable) {}

	// Methods
	public void TranslateTransform(float dx, float dy) {}
	public virtual object Clone() {}
	public void SetSigmaBellShape(float focus) {}
	public void SetSigmaBellShape(float focus, float scale) {}
	public void SetBlendTriangularShape(float focus) {}
	public void SetBlendTriangularShape(float focus, float scale) {}
	public void ResetTransform() {}
	public void MultiplyTransform(Matrix matrix) {}
	public void MultiplyTransform(Matrix matrix, MatrixOrder order) {}
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
	public System.Drawing.Color[] LinearColors { get{} set{} }
	public System.Drawing.RectangleF Rectangle { get{} }
	public bool GammaCorrection { get{} set{} }
	public Blend Blend { get{} set{} }
	public ColorBlend InterpolationColors { get{} set{} }
	public WrapMode WrapMode { get{} set{} }
	public Matrix Transform { get{} set{} }
}

