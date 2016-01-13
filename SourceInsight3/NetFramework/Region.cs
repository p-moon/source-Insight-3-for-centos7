public class Region : System.MarshalByRefObject, System.IDisposable
{

	// Constructors
	public Region() {}
	public Region(Rectangle rect) {}
	public Region(RectangleF rect) {}
	public Region(System.Drawing.Drawing2D.GraphicsPath path) {}
	public Region(System.Drawing.Drawing2D.RegionData rgnData) {}

	// Methods
	public void Intersect(Region region) {}
	public void Union(Rectangle rect) {}
	public System.IntPtr GetHrgn(Graphics g) {}
	public bool IsInfinite(Graphics g) {}
	public static Region FromHrgn(System.IntPtr hrgn) {}
	public Region Clone() {}
	public virtual void Dispose() {}
	public void MakeInfinite() {}
	public void MakeEmpty() {}
	public void Intersect(RectangleF rect) {}
	public void Intersect(Rectangle rect) {}
	public void Intersect(System.Drawing.Drawing2D.GraphicsPath path) {}
	public void ReleaseHrgn(System.IntPtr regionHandle) {}
	public void Union(RectangleF rect) {}
	public void Union(System.Drawing.Drawing2D.GraphicsPath path) {}
	public void Union(Region region) {}
	public void Xor(RectangleF rect) {}
	public void Xor(Rectangle rect) {}
	public void Xor(System.Drawing.Drawing2D.GraphicsPath path) {}
	public void Xor(Region region) {}
	public void Exclude(RectangleF rect) {}
	public void Exclude(Rectangle rect) {}
	public void Exclude(System.Drawing.Drawing2D.GraphicsPath path) {}
	public void Exclude(Region region) {}
	public void Complement(RectangleF rect) {}
	public void Complement(Rectangle rect) {}
	public void Complement(System.Drawing.Drawing2D.GraphicsPath path) {}
	public void Complement(Region region) {}
	public void Translate(float dx, float dy) {}
	public void Translate(int dx, int dy) {}
	public void Transform(System.Drawing.Drawing2D.Matrix matrix) {}
	public RectangleF GetBounds(Graphics g) {}
	public bool IsEmpty(Graphics g) {}
	public bool Equals(Region region, Graphics g) {}
	public System.Drawing.Drawing2D.RegionData GetRegionData() {}
	public bool IsVisible(float x, float y) {}
	public bool IsVisible(PointF point) {}
	public bool IsVisible(float x, float y, Graphics g) {}
	public bool IsVisible(PointF point, Graphics g) {}
	public bool IsVisible(float x, float y, float width, float height) {}
	public bool IsVisible(RectangleF rect) {}
	public bool IsVisible(float x, float y, float width, float height, Graphics g) {}
	public bool IsVisible(RectangleF rect, Graphics g) {}
	public bool IsVisible(int x, int y, Graphics g) {}
	public bool IsVisible(Point point) {}
	public bool IsVisible(Point point, Graphics g) {}
	public bool IsVisible(int x, int y, int width, int height) {}
	public bool IsVisible(Rectangle rect) {}
	public bool IsVisible(int x, int y, int width, int height, Graphics g) {}
	public bool IsVisible(Rectangle rect, Graphics g) {}
	public RectangleF[] GetRegionScans(System.Drawing.Drawing2D.Matrix matrix) {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

