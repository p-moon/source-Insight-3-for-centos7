public class SoapYear : ISoapXsd
{

	// Constructors
	public SoapYear() {}
	public SoapYear(System.DateTime value) {}
	public SoapYear(System.DateTime value, int sign) {}

	// Methods
	public virtual string GetXsdType() {}
	public virtual string ToString() {}
	public static SoapYear Parse(string value) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string XsdType { get{} }
	public System.DateTime Value { get{} set{} }
	public int Sign { get{} set{} }
}

