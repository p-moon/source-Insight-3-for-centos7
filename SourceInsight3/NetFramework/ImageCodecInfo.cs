public class ImageCodecInfo
{

	// Methods
	public static ImageCodecInfo[] GetImageDecoders() {}
	public static ImageCodecInfo[] GetImageEncoders() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Guid Clsid { get{} set{} }
	public System.Guid FormatID { get{} set{} }
	public string CodecName { get{} set{} }
	public string DllName { get{} set{} }
	public string FormatDescription { get{} set{} }
	public string FilenameExtension { get{} set{} }
	public string MimeType { get{} set{} }
	public ImageCodecFlags Flags { get{} set{} }
	public int Version { get{} set{} }
	public byte[][] SignaturePatterns { get{} set{} }
	public byte[][] SignatureMasks { get{} set{} }
}

