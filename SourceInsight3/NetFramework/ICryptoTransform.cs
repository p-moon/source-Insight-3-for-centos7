public interface ICryptoTransform : System.IDisposable
{

	// Methods
	public abstract virtual int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) {}
	public abstract virtual byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) {}

	// Properties
	public int InputBlockSize { get{} }
	public int OutputBlockSize { get{} }
	public bool CanTransformMultipleBlocks { get{} }
	public bool CanReuseTransform { get{} }
}

