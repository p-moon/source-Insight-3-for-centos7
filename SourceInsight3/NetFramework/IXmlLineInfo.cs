public interface IXmlLineInfo
{

	// Methods
	public abstract virtual bool HasLineInfo() {}

	// Properties
	public int LineNumber { get{} }
	public int LinePosition { get{} }
}

