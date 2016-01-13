public class DoubleConverter : BaseNumberConverter
{

	// Constructors
	public DoubleConverter() {}

	// Methods
	public virtual bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) {}
	public virtual object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) {}
	public virtual object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType) {}
	public virtual bool CanConvertTo(ITypeDescriptorContext context, Type t) {}
	public bool CanConvertFrom(Type sourceType) {}
	public bool CanConvertTo(Type destinationType) {}
	public object ConvertFrom(object value) {}
	public object ConvertFromInvariantString(string text) {}
	public virtual object CreateInstance(ITypeDescriptorContext context, System.Collections.IDictionary propertyValues) {}
	public virtual bool GetCreateInstanceSupported(ITypeDescriptorContext context) {}
	public virtual PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, System.Attribute[] attributes) {}
	public virtual bool GetPropertiesSupported(ITypeDescriptorContext context) {}
	public virtual StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) {}
	public virtual bool GetStandardValuesExclusive(ITypeDescriptorContext context) {}
	public virtual bool GetStandardValuesSupported(ITypeDescriptorContext context) {}
	public virtual bool IsValid(ITypeDescriptorContext context, object value) {}
	public object ConvertFromInvariantString(ITypeDescriptorContext context, string text) {}
	public object ConvertFromString(string text) {}
	public object ConvertFromString(ITypeDescriptorContext context, string text) {}
	public object ConvertFromString(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, string text) {}
	public object ConvertTo(object value, Type destinationType) {}
	public string ConvertToInvariantString(object value) {}
	public string ConvertToInvariantString(ITypeDescriptorContext context, object value) {}
	public string ConvertToString(object value) {}
	public string ConvertToString(ITypeDescriptorContext context, object value) {}
	public string ConvertToString(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) {}
	public object CreateInstance(System.Collections.IDictionary propertyValues) {}
	public bool GetCreateInstanceSupported() {}
	public PropertyDescriptorCollection GetProperties(object value) {}
	public PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value) {}
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

