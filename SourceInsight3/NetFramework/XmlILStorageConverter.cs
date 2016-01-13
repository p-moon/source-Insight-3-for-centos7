public class XmlILStorageConverter
{

	// Methods
	public static System.Xml.Schema.XmlAtomicValue StringToAtomicValue(string value, int index, XmlQueryRuntime runtime) {}
	public static System.Xml.Schema.XmlAtomicValue DecimalToAtomicValue(decimal value, int index, XmlQueryRuntime runtime) {}
	public static System.Xml.Schema.XmlAtomicValue Int64ToAtomicValue(long value, int index, XmlQueryRuntime runtime) {}
	public static System.Xml.Schema.XmlAtomicValue Int32ToAtomicValue(int value, int index, XmlQueryRuntime runtime) {}
	public static System.Xml.Schema.XmlAtomicValue BooleanToAtomicValue(bool value, int index, XmlQueryRuntime runtime) {}
	public static System.Xml.Schema.XmlAtomicValue DoubleToAtomicValue(double value, int index, XmlQueryRuntime runtime) {}
	public static System.Xml.Schema.XmlAtomicValue SingleToAtomicValue(float value, int index, XmlQueryRuntime runtime) {}
	public static System.Xml.Schema.XmlAtomicValue DateTimeToAtomicValue(System.DateTime value, int index, XmlQueryRuntime runtime) {}
	public static System.Xml.Schema.XmlAtomicValue XmlQualifiedNameToAtomicValue(System.Xml.XmlQualifiedName value, int index, XmlQueryRuntime runtime) {}
	public static System.Xml.Schema.XmlAtomicValue TimeSpanToAtomicValue(System.TimeSpan value, int index, XmlQueryRuntime runtime) {}
	public static System.Xml.Schema.XmlAtomicValue BytesToAtomicValue(byte[] value, int index, XmlQueryRuntime runtime) {}
	public static IList<System.Xml.XPath.XPathItem> NavigatorsToItems(IList<System.Xml.XPath.XPathNavigator> listNavigators) {}
	public static IList<System.Xml.XPath.XPathNavigator> ItemsToNavigators(IList<System.Xml.XPath.XPathItem> listItems) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

