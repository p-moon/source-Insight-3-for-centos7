public class ImageFormat
{

	// Constructors
	public ImageFormat(System.Guid guid) {}

	// Methods
	public virtual bool Equals(object o) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Properties
	public System.Guid Guid { get{} }
	public ImageFormat MemoryBmp { get{} }
	public ImageFormat Bmp { get{} }
	public ImageFormat Emf { get{} }
	public ImageFormat Wmf { get{} }
	public ImageFormat Gif { get{} }
	public ImageFormat Jpeg { get{} }
	public ImageFormat Png { get{} }
	public ImageFormat Tiff { get{} }
	public ImageFormat Exif { get{} }
	public ImageFormat Icon { get{} }
}

