public class KeyInfoClause
{

	// Methods
	public abstract virtual System.Xml.XmlElement GetXml() {}
	public abstract virtual void LoadXml(System.Xml.XmlElement element) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

