public class Metafile : System.Drawing.Image, System.Runtime.Serialization.ISerializable, System.ICloneable, System.IDisposable
{

	// Constructors
	public Metafile(System.IntPtr hmetafile, WmfPlaceableFileHeader wmfHeader) {}
	public Metafile(System.IntPtr hmetafile, WmfPlaceableFileHeader wmfHeader, bool deleteWmf) {}
	public Metafile(System.IntPtr henhmetafile, bool deleteEmf) {}
	public Metafile(string filename) {}
	public Metafile(System.IO.Stream stream) {}
	public Metafile(System.IntPtr referenceHdc, EmfType emfType) {}
	public Metafile(System.IntPtr referenceHdc, EmfType emfType, string description) {}
	public Metafile(System.IntPtr referenceHdc, System.Drawing.RectangleF frameRect) {}
	public Metafile(System.IntPtr referenceHdc, System.Drawing.RectangleF frameRect, MetafileFrameUnit frameUnit) {}
	public Metafile(System.IntPtr referenceHdc, System.Drawing.RectangleF frameRect, MetafileFrameUnit frameUnit, EmfType type) {}
	public Metafile(System.IntPtr referenceHdc, System.Drawing.RectangleF frameRect, MetafileFrameUnit frameUnit, EmfType type, string description) {}
	public Metafile(System.IntPtr referenceHdc, System.Drawing.Rectangle frameRect) {}
	public Metafile(System.IntPtr referenceHdc, System.Drawing.Rectangle frameRect, MetafileFrameUnit frameUnit) {}
	public Metafile(System.IntPtr referenceHdc, System.Drawing.Rectangle frameRect, MetafileFrameUnit frameUnit, EmfType type) {}
	public Metafile(System.IntPtr referenceHdc, System.Drawing.Rectangle frameRect, MetafileFrameUnit frameUnit, EmfType type, string desc) {}
	public Metafile(string fileName, System.IntPtr referenceHdc) {}
	public Metafile(string fileName, System.IntPtr referenceHdc, EmfType type) {}
	public Metafile(string fileName, System.IntPtr referenceHdc, EmfType type, string description) {}
	public Metafile(string fileName, System.IntPtr referenceHdc, System.Drawing.RectangleF frameRect) {}
	public Metafile(string fileName, System.IntPtr referenceHdc, System.Drawing.RectangleF frameRect, MetafileFrameUnit frameUnit) {}
	public Metafile(string fileName, System.IntPtr referenceHdc, System.Drawing.RectangleF frameRect, MetafileFrameUnit frameUnit, EmfType type) {}
	public Metafile(string fileName, System.IntPtr referenceHdc, System.Drawing.RectangleF frameRect, MetafileFrameUnit frameUnit, string desc) {}
	public Metafile(string fileName, System.IntPtr referenceHdc, System.Drawing.RectangleF frameRect, MetafileFrameUnit frameUnit, EmfType type, string description) {}
	public Metafile(string fileName, System.IntPtr referenceHdc, System.Drawing.Rectangle frameRect) {}
	public Metafile(string fileName, System.IntPtr referenceHdc, System.Drawing.Rectangle frameRect, MetafileFrameUnit frameUnit) {}
	public Metafile(string fileName, System.IntPtr referenceHdc, System.Drawing.Rectangle frameRect, MetafileFrameUnit frameUnit, EmfType type) {}
	public Metafile(string fileName, System.IntPtr referenceHdc, System.Drawing.Rectangle frameRect, MetafileFrameUnit frameUnit, string description) {}
	public Metafile(string fileName, System.IntPtr referenceHdc, System.Drawing.Rectangle frameRect, MetafileFrameUnit frameUnit, EmfType type, string description) {}
	public Metafile(System.IO.Stream stream, System.IntPtr referenceHdc) {}
	public Metafile(System.IO.Stream stream, System.IntPtr referenceHdc, EmfType type) {}
	public Metafile(System.IO.Stream stream, System.IntPtr referenceHdc, EmfType type, string description) {}
	public Metafile(System.IO.Stream stream, System.IntPtr referenceHdc, System.Drawing.RectangleF frameRect) {}
	public Metafile(System.IO.Stream stream, System.IntPtr referenceHdc, System.Drawing.RectangleF frameRect, MetafileFrameUnit frameUnit) {}
	public Metafile(System.IO.Stream stream, System.IntPtr referenceHdc, System.Drawing.RectangleF frameRect, MetafileFrameUnit frameUnit, EmfType type) {}
	public Metafile(System.IO.Stream stream, System.IntPtr referenceHdc, System.Drawing.RectangleF frameRect, MetafileFrameUnit frameUnit, EmfType type, string description) {}
	public Metafile(System.IO.Stream stream, System.IntPtr referenceHdc, System.Drawing.Rectangle frameRect) {}
	public Metafile(System.IO.Stream stream, System.IntPtr referenceHdc, System.Drawing.Rectangle frameRect, MetafileFrameUnit frameUnit) {}
	public Metafile(System.IO.Stream stream, System.IntPtr referenceHdc, System.Drawing.Rectangle frameRect, MetafileFrameUnit frameUnit, EmfType type) {}
	public Metafile(System.IO.Stream stream, System.IntPtr referenceHdc, System.Drawing.Rectangle frameRect, MetafileFrameUnit frameUnit, EmfType type, string description) {}

	// Methods
	public static MetafileHeader GetMetafileHeader(System.IntPtr hmetafile, WmfPlaceableFileHeader wmfHeader) {}
	public static MetafileHeader GetMetafileHeader(System.IntPtr henhmetafile) {}
	public static MetafileHeader GetMetafileHeader(string fileName) {}
	public static MetafileHeader GetMetafileHeader(System.IO.Stream stream) {}
	public MetafileHeader GetMetafileHeader() {}
	public System.IntPtr GetHenhmetafile() {}
	public void PlayRecord(EmfPlusRecordType recordType, int flags, int dataSize, byte[] data) {}
	public virtual object Clone() {}
	public virtual void Dispose() {}
	public EncoderParameters GetEncoderParameterList(System.Guid encoder) {}
	public void Save(string filename) {}
	public void Save(string filename, ImageFormat format) {}
	public void Save(string filename, ImageCodecInfo encoder, EncoderParameters encoderParams) {}
	public void Save(System.IO.Stream stream, ImageFormat format) {}
	public void Save(System.IO.Stream stream, ImageCodecInfo encoder, EncoderParameters encoderParams) {}
	public void SaveAdd(EncoderParameters encoderParams) {}
	public void SaveAdd(System.Drawing.Image image, EncoderParameters encoderParams) {}
	public System.Drawing.RectangleF GetBounds(System.Drawing.GraphicsUnit& pageUnit) {}
	public System.Drawing.Image GetThumbnailImage(int thumbWidth, int thumbHeight, System.Drawing.Image.GetThumbnailImageAbort callback, System.IntPtr callbackData) {}
	public int GetFrameCount(FrameDimension dimension) {}
	public int SelectActiveFrame(FrameDimension dimension, int frameIndex) {}
	public void RotateFlip(System.Drawing.RotateFlipType rotateFlipType) {}
	public PropertyItem GetPropertyItem(int propid) {}
	public void RemovePropertyItem(int propid) {}
	public void SetPropertyItem(PropertyItem propitem) {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public object Tag { get{} set{} }
	public System.Drawing.SizeF PhysicalDimension { get{} }
	public System.Drawing.Size Size { get{} }
	public int Width { get{} }
	public int Height { get{} }
	public float HorizontalResolution { get{} }
	public float VerticalResolution { get{} }
	public int Flags { get{} }
	public ImageFormat RawFormat { get{} }
	public PixelFormat PixelFormat { get{} }
	public ColorPalette Palette { get{} set{} }
	public System.Guid[] FrameDimensionsList { get{} }
	public int[] PropertyIdList { get{} }
	public PropertyItem[] PropertyItems { get{} }
}

