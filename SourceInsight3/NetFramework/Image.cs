public class Image : System.MarshalByRefObject, System.Runtime.Serialization.ISerializable, System.ICloneable, System.IDisposable
{

	// Methods
	public static Image FromFile(string filename) {}
	public static Image FromFile(string filename, bool useEmbeddedColorManagement) {}
	public static Image FromStream(System.IO.Stream stream) {}
	public static Image FromStream(System.IO.Stream stream, bool useEmbeddedColorManagement) {}
	public static Image FromStream(System.IO.Stream stream, bool useEmbeddedColorManagement, bool validateImageData) {}
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
	public static Bitmap FromHbitmap(System.IntPtr hbitmap) {}
	public static Bitmap FromHbitmap(System.IntPtr hbitmap, System.IntPtr hpalette) {}
	public static int GetPixelFormatSize(System.Drawing.Imaging.PixelFormat pixfmt) {}
	public static bool IsAlphaPixelFormat(System.Drawing.Imaging.PixelFormat pixfmt) {}
	public static bool IsExtendedPixelFormat(System.Drawing.Imaging.PixelFormat pixfmt) {}
	public static bool IsCanonicalPixelFormat(System.Drawing.Imaging.PixelFormat pixfmt) {}
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

