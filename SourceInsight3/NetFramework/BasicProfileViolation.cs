public class BasicProfileViolation
{

	// Methods
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Web.Services.WsiProfiles Claims { get{} }
	public string Details { get{} }
	public System.Collections.Specialized.StringCollection Elements { get{} }
	public string NormativeStatement { get{} }
	public string Recommendation { get{} }
}

