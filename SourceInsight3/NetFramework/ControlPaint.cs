public class ControlPaint
{

	// Methods
	public static System.IntPtr CreateHBitmap16Bit(System.Drawing.Bitmap bitmap, System.Drawing.Color background) {}
	public static System.IntPtr CreateHBitmapTransparencyMask(System.Drawing.Bitmap bitmap) {}
	public static System.IntPtr CreateHBitmapColorMask(System.Drawing.Bitmap bitmap, System.IntPtr monochromeMask) {}
	public static System.Drawing.Color Dark(System.Drawing.Color baseColor, float percOfDarkDark) {}
	public static System.Drawing.Color Dark(System.Drawing.Color baseColor) {}
	public static System.Drawing.Color DarkDark(System.Drawing.Color baseColor) {}
	public static void DrawBorder(System.Drawing.Graphics graphics, System.Drawing.Rectangle bounds, System.Drawing.Color color, ButtonBorderStyle style) {}
	public static void DrawBorder(System.Drawing.Graphics graphics, System.Drawing.Rectangle bounds, System.Drawing.Color leftColor, int leftWidth, ButtonBorderStyle leftStyle, System.Drawing.Color topColor, int topWidth, ButtonBorderStyle topStyle, System.Drawing.Color rightColor, int rightWidth, ButtonBorderStyle rightStyle, System.Drawing.Color bottomColor, int bottomWidth, ButtonBorderStyle bottomStyle) {}
	public static void DrawBorder3D(System.Drawing.Graphics graphics, System.Drawing.Rectangle rectangle) {}
	public static void DrawBorder3D(System.Drawing.Graphics graphics, System.Drawing.Rectangle rectangle, Border3DStyle style) {}
	public static void DrawBorder3D(System.Drawing.Graphics graphics, System.Drawing.Rectangle rectangle, Border3DStyle style, Border3DSide sides) {}
	public static void DrawBorder3D(System.Drawing.Graphics graphics, int x, int y, int width, int height) {}
	public static void DrawBorder3D(System.Drawing.Graphics graphics, int x, int y, int width, int height, Border3DStyle style) {}
	public static void DrawBorder3D(System.Drawing.Graphics graphics, int x, int y, int width, int height, Border3DStyle style, Border3DSide sides) {}
	public static void DrawButton(System.Drawing.Graphics graphics, System.Drawing.Rectangle rectangle, ButtonState state) {}
	public static void DrawButton(System.Drawing.Graphics graphics, int x, int y, int width, int height, ButtonState state) {}
	public static void DrawCaptionButton(System.Drawing.Graphics graphics, System.Drawing.Rectangle rectangle, CaptionButton button, ButtonState state) {}
	public static void DrawCaptionButton(System.Drawing.Graphics graphics, int x, int y, int width, int height, CaptionButton button, ButtonState state) {}
	public static void DrawCheckBox(System.Drawing.Graphics graphics, System.Drawing.Rectangle rectangle, ButtonState state) {}
	public static void DrawCheckBox(System.Drawing.Graphics graphics, int x, int y, int width, int height, ButtonState state) {}
	public static void DrawComboButton(System.Drawing.Graphics graphics, System.Drawing.Rectangle rectangle, ButtonState state) {}
	public static void DrawComboButton(System.Drawing.Graphics graphics, int x, int y, int width, int height, ButtonState state) {}
	public static void DrawContainerGrabHandle(System.Drawing.Graphics graphics, System.Drawing.Rectangle bounds) {}
	public static void DrawFocusRectangle(System.Drawing.Graphics graphics, System.Drawing.Rectangle rectangle) {}
	public static void DrawFocusRectangle(System.Drawing.Graphics graphics, System.Drawing.Rectangle rectangle, System.Drawing.Color foreColor, System.Drawing.Color backColor) {}
	public static void DrawGrabHandle(System.Drawing.Graphics graphics, System.Drawing.Rectangle rectangle, bool primary, bool enabled) {}
	public static void DrawGrid(System.Drawing.Graphics graphics, System.Drawing.Rectangle area, System.Drawing.Size pixelsBetweenDots, System.Drawing.Color backColor) {}
	public static void DrawImageDisabled(System.Drawing.Graphics graphics, System.Drawing.Image image, int x, int y, System.Drawing.Color background) {}
	public static void DrawLockedFrame(System.Drawing.Graphics graphics, System.Drawing.Rectangle rectangle, bool primary) {}
	public static void DrawMenuGlyph(System.Drawing.Graphics graphics, System.Drawing.Rectangle rectangle, MenuGlyph glyph) {}
	public static void DrawMenuGlyph(System.Drawing.Graphics graphics, System.Drawing.Rectangle rectangle, MenuGlyph glyph, System.Drawing.Color foreColor, System.Drawing.Color backColor) {}
	public static void DrawMenuGlyph(System.Drawing.Graphics graphics, int x, int y, int width, int height, MenuGlyph glyph) {}
	public static void DrawMenuGlyph(System.Drawing.Graphics graphics, int x, int y, int width, int height, MenuGlyph glyph, System.Drawing.Color foreColor, System.Drawing.Color backColor) {}
	public static void DrawMixedCheckBox(System.Drawing.Graphics graphics, System.Drawing.Rectangle rectangle, ButtonState state) {}
	public static void DrawMixedCheckBox(System.Drawing.Graphics graphics, int x, int y, int width, int height, ButtonState state) {}
	public static void DrawRadioButton(System.Drawing.Graphics graphics, System.Drawing.Rectangle rectangle, ButtonState state) {}
	public static void DrawRadioButton(System.Drawing.Graphics graphics, int x, int y, int width, int height, ButtonState state) {}
	public static void DrawReversibleFrame(System.Drawing.Rectangle rectangle, System.Drawing.Color backColor, FrameStyle style) {}
	public static void DrawReversibleLine(System.Drawing.Point start, System.Drawing.Point end, System.Drawing.Color backColor) {}
	public static void DrawScrollButton(System.Drawing.Graphics graphics, System.Drawing.Rectangle rectangle, ScrollButton button, ButtonState state) {}
	public static void DrawScrollButton(System.Drawing.Graphics graphics, int x, int y, int width, int height, ScrollButton button, ButtonState state) {}
	public static void DrawSelectionFrame(System.Drawing.Graphics graphics, bool active, System.Drawing.Rectangle outsideRect, System.Drawing.Rectangle insideRect, System.Drawing.Color backColor) {}
	public static void DrawSizeGrip(System.Drawing.Graphics graphics, System.Drawing.Color backColor, System.Drawing.Rectangle bounds) {}
	public static void DrawSizeGrip(System.Drawing.Graphics graphics, System.Drawing.Color backColor, int x, int y, int width, int height) {}
	public static void DrawStringDisabled(System.Drawing.Graphics graphics, string s, System.Drawing.Font font, System.Drawing.Color color, System.Drawing.RectangleF layoutRectangle, System.Drawing.StringFormat format) {}
	public static void DrawStringDisabled(System.Drawing.IDeviceContext dc, string s, System.Drawing.Font font, System.Drawing.Color color, System.Drawing.Rectangle layoutRectangle, TextFormatFlags format) {}
	public static void DrawVisualStyleBorder(System.Drawing.Graphics graphics, System.Drawing.Rectangle bounds) {}
	public static void FillReversibleRectangle(System.Drawing.Rectangle rectangle, System.Drawing.Color backColor) {}
	public static System.Drawing.Color Light(System.Drawing.Color baseColor, float percOfLightLight) {}
	public static System.Drawing.Color Light(System.Drawing.Color baseColor) {}
	public static System.Drawing.Color LightLight(System.Drawing.Color baseColor) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Drawing.Color ContrastControlDark { get{} }
}

