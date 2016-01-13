public class EncoderValue : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public EncoderValue ColorTypeCMYK;
	public EncoderValue ColorTypeYCCK;
	public EncoderValue CompressionLZW;
	public EncoderValue CompressionCCITT3;
	public EncoderValue CompressionCCITT4;
	public EncoderValue CompressionRle;
	public EncoderValue CompressionNone;
	public EncoderValue ScanMethodInterlaced;
	public EncoderValue ScanMethodNonInterlaced;
	public EncoderValue VersionGif87;
	public EncoderValue VersionGif89;
	public EncoderValue RenderProgressive;
	public EncoderValue RenderNonProgressive;
	public EncoderValue TransformRotate90;
	public EncoderValue TransformRotate180;
	public EncoderValue TransformRotate270;
	public EncoderValue TransformFlipHorizontal;
	public EncoderValue TransformFlipVertical;
	public EncoderValue MultiFrame;
	public EncoderValue LastFrame;
	public EncoderValue Flush;
	public EncoderValue FrameDimensionTime;
	public EncoderValue FrameDimensionResolution;
	public EncoderValue FrameDimensionPage;
}

