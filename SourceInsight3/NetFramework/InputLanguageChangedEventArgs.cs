public class InputLanguageChangedEventArgs : System.EventArgs
{

	// Constructors
	public InputLanguageChangedEventArgs(System.Globalization.CultureInfo culture, byte charSet) {}
	public InputLanguageChangedEventArgs(InputLanguage inputLanguage, byte charSet) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public InputLanguage InputLanguage { get{} }
	public System.Globalization.CultureInfo Culture { get{} }
	public byte CharSet { get{} }
}

