public class CodeChecksumPragma : CodeDirective
{

	// Constructors
	public CodeChecksumPragma() {}
	public CodeChecksumPragma(string fileName, System.Guid checksumAlgorithmId, byte[] checksumData) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string FileName { get{} set{} }
	public System.Guid ChecksumAlgorithmId { get{} set{} }
	public byte[] ChecksumData { get{} set{} }
	public System.Collections.IDictionary UserData { get{} }
}

