public class DataBinder
{

	// Constructors
	public DataBinder() {}

	// Methods
	public static object Eval(object container, string expression) {}
	public static string Eval(object container, string expression, string format) {}
	public static object GetPropertyValue(object container, string propName) {}
	public static string GetPropertyValue(object container, string propName, string format) {}
	public static object GetIndexedPropertyValue(object container, string expr) {}
	public static string GetIndexedPropertyValue(object container, string propName, string format) {}
	public static object GetDataItem(object container) {}
	public static object GetDataItem(object containerout , System.Boolean& foundDataItem) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

