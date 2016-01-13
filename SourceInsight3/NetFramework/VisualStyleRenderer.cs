public class VisualStyleRenderer
{

	// Constructors
	public VisualStyleRenderer(VisualStyleElement element) {}
	public VisualStyleRenderer(string className, int part, int state) {}

	// Methods
	public static bool IsElementDefined(VisualStyleElement element) {}
	public void SetParameters(VisualStyleElement element) {}
	public void SetParameters(string className, int part, int state) {}
	public void DrawBackground(System.Drawing.IDeviceContext dc, System.Drawing.Rectangle bounds) {}
	public void DrawBackground(System.Drawing.IDeviceContext dc, System.Drawing.Rectangle bounds, System.Drawing.Rectangle clipRectangle) {}
	public System.Drawing.Rectangle DrawEdge(System.Drawing.IDeviceContext dc, System.Drawing.Rectangle bounds, Edges edges, EdgeStyle style, EdgeEffects effects) {}
	public void DrawImage(System.Drawing.Graphics g, System.Drawing.Rectangle bounds, System.Drawing.Image image) {}
	public void DrawImage(System.Drawing.Graphics g, System.Drawing.Rectangle bounds, System.Windows.Forms.ImageList imageList, int imageIndex) {}
	public void DrawParentBackground(System.Drawing.IDeviceContext dc, System.Drawing.Rectangle bounds, System.Windows.Forms.Control childControl) {}
	public void DrawText(System.Drawing.IDeviceContext dc, System.Drawing.Rectangle bounds, string textToDraw) {}
	public void DrawText(System.Drawing.IDeviceContext dc, System.Drawing.Rectangle bounds, string textToDraw, bool drawDisabled) {}
	public void DrawText(System.Drawing.IDeviceContext dc, System.Drawing.Rectangle bounds, string textToDraw, bool drawDisabled, System.Windows.Forms.TextFormatFlags flags) {}
	public System.Drawing.Rectangle GetBackgroundContentRectangle(System.Drawing.IDeviceContext dc, System.Drawing.Rectangle bounds) {}
	public System.Drawing.Rectangle GetBackgroundExtent(System.Drawing.IDeviceContext dc, System.Drawing.Rectangle contentBounds) {}
	public System.Drawing.Region GetBackgroundRegion(System.Drawing.IDeviceContext dc, System.Drawing.Rectangle bounds) {}
	public bool GetBoolean(BooleanProperty prop) {}
	public System.Drawing.Color GetColor(ColorProperty prop) {}
	public int GetEnumValue(EnumProperty prop) {}
	public string GetFilename(FilenameProperty prop) {}
	public System.Drawing.Font GetFont(System.Drawing.IDeviceContext dc, FontProperty prop) {}
	public int GetInteger(IntegerProperty prop) {}
	public System.Drawing.Size GetPartSize(System.Drawing.IDeviceContext dc, ThemeSizeType type) {}
	public System.Drawing.Size GetPartSize(System.Drawing.IDeviceContext dc, System.Drawing.Rectangle bounds, ThemeSizeType type) {}
	public System.Drawing.Point GetPoint(PointProperty prop) {}
	public System.Windows.Forms.Padding GetMargins(System.Drawing.IDeviceContext dc, MarginProperty prop) {}
	public string GetString(StringProperty prop) {}
	public System.Drawing.Rectangle GetTextExtent(System.Drawing.IDeviceContext dc, string textToDraw, System.Windows.Forms.TextFormatFlags flags) {}
	public System.Drawing.Rectangle GetTextExtent(System.Drawing.IDeviceContext dc, System.Drawing.Rectangle bounds, string textToDraw, System.Windows.Forms.TextFormatFlags flags) {}
	public TextMetrics GetTextMetrics(System.Drawing.IDeviceContext dc) {}
	public HitTestCode HitTestBackground(System.Drawing.IDeviceContext dc, System.Drawing.Rectangle backgroundRectangle, System.Drawing.Point pt, HitTestOptions options) {}
	public HitTestCode HitTestBackground(System.Drawing.Graphics g, System.Drawing.Rectangle backgroundRectangle, System.Drawing.Region region, System.Drawing.Point pt, HitTestOptions options) {}
	public HitTestCode HitTestBackground(System.Drawing.IDeviceContext dc, System.Drawing.Rectangle backgroundRectangle, System.IntPtr hRgn, System.Drawing.Point pt, HitTestOptions options) {}
	public bool IsBackgroundPartiallyTransparent() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool IsSupported { get{} }
	public string Class { get{} }
	public int Part { get{} }
	public int State { get{} }
	public System.IntPtr Handle { get{} }
	public int LastHResult { get{} }
}

