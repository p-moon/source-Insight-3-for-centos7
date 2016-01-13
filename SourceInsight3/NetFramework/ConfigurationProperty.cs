public class ConfigurationProperty
{

	// Constructors
	public ConfigurationProperty(string name, Type type, object defaultValue, ConfigurationPropertyOptions options) {}
	public ConfigurationProperty(string name, Type type, object defaultValue, System.ComponentModel.TypeConverter typeConverter, ConfigurationValidatorBase validator, ConfigurationPropertyOptions options) {}
	public ConfigurationProperty(string name, Type type) {}
	public ConfigurationProperty(string name, Type type, object defaultValue) {}
	public ConfigurationProperty(string name, Type type, object defaultValue, System.ComponentModel.TypeConverter typeConverter, ConfigurationValidatorBase validator, ConfigurationPropertyOptions options, string description) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Name { get{} }
	public string Description { get{} }
	public Type Type { get{} }
	public object DefaultValue { get{} }
	public bool IsRequired { get{} }
	public bool IsKey { get{} }
	public bool IsDefaultCollection { get{} }
	public System.ComponentModel.TypeConverter Converter { get{} }
	public ConfigurationValidatorBase Validator { get{} }
}

