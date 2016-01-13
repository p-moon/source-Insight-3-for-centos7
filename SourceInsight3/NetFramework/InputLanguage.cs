public class InputLanguage
{

	// Methods
	public virtual bool Equals(object value) {}
	public static InputLanguage FromCulture(System.Globalization.CultureInfo culture) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public System.Globalization.CultureInfo Culture { get{} }
	public InputLanguage CurrentInputLanguage { get{} set{} }
	public InputLanguage DefaultInputLanguage { get{} }
	public System.IntPtr Handle { get{} }
	public InputLanguageCollection InstalledInputLanguages { get{} }
	public string LayoutName { get{} }
}

