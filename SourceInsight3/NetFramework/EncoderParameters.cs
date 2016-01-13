public class EncoderParameters : System.IDisposable
{

	// Constructors
	public EncoderParameters(int count) {}
	public EncoderParameters() {}

	// Methods
	public virtual void Dispose() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public EncoderParameter[] Param { get{} set{} }
}

