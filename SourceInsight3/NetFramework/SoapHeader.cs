public class SoapHeader
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string EncodedMustUnderstand { get{} set{} }
	public string EncodedMustUnderstand12 { get{} set{} }
	public bool MustUnderstand { get{} set{} }
	public string Actor { get{} set{} }
	public string Role { get{} set{} }
	public bool DidUnderstand { get{} set{} }
	public string EncodedRelay { get{} set{} }
	public bool Relay { get{} set{} }
}

