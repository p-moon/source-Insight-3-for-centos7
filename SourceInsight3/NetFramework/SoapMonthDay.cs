public class SoapMonthDay : ISoapXsd
{

	// Constructors
	public SoapMonthDay() {}
	public SoapMonthDay(System.DateTime value) {}

	// Methods
	public virtual string GetXsdType() {}
	public virtual string ToString() {}
	public static SoapMonthDay Parse(string value) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string XsdType { get{} }
	public System.DateTime Value { get{} set{} }
}

