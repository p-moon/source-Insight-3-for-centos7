public class SoapTransportImporter
{

	// Methods
	public abstract virtual bool IsSupportedTransport(string transport) {}
	public abstract virtual void ImportClass() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public SoapProtocolImporter ImportContext { get{} set{} }
}

