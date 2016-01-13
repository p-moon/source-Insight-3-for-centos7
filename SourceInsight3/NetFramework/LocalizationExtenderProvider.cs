public class LocalizationExtenderProvider : System.ComponentModel.IExtenderProvider, System.IDisposable
{

	// Constructors
	public LocalizationExtenderProvider(System.ComponentModel.ISite serviceProvider, System.ComponentModel.IComponent baseComponent) {}

	// Methods
	public System.Globalization.CultureInfo GetLanguage(object o) {}
	public System.Globalization.CultureInfo GetLoadLanguage(object o) {}
	public bool GetLocalizable(object o) {}
	public void SetLanguage(object o, System.Globalization.CultureInfo language) {}
	public void SetLocalizable(object o, bool localizable) {}
	public bool ShouldSerializeLanguage(object o) {}
	public void ResetLanguage(object o) {}
	public virtual void Dispose() {}
	public virtual bool CanExtend(object o) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

