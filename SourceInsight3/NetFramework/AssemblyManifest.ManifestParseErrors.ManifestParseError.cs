public class ManifestParseError
{

	// Constructors
	public ManifestParseError() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public uint StartLine;
	public uint nStartColumn;
	public uint cCharacterCount;
	public int hr;
	public string ErrorStatusHostFile;
	public uint ParameterCount;
	public string[] Parameters;
}

