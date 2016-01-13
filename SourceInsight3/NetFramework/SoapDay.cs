public class SoapDay : ISoapXsd
{

	// Constructors
	public SoapDay() {}
	public SoapDay(System.DateTime value) {}

	// Methods
	public virtual string GetXsdType() {}
	public virtual string ToString() {}
	public static SoapDay Parse(string value) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string XsdType { get{} }
	public System.DateTime Value { get{} set{} }
}

