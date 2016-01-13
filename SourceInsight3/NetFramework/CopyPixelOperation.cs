public class CopyPixelOperation : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
{

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public virtual string ToString(string format, System.IFormatProvider provider) {}
	public virtual int CompareTo(object target) {}
	public virtual string ToString(System.IFormatProvider provider) {}
	public virtual System.TypeCode GetTypeCode() {}
	public string ToString(string format) {}
	public Type GetType() {}

	// Fields
	public int value__;
	public CopyPixelOperation Blackness;
	public CopyPixelOperation CaptureBlt;
	public CopyPixelOperation DestinationInvert;
	public CopyPixelOperation MergeCopy;
	public CopyPixelOperation MergePaint;
	public CopyPixelOperation NoMirrorBitmap;
	public CopyPixelOperation NotSourceCopy;
	public CopyPixelOperation NotSourceErase;
	public CopyPixelOperation PatCopy;
	public CopyPixelOperation PatInvert;
	public CopyPixelOperation PatPaint;
	public CopyPixelOperation SourceAnd;
	public CopyPixelOperation SourceCopy;
	public CopyPixelOperation SourceErase;
	public CopyPixelOperation SourceInvert;
	public CopyPixelOperation SourcePaint;
	public CopyPixelOperation Whiteness;
}

