public class TrackBarRenderer
{

	// Methods
	public static void DrawHorizontalTrack(System.Drawing.Graphics g, System.Drawing.Rectangle bounds) {}
	public static void DrawVerticalTrack(System.Drawing.Graphics g, System.Drawing.Rectangle bounds) {}
	public static void DrawHorizontalThumb(System.Drawing.Graphics g, System.Drawing.Rectangle bounds, System.Windows.Forms.VisualStyles.TrackBarThumbState state) {}
	public static void DrawVerticalThumb(System.Drawing.Graphics g, System.Drawing.Rectangle bounds, System.Windows.Forms.VisualStyles.TrackBarThumbState state) {}
	public static void DrawLeftPointingThumb(System.Drawing.Graphics g, System.Drawing.Rectangle bounds, System.Windows.Forms.VisualStyles.TrackBarThumbState state) {}
	public static void DrawRightPointingThumb(System.Drawing.Graphics g, System.Drawing.Rectangle bounds, System.Windows.Forms.VisualStyles.TrackBarThumbState state) {}
	public static void DrawTopPointingThumb(System.Drawing.Graphics g, System.Drawing.Rectangle bounds, System.Windows.Forms.VisualStyles.TrackBarThumbState state) {}
	public static void DrawBottomPointingThumb(System.Drawing.Graphics g, System.Drawing.Rectangle bounds, System.Windows.Forms.VisualStyles.TrackBarThumbState state) {}
	public static void DrawHorizontalTicks(System.Drawing.Graphics g, System.Drawing.Rectangle bounds, int numTicks, System.Windows.Forms.VisualStyles.EdgeStyle edgeStyle) {}
	public static void DrawVerticalTicks(System.Drawing.Graphics g, System.Drawing.Rectangle bounds, int numTicks, System.Windows.Forms.VisualStyles.EdgeStyle edgeStyle) {}
	public static System.Drawing.Size GetLeftPointingThumbSize(System.Drawing.Graphics g, System.Windows.Forms.VisualStyles.TrackBarThumbState state) {}
	public static System.Drawing.Size GetRightPointingThumbSize(System.Drawing.Graphics g, System.Windows.Forms.VisualStyles.TrackBarThumbState state) {}
	public static System.Drawing.Size GetTopPointingThumbSize(System.Drawing.Graphics g, System.Windows.Forms.VisualStyles.TrackBarThumbState state) {}
	public static System.Drawing.Size GetBottomPointingThumbSize(System.Drawing.Graphics g, System.Windows.Forms.VisualStyles.TrackBarThumbState state) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool IsSupported { get{} }
}

