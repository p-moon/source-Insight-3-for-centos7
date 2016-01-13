public class TextureBrush : Brush, System.ICloneable, System.IDisposable
{

	// Constructors
	public TextureBrush(Image bitmap) {}
	public TextureBrush(Image image, System.Drawing.Drawing2D.WrapMode wrapMode) {}
	public TextureBrush(Image image, System.Drawing.Drawing2D.WrapMode wrapMode, RectangleF dstRect) {}
	public TextureBrush(Image image, System.Drawing.Drawing2D.WrapMode wrapMode, Rectangle dstRect) {}
	public TextureBrush(Image image, RectangleF dstRect) {}
	public TextureBrush(Image image, RectangleF dstRect, System.Drawing.Imaging.ImageAttributes imageAttr) {}
	public TextureBrush(Image image, Rectangle dstRect) {}
	public TextureBrush(Image image, Rectangle dstRect, System.Drawing.Imaging.ImageAttributes imageAttr) {}

	// Methods
	public virtual object Clone() {}
	public void ResetTransform() {}
	public void MultiplyTransform(System.Drawing.Drawing2D.Matrix matrix) {}
	public void MultiplyTransform(System.Drawing.Drawing2D.Matrix matrix, System.Drawing.Drawing2D.MatrixOrder order) {}
	public void TranslateTransform(float dx, float dy) {}
	public void TranslateTransform(float dx, float dy, System.Drawing.Drawing2D.MatrixOrder order) {}
	public void ScaleTransform(float sx, float sy) {}
	public void ScaleTransform(float sx, float sy, System.Drawing.Drawing2D.MatrixOrder order) {}
	public void RotateTransform(float angle) {}
	public void RotateTransform(float angle, System.Drawing.Drawing2D.MatrixOrder order) {}
	public virtual void Dispose() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Drawing.Drawing2D.Matrix Transform { get{} set{} }
	public System.Drawing.Drawing2D.WrapMode WrapMode { get{} set{} }
	public Image Image { get{} }
}

