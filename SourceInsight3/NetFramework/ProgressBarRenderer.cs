public class ProgressBarRenderer
{

	// Methods
	public static void DrawHorizontalBar(System.Drawing.Graphics g, System.Drawing.Rectangle bounds) {}
	public static void DrawVerticalBar(System.Drawing.Graphics g, System.Drawing.Rectangle bounds) {}
	public static void DrawHorizontalChunks(System.Drawing.Graphics g, System.Drawing.Rectangle bounds) {}
	public static void DrawVerticalChunks(System.Drawing.Graphics g, System.Drawing.Rectangle bounds) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool IsSupported { get{} }
	public int ChunkThickness { get{} }
	public int ChunkSpaceThickness { get{} }
}

