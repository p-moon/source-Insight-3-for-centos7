public class SoapDate : ISoapXsd
{

	// Constructors
	public SoapDate() {}
	public SoapDate(System.DateTime value) {}
	public SoapDate(System.DateTime value, int sign) {}

	// Methods
	public virtual string GetXsdType() {}
	public virtual string ToString() {}
	public static SoapDate Parse(string value) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string XsdType { get{} }
	public System.DateTime Value { get{} set{} }
	public int Sign { get{} set{} }
}

