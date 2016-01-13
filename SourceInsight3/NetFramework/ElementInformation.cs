public class ElementInformation
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public PropertyInformationCollection Properties { get{} }
	public bool IsPresent { get{} }
	public bool IsLocked { get{} }
	public bool IsCollection { get{} }
	public string Source { get{} }
	public int LineNumber { get{} }
	public Type Type { get{} }
	public ConfigurationValidatorBase Validator { get{} }
	public System.Collections.ICollection Errors { get{} }
}

