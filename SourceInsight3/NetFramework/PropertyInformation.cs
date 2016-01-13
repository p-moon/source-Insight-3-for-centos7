public class PropertyInformation
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Name { get{} }
	public object Value { get{} set{} }
	public object DefaultValue { get{} }
	public PropertyValueOrigin ValueOrigin { get{} }
	public bool IsModified { get{} }
	public bool IsKey { get{} }
	public bool IsRequired { get{} }
	public bool IsLocked { get{} }
	public string Source { get{} }
	public int LineNumber { get{} }
	public Type Type { get{} }
	public ConfigurationValidatorBase Validator { get{} }
	public System.ComponentModel.TypeConverter Converter { get{} }
	public string Description { get{} }
}

