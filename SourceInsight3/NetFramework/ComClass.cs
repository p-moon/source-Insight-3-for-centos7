public class ComClass
{

	// Constructors
	public ComClass() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string ClsId { get{} }
	public string Description { get{} }
	public string ProgId { get{} }
	public string ThreadingModel { get{} }
	public string TlbId { get{} }
	public string XmlClsId { get{} set{} }
	public string XmlDescription { get{} set{} }
	public string XmlProgId { get{} set{} }
	public string XmlThreadingModel { get{} set{} }
	public string XmlTlbId { get{} set{} }
}

