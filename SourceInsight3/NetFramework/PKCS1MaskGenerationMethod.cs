public class PKCS1MaskGenerationMethod : MaskGenerationMethod
{

	// Constructors
	public PKCS1MaskGenerationMethod() {}

	// Methods
	public virtual byte[] GenerateMask(byte[] rgbSeed, int cbReturn) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string HashName { get{} set{} }
}

