public class DynamicILInfo
{

	// Methods
	public void SetCode(byte[] code, int maxStackSize) {}
	public void SetCode(System.Byte* code, int codeSize, int maxStackSize) {}
	public void SetExceptions(byte[] exceptions) {}
	public void SetExceptions(System.Byte* exceptions, int exceptionsSize) {}
	public void SetLocalSignature(byte[] localSignature) {}
	public void SetLocalSignature(System.Byte* localSignature, int signatureSize) {}
	public int GetTokenFor(System.RuntimeMethodHandle method) {}
	public int GetTokenFor(DynamicMethod method) {}
	public int GetTokenFor(System.RuntimeMethodHandle method, System.RuntimeTypeHandle contextType) {}
	public int GetTokenFor(System.RuntimeFieldHandle field) {}
	public int GetTokenFor(System.RuntimeTypeHandle type) {}
	public int GetTokenFor(string literal) {}
	public int GetTokenFor(byte[] signature) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public DynamicMethod DynamicMethod { get{} }
}

