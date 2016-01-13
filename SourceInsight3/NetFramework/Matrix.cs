public class Matrix : System.MarshalByRefObject, System.IDisposable
{

	// Constructors
	public Matrix() {}
	public Matrix(float m11, float m12, float m21, float m22, float dx, float dy) {}
	public Matrix(System.Drawing.RectangleF rect, System.Drawing.PointF[] plgpts) {}
	public Matrix(System.Drawing.Rectangle rect, System.Drawing.Point[] plgpts) {}

	// Methods
	public virtual void Dispose() {}
	public Matrix Clone() {}
	public void Reset() {}
	public void Multiply(Matrix matrix) {}
	public void Multiply(Matrix matrix, MatrixOrder order) {}
	public void Translate(float offsetX, float offsetY) {}
	public void Translate(float offsetX, float offsetY, MatrixOrder order) {}
	public void Scale(float scaleX, float scaleY) {}
	public void Scale(float scaleX, float scaleY, MatrixOrder order) {}
	public void Rotate(float angle) {}
	public void Rotate(float angle, MatrixOrder order) {}
	public void RotateAt(float angle, System.Drawing.PointF point) {}
	public void RotateAt(float angle, System.Drawing.PointF point, MatrixOrder order) {}
	public void Shear(float shearX, float shearY) {}
	public void Shear(float shearX, float shearY, MatrixOrder order) {}
	public void Invert() {}
	public void TransformPoints(System.Drawing.PointF[] pts) {}
	public void TransformPoints(System.Drawing.Point[] pts) {}
	public void TransformVectors(System.Drawing.PointF[] pts) {}
	public void VectorTransformPoints(System.Drawing.Point[] pts) {}
	public void TransformVectors(System.Drawing.Point[] pts) {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public float[] Elements { get{} }
	public float OffsetX { get{} }
	public float OffsetY { get{} }
	public bool IsInvertible { get{} }
	public bool IsIdentity { get{} }
}

