public class AssemblyHash : System.ValueType, System.ICloneable
{

	// Constructors
	public AssemblyHash(byte[] value) {}
	public AssemblyHash(AssemblyHashAlgorithm algorithm, byte[] value) {}

	// Methods
	public byte[] GetValue() {}
	public void SetValue(byte[] value) {}
	public virtual object Clone() {}
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public AssemblyHash Empty;

	// Properties
	public AssemblyHashAlgorithm Algorithm { get{} set{} }
}

