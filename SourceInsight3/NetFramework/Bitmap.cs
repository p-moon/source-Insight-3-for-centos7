public class Bitmap : Image, System.Runtime.Serialization.ISerializable, System.ICloneable, System.IDisposable
{

	// Constructors
	public Bitmap(string filename) {}
	public Bitmap(string filename, bool useIcm) {}
	public Bitmap(Type type, string resource) {}
	public Bitmap(System.IO.Stream stream) {}
	public Bitmap(System.IO.Stream stream, bool useIcm) {}
	public Bitmap(int width, int height, int stride, System.Drawing.Imaging.PixelFormat format, System.IntPtr scan0) {}
	public Bitmap(int width, int height, System.Drawing.Imaging.PixelFormat format) {}
	public Bitmap(int width, int height) {}
	public Bitmap(int width, int height, Graphics g) {}
	public Bitmap(Image original) {}
	public Bitmap(Image original, int width, int height) {}
	public Bitmap(Image original, Size newSize) {}

	// Methods
	public static Bitmap FromHicon(System.IntPtr hicon) {}
	public static Bitmap FromResource(System.IntPtr hinstance, string bitmapName) {}
	public System.IntPtr GetHbitmap() {}
	public System.IntPtr GetHbitmap(Color background) {}
	public System.IntPtr GetHicon() {}
	public Bitmap Clone(Rectangle rect, System.Drawing.Imaging.PixelFormat format) {}
	public Bitmap Clone(RectangleF rect, System.Drawing.Imaging.PixelFormat format) {}
	public void MakeTransparent() {}
	public void MakeTransparent(Color transparentColor) {}
	public System.Drawing.Imaging.BitmapData LockBits(Rectangle rect, System.Drawing.Imaging.ImageLockMode flags, System.Drawing.Imaging.PixelFormat format) {}
	public System.Drawing.Imaging.BitmapData LockBits(Rectangle rect, System.Drawing.Imaging.ImageLockMode flags, System.Drawing.Imaging.PixelFormat format, System.Drawing.Imaging.BitmapData bitmapData) {}
	public void UnlockBits(System.Drawing.Imaging.BitmapData bitmapdata) {}
	public Color GetPixel(int x, int y) {}
	public void SetPixel(int x, int y, Color color) {}
	public void SetResolution(float xDpi, float yDpi) {}
	public virtual object Clone() {}
	public virtual void Dispose() {}
	public System.Drawing.Imaging.EncoderParameters GetEncoderParameterList(System.Guid encoder) {}
	public void Save(string filename) {}
	public void Save(string filename, System.Drawing.Imaging.ImageFormat format) {}
	public void Save(string filename, System.Drawing.Imaging.ImageCodecInfo encoder, System.Drawing.Imaging.EncoderParameters encoderParams) {}
	public void Save(System.IO.Stream stream, System.Drawing.Imaging.ImageFormat format) {}
	public void Save(System.IO.Stream stream, System.Drawing.Imaging.ImageCodecInfo encoder, System.Drawing.Imaging.EncoderParameters encoderParams) {}
	public void SaveAdd(System.Drawing.Imaging.EncoderParameters encoderParams) {}
	public void SaveAdd(Image image, System.Drawing.Imaging.EncoderParameters encoderParams) {}
	public RectangleF GetBounds(GraphicsUnit& pageUnit) {}
	public Image GetThumbnailImage(int thumbWidth, int thumbHeight, GetThumbnailImageAbort callback, System.IntPtr callbackData) {}
	public int GetFrameCount(System.Drawing.Imaging.FrameDimension dimension) {}
	public int SelectActiveFrame(System.Drawing.Imaging.FrameDimension dimension, int frameIndex) {}
	public void RotateFlip(RotateFlipType rotateFlipType) {}
	public System.Drawing.Imaging.PropertyItem GetPropertyItem(int propid) {}
	public void RemovePropertyItem(int propid) {}
	public void SetPropertyItem(System.Drawing.Imaging.PropertyItem propitem) {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public object Tag { get{} set{} }
	public SizeF PhysicalDimension { get{} }
	public Size Size { get{} }
	public int Width { get{} }
	public int Height { get{} }
	public float HorizontalResolution { get{} }
	public float VerticalResolution { get{} }
	public int Flags { get{} }
	public System.Drawing.Imaging.ImageFormat RawFormat { get{} }
	public System.Drawing.Imaging.PixelFormat PixelFormat { get{} }
	public System.Drawing.Imaging.ColorPalette Palette { get{} set{} }
	public System.Guid[] FrameDimensionsList { get{} }
	public int[] PropertyIdList { get{} }
	public System.Drawing.Imaging.PropertyItem[] PropertyItems { get{} }
}

