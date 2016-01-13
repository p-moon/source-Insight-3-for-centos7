public class TreeNodeConverter : System.ComponentModel.TypeConverter
{

	// Constructors
	public TreeNodeConverter() {}

	// Methods
	public virtual bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, Type destinationType) {}
	public virtual object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType) {}
	public bool CanConvertFrom(Type sourceType) {}
	public bool CanConvertTo(Type destinationType) {}
	public object ConvertFrom(object value) {}
	public virtual object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) {}
	public object ConvertFromInvariantString(string text) {}
	public virtual object CreateInstance(System.ComponentModel.ITypeDescriptorContext context, System.Collections.IDictionary propertyValues) {}
	public virtual bool GetCreateInstanceSupported(System.ComponentModel.ITypeDescriptorContext context) {}
	public virtual System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes) {}
	public virtual bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context) {}
	public virtual System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) {}
	public virtual bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) {}
	public virtual bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) {}
	public virtual bool IsValid(System.ComponentModel.ITypeDescriptorContext context, object value) {}
	public virtual bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, Type sourceType) {}
	public object ConvertFromInvariantString(System.ComponentModel.ITypeDescriptorContext context, string text) {}
	public object ConvertFromString(string text) {}
	public object ConvertFromString(System.ComponentModel.ITypeDescriptorContext context, string text) {}
	public object ConvertFromString(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, string text) {}
	public object ConvertTo(object value, Type destinationType) {}
	public string ConvertToInvariantString(object value) {}
	public string ConvertToInvariantString(System.ComponentModel.ITypeDescriptorContext context, object value) {}
	public string ConvertToString(object value) {}
	public string ConvertToString(System.ComponentModel.ITypeDescriptorContext context, object value) {}
	public string ConvertToString(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) {}
	public object CreateInstance(System.Collections.IDictionary propertyValues) {}
	public bool GetCreateInstanceSupported() {}
	public System.ComponentModel.PropertyDescriptorCollection GetProperties(object value) {}
	public System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value) {}
	public bool GetPropertiesSupported() {}
	public System.Collections.ICollection GetStandardValues() {}
	public bool GetStandardValuesExclusive() {}
	public bool GetStandardValuesSupported() {}
	public bool IsValid(object value) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

