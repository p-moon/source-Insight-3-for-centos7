public interface IAdsPropertyValue
{

	// Methods
	public abstract virtual void Clear() {}

	// Properties
	public int ADsType { get{} set{} }
	public string DNString { get{} set{} }
	public string CaseExactString { get{} set{} }
	public string CaseIgnoreString { get{} set{} }
	public string PrintableString { get{} set{} }
	public string NumericString { get{} set{} }
	public bool Boolean { get{} set{} }
	public int Integer { get{} set{} }
	public object OctetString { get{} set{} }
	public object SecurityDescriptor { get{} set{} }
	public object LargeInteger { get{} set{} }
	public object UTCTime { get{} set{} }
}

