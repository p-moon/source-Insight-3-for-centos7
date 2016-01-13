public class EncoderParameter : System.IDisposable
{

	// Constructors
	public EncoderParameter(Encoder encoder, byte value) {}
	public EncoderParameter(Encoder encoder, byte value, bool undefined) {}
	public EncoderParameter(Encoder encoder, short value) {}
	public EncoderParameter(Encoder encoder, long value) {}
	public EncoderParameter(Encoder encoder, int numerator, int demoninator) {}
	public EncoderParameter(Encoder encoder, long rangebegin, long rangeend) {}
	public EncoderParameter(Encoder encoder, int numerator1, int demoninator1, int numerator2, int demoninator2) {}
	public EncoderParameter(Encoder encoder, string value) {}
	public EncoderParameter(Encoder encoder, byte[] value) {}
	public EncoderParameter(Encoder encoder, byte[] value, bool undefined) {}
	public EncoderParameter(Encoder encoder, short[] value) {}
	public EncoderParameter(Encoder encoder, long[] value) {}
	public EncoderParameter(Encoder encoder, int[] numerator, int[] denominator) {}
	public EncoderParameter(Encoder encoder, long[] rangebegin, long[] rangeend) {}
	public EncoderParameter(Encoder encoder, int[] numerator1, int[] denominator1, int[] numerator2, int[] denominator2) {}
	public EncoderParameter(Encoder encoder, int NumberOfValues, int Type, int Value) {}

	// Methods
	public virtual void Dispose() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Encoder Encoder { get{} set{} }
	public EncoderParameterValueType Type { get{} }
	public EncoderParameterValueType ValueType { get{} }
	public int NumberOfValues { get{} }
}

