public class Graphics : System.MarshalByRefObject, IDeviceContext, System.IDisposable
{

	// Methods
	public void AddMetafileComment(byte[] data) {}
	public static System.IntPtr GetHalftonePalette() {}
	public void ReleaseHdcInternal(System.IntPtr hdc) {}
	public void TranslateTransform(float dx, float dy) {}
	public Color GetNearestColor(Color color) {}
	public void DrawLine(Pen pen, int x1, int y1, int x2, int y2) {}
	public void DrawRectangle(Pen pen, int x, int y, int width, int height) {}
	public void Clear(Color color) {}
	public void FillRectangle(Brush brush, Rectangle rect) {}
	public void FillRectangle(Brush brush, int x, int y, int width, int height) {}
	public void FillRectangles(Brush brush, Rectangle[] rects) {}
	public void DrawString(string s, Font font, Brush brush, RectangleF layoutRectangle, StringFormat format) {}
	public SizeF MeasureString(string text, Font font, SizeF layoutArea, StringFormat stringFormat) {}
	public SizeF MeasureString(string text, Font font) {}
	public SizeF MeasureString(string text, Font font, int width, StringFormat format) {}
	public void DrawImage(Image image, int x, int y) {}
	public void DrawImage(Image image, Rectangle rect) {}
	public void DrawImage(Image image, Rectangle destRect, int srcX, int srcY, int srcWidth, int srcHeight, GraphicsUnit srcUnit, System.Drawing.Imaging.ImageAttributes imageAttrs, DrawImageAbort callback, System.IntPtr callbackData) {}
	public void SetClip(Rectangle rect) {}
	public void SetClip(Region region, System.Drawing.Drawing2D.CombineMode combineMode) {}
	public void ExcludeClip(Region region) {}
	public void TranslateClip(int dx, int dy) {}
	public object GetContextInfo() {}
	public System.Drawing.Drawing2D.GraphicsState Save() {}
	public void Restore(System.Drawing.Drawing2D.GraphicsState gstate) {}
	public static Graphics FromHdc(System.IntPtr hdc) {}
	public static Graphics FromHdcInternal(System.IntPtr hdc) {}
	public static Graphics FromHdc(System.IntPtr hdc, System.IntPtr hdevice) {}
	public static Graphics FromHwnd(System.IntPtr hwnd) {}
	public static Graphics FromHwndInternal(System.IntPtr hwnd) {}
	public static Graphics FromImage(Image image) {}
	public virtual System.IntPtr GetHdc() {}
	public void ReleaseHdc(System.IntPtr hdc) {}
	public virtual void ReleaseHdc() {}
	public virtual void Dispose() {}
	public void Flush() {}
	public void Flush(System.Drawing.Drawing2D.FlushIntention intention) {}
	public void CopyFromScreen(Point upperLeftSource, Point upperLeftDestination, Size blockRegionSize) {}
	public void CopyFromScreen(int sourceX, int sourceY, int destinationX, int destinationY, Size blockRegionSize) {}
	public void CopyFromScreen(Point upperLeftSource, Point upperLeftDestination, Size blockRegionSize, CopyPixelOperation copyPixelOperation) {}
	public void CopyFromScreen(int sourceX, int sourceY, int destinationX, int destinationY, Size blockRegionSize, CopyPixelOperation copyPixelOperation) {}
	public void ResetTransform() {}
	public void MultiplyTransform(System.Drawing.Drawing2D.Matrix matrix) {}
	public void MultiplyTransform(System.Drawing.Drawing2D.Matrix matrix, System.Drawing.Drawing2D.MatrixOrder order) {}
	public void TranslateTransform(float dx, float dy, System.Drawing.Drawing2D.MatrixOrder order) {}
	public void ScaleTransform(float sx, float sy) {}
	public void ScaleTransform(float sx, float sy, System.Drawing.Drawing2D.MatrixOrder order) {}
	public void RotateTransform(float angle) {}
	public void RotateTransform(float angle, System.Drawing.Drawing2D.MatrixOrder order) {}
	public void TransformPoints(System.Drawing.Drawing2D.CoordinateSpace destSpace, System.Drawing.Drawing2D.CoordinateSpace srcSpace, PointF[] pts) {}
	public void TransformPoints(System.Drawing.Drawing2D.CoordinateSpace destSpace, System.Drawing.Drawing2D.CoordinateSpace srcSpace, Point[] pts) {}
	public void DrawLine(Pen pen, float x1, float y1, float x2, float y2) {}
	public void DrawLine(Pen pen, PointF pt1, PointF pt2) {}
	public void DrawLines(Pen pen, PointF[] points) {}
	public void DrawLine(Pen pen, Point pt1, Point pt2) {}
	public void DrawLines(Pen pen, Point[] points) {}
	public void DrawArc(Pen pen, float x, float y, float width, float height, float startAngle, float sweepAngle) {}
	public void DrawArc(Pen pen, RectangleF rect, float startAngle, float sweepAngle) {}
	public void DrawArc(Pen pen, int x, int y, int width, int height, int startAngle, int sweepAngle) {}
	public void DrawArc(Pen pen, Rectangle rect, float startAngle, float sweepAngle) {}
	public void DrawBezier(Pen pen, float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4) {}
	public void DrawBezier(Pen pen, PointF pt1, PointF pt2, PointF pt3, PointF pt4) {}
	public void DrawBeziers(Pen pen, PointF[] points) {}
	public void DrawBezier(Pen pen, Point pt1, Point pt2, Point pt3, Point pt4) {}
	public void DrawBeziers(Pen pen, Point[] points) {}
	public void DrawRectangle(Pen pen, Rectangle rect) {}
	public void DrawRectangle(Pen pen, float x, float y, float width, float height) {}
	public void DrawRectangles(Pen pen, RectangleF[] rects) {}
	public void DrawRectangles(Pen pen, Rectangle[] rects) {}
	public void DrawEllipse(Pen pen, RectangleF rect) {}
	public void DrawEllipse(Pen pen, float x, float y, float width, float height) {}
	public void DrawEllipse(Pen pen, Rectangle rect) {}
	public void DrawEllipse(Pen pen, int x, int y, int width, int height) {}
	public void DrawPie(Pen pen, RectangleF rect, float startAngle, float sweepAngle) {}
	public void DrawPie(Pen pen, float x, float y, float width, float height, float startAngle, float sweepAngle) {}
	public void DrawPie(Pen pen, Rectangle rect, float startAngle, float sweepAngle) {}
	public void DrawPie(Pen pen, int x, int y, int width, int height, int startAngle, int sweepAngle) {}
	public void DrawPolygon(Pen pen, PointF[] points) {}
	public void DrawPolygon(Pen pen, Point[] points) {}
	public void DrawPath(Pen pen, System.Drawing.Drawing2D.GraphicsPath path) {}
	public void DrawCurve(Pen pen, PointF[] points) {}
	public void DrawCurve(Pen pen, PointF[] points, float tension) {}
	public void DrawCurve(Pen pen, PointF[] points, int offset, int numberOfSegments) {}
	public void DrawCurve(Pen pen, PointF[] points, int offset, int numberOfSegments, float tension) {}
	public void DrawCurve(Pen pen, Point[] points) {}
	public void DrawCurve(Pen pen, Point[] points, float tension) {}
	public void DrawCurve(Pen pen, Point[] points, int offset, int numberOfSegments, float tension) {}
	public void DrawClosedCurve(Pen pen, PointF[] points) {}
	public void DrawClosedCurve(Pen pen, PointF[] points, float tension, System.Drawing.Drawing2D.FillMode fillmode) {}
	public void DrawClosedCurve(Pen pen, Point[] points) {}
	public void DrawClosedCurve(Pen pen, Point[] points, float tension, System.Drawing.Drawing2D.FillMode fillmode) {}
	public void FillRectangle(Brush brush, RectangleF rect) {}
	public void FillRectangle(Brush brush, float x, float y, float width, float height) {}
	public void FillRectangles(Brush brush, RectangleF[] rects) {}
	public void FillPolygon(Brush brush, PointF[] points) {}
	public void FillPolygon(Brush brush, PointF[] points, System.Drawing.Drawing2D.FillMode fillMode) {}
	public void FillPolygon(Brush brush, Point[] points) {}
	public void FillPolygon(Brush brush, Point[] points, System.Drawing.Drawing2D.FillMode fillMode) {}
	public void FillEllipse(Brush brush, RectangleF rect) {}
	public void FillEllipse(Brush brush, float x, float y, float width, float height) {}
	public void FillEllipse(Brush brush, Rectangle rect) {}
	public void FillEllipse(Brush brush, int x, int y, int width, int height) {}
	public void FillPie(Brush brush, Rectangle rect, float startAngle, float sweepAngle) {}
	public void FillPie(Brush brush, float x, float y, float width, float height, float startAngle, float sweepAngle) {}
	public void FillPie(Brush brush, int x, int y, int width, int height, int startAngle, int sweepAngle) {}
	public void FillPath(Brush brush, System.Drawing.Drawing2D.GraphicsPath path) {}
	public void FillClosedCurve(Brush brush, PointF[] points) {}
	public void FillClosedCurve(Brush brush, PointF[] points, System.Drawing.Drawing2D.FillMode fillmode) {}
	public void FillClosedCurve(Brush brush, PointF[] points, System.Drawing.Drawing2D.FillMode fillmode, float tension) {}
	public void FillClosedCurve(Brush brush, Point[] points) {}
	public void FillClosedCurve(Brush brush, Point[] points, System.Drawing.Drawing2D.FillMode fillmode) {}
	public void FillClosedCurve(Brush brush, Point[] points, System.Drawing.Drawing2D.FillMode fillmode, float tension) {}
	public void FillRegion(Brush brush, Region region) {}
	public void DrawString(string s, Font font, Brush brush, float x, float y) {}
	public void DrawString(string s, Font font, Brush brush, PointF point) {}
	public void DrawString(string s, Font font, Brush brush, float x, float y, StringFormat format) {}
	public void DrawString(string s, Font font, Brush brush, PointF point, StringFormat format) {}
	public void DrawString(string s, Font font, Brush brush, RectangleF layoutRectangle) {}
	public SizeF MeasureString(string text, Font font, SizeF layoutArea, StringFormat stringFormatout , System.Int32& charactersFittedout , System.Int32& linesFilled) {}
	public SizeF MeasureString(string text, Font font, PointF origin, StringFormat stringFormat) {}
	public SizeF MeasureString(string text, Font font, SizeF layoutArea) {}
	public SizeF MeasureString(string text, Font font, int width) {}
	public Region[] MeasureCharacterRanges(string text, Font font, RectangleF layoutRect, StringFormat stringFormat) {}
	public void DrawIcon(Icon icon, int x, int y) {}
	public void DrawIcon(Icon icon, Rectangle targetRect) {}
	public void DrawIconUnstretched(Icon icon, Rectangle targetRect) {}
	public void DrawImage(Image image, PointF point) {}
	public void DrawImage(Image image, float x, float y) {}
	public void DrawImage(Image image, RectangleF rect) {}
	public void DrawImage(Image image, float x, float y, float width, float height) {}
	public void DrawImage(Image image, Point point) {}
	public void DrawImage(Image image, int x, int y, int width, int height) {}
	public void DrawImageUnscaled(Image image, Point point) {}
	public void DrawImageUnscaled(Image image, int x, int y) {}
	public void DrawImageUnscaled(Image image, Rectangle rect) {}
	public void DrawImageUnscaled(Image image, int x, int y, int width, int height) {}
	public void DrawImageUnscaledAndClipped(Image image, Rectangle rect) {}
	public void DrawImage(Image image, PointF[] destPoints) {}
	public void DrawImage(Image image, Point[] destPoints) {}
	public void DrawImage(Image image, float x, float y, RectangleF srcRect, GraphicsUnit srcUnit) {}
	public void DrawImage(Image image, int x, int y, Rectangle srcRect, GraphicsUnit srcUnit) {}
	public void DrawImage(Image image, RectangleF destRect, RectangleF srcRect, GraphicsUnit srcUnit) {}
	public void DrawImage(Image image, Rectangle destRect, Rectangle srcRect, GraphicsUnit srcUnit) {}
	public void DrawImage(Image image, PointF[] destPoints, RectangleF srcRect, GraphicsUnit srcUnit) {}
	public void DrawImage(Image image, PointF[] destPoints, RectangleF srcRect, GraphicsUnit srcUnit, System.Drawing.Imaging.ImageAttributes imageAttr) {}
	public void DrawImage(Image image, PointF[] destPoints, RectangleF srcRect, GraphicsUnit srcUnit, System.Drawing.Imaging.ImageAttributes imageAttr, DrawImageAbort callback) {}
	public void DrawImage(Image image, PointF[] destPoints, RectangleF srcRect, GraphicsUnit srcUnit, System.Drawing.Imaging.ImageAttributes imageAttr, DrawImageAbort callback, int callbackData) {}
	public void DrawImage(Image image, Point[] destPoints, Rectangle srcRect, GraphicsUnit srcUnit) {}
	public void DrawImage(Image image, Point[] destPoints, Rectangle srcRect, GraphicsUnit srcUnit, System.Drawing.Imaging.ImageAttributes imageAttr) {}
	public void DrawImage(Image image, Point[] destPoints, Rectangle srcRect, GraphicsUnit srcUnit, System.Drawing.Imaging.ImageAttributes imageAttr, DrawImageAbort callback) {}
	public void DrawImage(Image image, Point[] destPoints, Rectangle srcRect, GraphicsUnit srcUnit, System.Drawing.Imaging.ImageAttributes imageAttr, DrawImageAbort callback, int callbackData) {}
	public void DrawImage(Image image, Rectangle destRect, float srcX, float srcY, float srcWidth, float srcHeight, GraphicsUnit srcUnit) {}
	public void DrawImage(Image image, Rectangle destRect, float srcX, float srcY, float srcWidth, float srcHeight, GraphicsUnit srcUnit, System.Drawing.Imaging.ImageAttributes imageAttrs) {}
	public void DrawImage(Image image, Rectangle destRect, float srcX, float srcY, float srcWidth, float srcHeight, GraphicsUnit srcUnit, System.Drawing.Imaging.ImageAttributes imageAttrs, DrawImageAbort callback) {}
	public void DrawImage(Image image, Rectangle destRect, float srcX, float srcY, float srcWidth, float srcHeight, GraphicsUnit srcUnit, System.Drawing.Imaging.ImageAttributes imageAttrs, DrawImageAbort callback, System.IntPtr callbackData) {}
	public void DrawImage(Image image, Rectangle destRect, int srcX, int srcY, int srcWidth, int srcHeight, GraphicsUnit srcUnit) {}
	public void DrawImage(Image image, Rectangle destRect, int srcX, int srcY, int srcWidth, int srcHeight, GraphicsUnit srcUnit, System.Drawing.Imaging.ImageAttributes imageAttr) {}
	public void DrawImage(Image image, Rectangle destRect, int srcX, int srcY, int srcWidth, int srcHeight, GraphicsUnit srcUnit, System.Drawing.Imaging.ImageAttributes imageAttr, DrawImageAbort callback) {}
	public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, PointF destPoint, EnumerateMetafileProc callback) {}
	public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, PointF destPoint, EnumerateMetafileProc callback, System.IntPtr callbackData) {}
	public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, PointF destPoint, EnumerateMetafileProc callback, System.IntPtr callbackData, System.Drawing.Imaging.ImageAttributes imageAttr) {}
	public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, Point destPoint, EnumerateMetafileProc callback) {}
	public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, Point destPoint, EnumerateMetafileProc callback, System.IntPtr callbackData) {}
	public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, Point destPoint, EnumerateMetafileProc callback, System.IntPtr callbackData, System.Drawing.Imaging.ImageAttributes imageAttr) {}
	public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, RectangleF destRect, EnumerateMetafileProc callback) {}
	public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, RectangleF destRect, EnumerateMetafileProc callback, System.IntPtr callbackData) {}
	public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, RectangleF destRect, EnumerateMetafileProc callback, System.IntPtr callbackData, System.Drawing.Imaging.ImageAttributes imageAttr) {}
	public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, Rectangle destRect, EnumerateMetafileProc callback) {}
	public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, Rectangle destRect, EnumerateMetafileProc callback, System.IntPtr callbackData) {}
	public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, Rectangle destRect, EnumerateMetafileProc callback, System.IntPtr callbackData, System.Drawing.Imaging.ImageAttributes imageAttr) {}
	public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, PointF[] destPoints, EnumerateMetafileProc callback) {}
	public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, PointF[] destPoints, EnumerateMetafileProc callback, System.IntPtr callbackData) {}
	public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, PointF[] destPoints, EnumerateMetafileProc callback, System.IntPtr callbackData, System.Drawing.Imaging.ImageAttributes imageAttr) {}
	public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, Point[] destPoints, EnumerateMetafileProc callback) {}
	public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, Point[] destPoints, EnumerateMetafileProc callback, System.IntPtr callbackData) {}
	public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, Point[] destPoints, EnumerateMetafileProc callback, System.IntPtr callbackData, System.Drawing.Imaging.ImageAttributes imageAttr) {}
	public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, PointF destPoint, RectangleF srcRect, GraphicsUnit srcUnit, EnumerateMetafileProc callback) {}
	public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, PointF destPoint, RectangleF srcRect, GraphicsUnit srcUnit, EnumerateMetafileProc callback, System.IntPtr callbackData) {}
	public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, PointF destPoint, RectangleF srcRect, GraphicsUnit unit, EnumerateMetafileProc callback, System.IntPtr callbackData, System.Drawing.Imaging.ImageAttributes imageAttr) {}
	public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, Point destPoint, Rectangle srcRect, GraphicsUnit srcUnit, EnumerateMetafileProc callback) {}
	public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, Point destPoint, Rectangle srcRect, GraphicsUnit srcUnit, EnumerateMetafileProc callback, System.IntPtr callbackData) {}
	public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, Point destPoint, Rectangle srcRect, GraphicsUnit unit, EnumerateMetafileProc callback, System.IntPtr callbackData, System.Drawing.Imaging.ImageAttributes imageAttr) {}
	public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, RectangleF destRect, RectangleF srcRect, GraphicsUnit srcUnit, EnumerateMetafileProc callback) {}
	public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, RectangleF destRect, RectangleF srcRect, GraphicsUnit srcUnit, EnumerateMetafileProc callback, System.IntPtr callbackData) {}
	public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, RectangleF destRect, RectangleF srcRect, GraphicsUnit unit, EnumerateMetafileProc callback, System.IntPtr callbackData, System.Drawing.Imaging.ImageAttributes imageAttr) {}
	public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, Rectangle destRect, Rectangle srcRect, GraphicsUnit srcUnit, EnumerateMetafileProc callback) {}
	public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, Rectangle destRect, Rectangle srcRect, GraphicsUnit srcUnit, EnumerateMetafileProc callback, System.IntPtr callbackData) {}
	public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, Rectangle destRect, Rectangle srcRect, GraphicsUnit unit, EnumerateMetafileProc callback, System.IntPtr callbackData, System.Drawing.Imaging.ImageAttributes imageAttr) {}
	public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, PointF[] destPoints, RectangleF srcRect, GraphicsUnit srcUnit, EnumerateMetafileProc callback) {}
	public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, PointF[] destPoints, RectangleF srcRect, GraphicsUnit srcUnit, EnumerateMetafileProc callback, System.IntPtr callbackData) {}
	public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, PointF[] destPoints, RectangleF srcRect, GraphicsUnit unit, EnumerateMetafileProc callback, System.IntPtr callbackData, System.Drawing.Imaging.ImageAttributes imageAttr) {}
	public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, Point[] destPoints, Rectangle srcRect, GraphicsUnit srcUnit, EnumerateMetafileProc callback) {}
	public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, Point[] destPoints, Rectangle srcRect, GraphicsUnit srcUnit, EnumerateMetafileProc callback, System.IntPtr callbackData) {}
	public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, Point[] destPoints, Rectangle srcRect, GraphicsUnit unit, EnumerateMetafileProc callback, System.IntPtr callbackData, System.Drawing.Imaging.ImageAttributes imageAttr) {}
	public void SetClip(Graphics g) {}
	public void SetClip(Graphics g, System.Drawing.Drawing2D.CombineMode combineMode) {}
	public void SetClip(Rectangle rect, System.Drawing.Drawing2D.CombineMode combineMode) {}
	public void SetClip(RectangleF rect) {}
	public void SetClip(RectangleF rect, System.Drawing.Drawing2D.CombineMode combineMode) {}
	public void SetClip(System.Drawing.Drawing2D.GraphicsPath path) {}
	public void SetClip(System.Drawing.Drawing2D.GraphicsPath path, System.Drawing.Drawing2D.CombineMode combineMode) {}
	public void IntersectClip(Rectangle rect) {}
	public void IntersectClip(RectangleF rect) {}
	public void IntersectClip(Region region) {}
	public void ExcludeClip(Rectangle rect) {}
	public void ResetClip() {}
	public void TranslateClip(float dx, float dy) {}
	public bool IsVisible(int x, int y) {}
	public bool IsVisible(Point point) {}
	public bool IsVisible(float x, float y) {}
	public bool IsVisible(PointF point) {}
	public bool IsVisible(int x, int y, int width, int height) {}
	public bool IsVisible(Rectangle rect) {}
	public bool IsVisible(float x, float y, float width, float height) {}
	public bool IsVisible(RectangleF rect) {}
	public System.Drawing.Drawing2D.GraphicsContainer BeginContainer(RectangleF dstrect, RectangleF srcrect, GraphicsUnit unit) {}
	public System.Drawing.Drawing2D.GraphicsContainer BeginContainer() {}
	public void EndContainer(System.Drawing.Drawing2D.GraphicsContainer container) {}
	public System.Drawing.Drawing2D.GraphicsContainer BeginContainer(Rectangle dstrect, Rectangle srcrect, GraphicsUnit unit) {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Drawing.Drawing2D.CompositingMode CompositingMode { get{} set{} }
	public Point RenderingOrigin { get{} set{} }
	public System.Drawing.Drawing2D.CompositingQuality CompositingQuality { get{} set{} }
	public System.Drawing.Text.TextRenderingHint TextRenderingHint { get{} set{} }
	public int TextContrast { get{} set{} }
	public System.Drawing.Drawing2D.SmoothingMode SmoothingMode { get{} set{} }
	public System.Drawing.Drawing2D.PixelOffsetMode PixelOffsetMode { get{} set{} }
	public System.Drawing.Drawing2D.InterpolationMode InterpolationMode { get{} set{} }
	public System.Drawing.Drawing2D.Matrix Transform { get{} set{} }
	public GraphicsUnit PageUnit { get{} set{} }
	public float PageScale { get{} set{} }
	public float DpiX { get{} }
	public float DpiY { get{} }
	public Region Clip { get{} set{} }
	public RectangleF ClipBounds { get{} }
	public bool IsClipEmpty { get{} }
	public RectangleF VisibleClipBounds { get{} }
	public bool IsVisibleClipEmpty { get{} }
}

