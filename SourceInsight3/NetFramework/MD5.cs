public class MD5 : HashAlgorithm, ICryptoTransform, System.IDisposable
{

	// Methods
	public static MD5 Create() {}
	public static MD5 Create(string algName) {}
	public byte[] ComputeHash(System.IO.Stream inputStream) {}
	public byte[] ComputeHash(byte[] buffer) {}
	public byte[] ComputeHash(byte[] buffer, int offset, int count) {}
	public virtual int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) {}
	public virtual byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) {}
	public void Clear() {}
	public abstract virtual void Initialize() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int HashSize { get{} }
	public byte[] Hash { get{} }
	public int InputBlockSize { get{} }
	public int OutputBlockSize { get{} }
	public bool CanTransformMultipleBlocks { get{} }
	public bool CanReuseTransform { get{} }
}

