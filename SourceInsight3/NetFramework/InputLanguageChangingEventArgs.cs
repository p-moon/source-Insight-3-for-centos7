public class InputLanguageChangingEventArgs : System.ComponentModel.CancelEventArgs
{

	// Constructors
	public InputLanguageChangingEventArgs(System.Globalization.CultureInfo culture, bool sysCharSet) {}
	public InputLanguageChangingEventArgs(InputLanguage inputLanguage, bool sysCharSet) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public InputLanguage InputLanguage { get{} }
	public System.Globalization.CultureInfo Culture { get{} }
	public bool SysCharSet { get{} }
	public bool Cancel { get{} set{} }
}

