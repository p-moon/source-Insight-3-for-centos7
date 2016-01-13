public class GraphicsPath : System.MarshalByRefObject, System.ICloneable, System.IDisposable
{

	// Constructors
	public GraphicsPath() {}
	public GraphicsPath(FillMode fillMode) {}
	public GraphicsPath(System.Drawing.PointF[] pts, byte[] types) {}
	public GraphicsPath(System.Drawing.PointF[] pts, byte[] types, FillMode fillMode) {}
	public GraphicsPath(System.Drawing.Point[] pts, byte[] types) {}
	public GraphicsPath(System.Drawing.Point[] pts, byte[] types, FillMode fillMode) {}

	// Methods
	public virtual object Clone() {}
	public virtual void Dispose() {}
	public void Reset() {}
	public void StartFigure() {}
	public void CloseFigure() {}
	public void CloseAllFigures() {}
	public void SetMarkers() {}
	public void ClearMarkers() {}
	public void Reverse() {}
	public System.Drawing.PointF GetLastPoint() {}
	public bool IsVisible(float x, float y) {}
	public bool IsVisible(System.Drawing.PointF point) {}
	public bool IsVisible(float x, float y, System.Drawing.Graphics graphics) {}
	public bool IsVisible(System.Drawing.PointF pt, System.Drawing.Graphics graphics) {}
	public bool IsVisible(int x, int y) {}
	public bool IsVisible(System.Drawing.Point point) {}
	public bool IsVisible(int x, int y, System.Drawing.Graphics graphics) {}
	public bool IsVisible(System.Drawing.Point pt, System.Drawing.Graphics graphics) {}
	public bool IsOutlineVisible(float x, float y, System.Drawing.Pen pen) {}
	public bool IsOutlineVisible(System.Drawing.PointF point, System.Drawing.Pen pen) {}
	public bool IsOutlineVisible(float x, float y, System.Drawing.Pen pen, System.Drawing.Graphics graphics) {}
	public bool IsOutlineVisible(System.Drawing.PointF pt, System.Drawing.Pen pen, System.Drawing.Graphics graphics) {}
	public bool IsOutlineVisible(int x, int y, System.Drawing.Pen pen) {}
	public bool IsOutlineVisible(System.Drawing.Point point, System.Drawing.Pen pen) {}
	public bool IsOutlineVisible(int x, int y, System.Drawing.Pen pen, System.Drawing.Graphics graphics) {}
	public bool IsOutlineVisible(System.Drawing.Point pt, System.Drawing.Pen pen, System.Drawing.Graphics graphics) {}
	public void AddLine(System.Drawing.PointF pt1, System.Drawing.PointF pt2) {}
	public void AddLine(float x1, float y1, float x2, float y2) {}
	public void AddLines(System.Drawing.PointF[] points) {}
	public void AddLine(System.Drawing.Point pt1, System.Drawing.Point pt2) {}
	public void AddLine(int x1, int y1, int x2, int y2) {}
	public void AddLines(System.Drawing.Point[] points) {}
	public void AddArc(System.Drawing.RectangleF rect, float startAngle, float sweepAngle) {}
	public void AddArc(float x, float y, float width, float height, float startAngle, float sweepAngle) {}
	public void AddArc(System.Drawing.Rectangle rect, float startAngle, float sweepAngle) {}
	public void AddArc(int x, int y, int width, int height, float startAngle, float sweepAngle) {}
	public void AddBezier(System.Drawing.PointF pt1, System.Drawing.PointF pt2, System.Drawing.PointF pt3, System.Drawing.PointF pt4) {}
	public void AddBezier(float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4) {}
	public void AddBeziers(System.Drawing.PointF[] points) {}
	public void AddBezier(System.Drawing.Point pt1, System.Drawing.Point pt2, System.Drawing.Point pt3, System.Drawing.Point pt4) {}
	public void AddBezier(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4) {}
	public void AddBeziers(System.Drawing.Point[] points) {}
	public void AddCurve(System.Drawing.PointF[] points) {}
	public void AddCurve(System.Drawing.PointF[] points, float tension) {}
	public void AddCurve(System.Drawing.PointF[] points, int offset, int numberOfSegments, float tension) {}
	public void AddCurve(System.Drawing.Point[] points) {}
	public void AddCurve(System.Drawing.Point[] points, float tension) {}
	public void AddCurve(System.Drawing.Point[] points, int offset, int numberOfSegments, float tension) {}
	public void AddClosedCurve(System.Drawing.PointF[] points) {}
	public void AddClosedCurve(System.Drawing.PointF[] points, float tension) {}
	public void AddClosedCurve(System.Drawing.Point[] points) {}
	public void AddClosedCurve(System.Drawing.Point[] points, float tension) {}
	public void AddRectangle(System.Drawing.RectangleF rect) {}
	public void AddRectangles(System.Drawing.RectangleF[] rects) {}
	public void AddRectangle(System.Drawing.Rectangle rect) {}
	public void AddRectangles(System.Drawing.Rectangle[] rects) {}
	public void AddEllipse(System.Drawing.RectangleF rect) {}
	public void AddEllipse(float x, float y, float width, float height) {}
	public void AddEllipse(System.Drawing.Rectangle rect) {}
	public void AddEllipse(int x, int y, int width, int height) {}
	public void AddPie(System.Drawing.Rectangle rect, float startAngle, float sweepAngle) {}
	public void AddPie(float x, float y, float width, float height, float startAngle, float sweepAngle) {}
	public void AddPie(int x, int y, int width, int height, float startAngle, float sweepAngle) {}
	public void AddPolygon(System.Drawing.PointF[] points) {}
	public void AddPolygon(System.Drawing.Point[] points) {}
	public void AddPath(GraphicsPath addingPath, bool connect) {}
	public void AddString(string s, System.Drawing.FontFamily family, int style, float emSize, System.Drawing.PointF origin, System.Drawing.StringFormat format) {}
	public void AddString(string s, System.Drawing.FontFamily family, int style, float emSize, System.Drawing.Point origin, System.Drawing.StringFormat format) {}
	public void AddString(string s, System.Drawing.FontFamily family, int style, float emSize, System.Drawing.RectangleF layoutRect, System.Drawing.StringFormat format) {}
	public void AddString(string s, System.Drawing.FontFamily family, int style, float emSize, System.Drawing.Rectangle layoutRect, System.Drawing.StringFormat format) {}
	public void Transform(Matrix matrix) {}
	public System.Drawing.RectangleF GetBounds() {}
	public System.Drawing.RectangleF GetBounds(Matrix matrix) {}
	public System.Drawing.RectangleF GetBounds(Matrix matrix, System.Drawing.Pen pen) {}
	public void Flatten() {}
	public void Flatten(Matrix matrix) {}
	public void Flatten(Matrix matrix, float flatness) {}
	public void Widen(System.Drawing.Pen pen) {}
	public void Widen(System.Drawing.Pen pen, Matrix matrix) {}
	public void Widen(System.Drawing.Pen pen, Matrix matrix, float flatness) {}
	public void Warp(System.Drawing.PointF[] destPoints, System.Drawing.RectangleF srcRect) {}
	public void Warp(System.Drawing.PointF[] destPoints, System.Drawing.RectangleF srcRect, Matrix matrix) {}
	public void Warp(System.Drawing.PointF[] destPoints, System.Drawing.RectangleF srcRect, Matrix matrix, WarpMode warpMode) {}
	public void Warp(System.Drawing.PointF[] destPoints, System.Drawing.RectangleF srcRect, Matrix matrix, WarpMode warpMode, float flatness) {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public FillMode FillMode { get{} set{} }
	public PathData PathData { get{} }
	public int PointCount { get{} }
	public byte[] PathTypes { get{} }
	public System.Drawing.PointF[] PathPoints { get{} }
}

