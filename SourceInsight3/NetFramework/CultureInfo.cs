public class CultureInfo : System.ICloneable, System.IFormatProvider
{

	// Constructors
	public CultureInfo(string name) {}
	public CultureInfo(string name, bool useUserOverride) {}
	public CultureInfo(int culture) {}
	public CultureInfo(int culture, bool useUserOverride) {}

	// Methods
	public static CultureInfo CreateSpecificCulture(string name) {}
	public static CultureInfo[] GetCultures(CultureTypes types) {}
	public virtual bool Equals(object value) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public virtual object GetFormat(Type formatType) {}
	public void ClearCachedData() {}
	public CultureInfo GetConsoleFallbackUICulture() {}
	public virtual object Clone() {}
	public static CultureInfo ReadOnly(CultureInfo ci) {}
	public static CultureInfo GetCultureInfo(int culture) {}
	public static CultureInfo GetCultureInfo(string name) {}
	public static CultureInfo GetCultureInfo(string name, string altName) {}
	public static CultureInfo GetCultureInfoByIetfLanguageTag(string name) {}
	public Type GetType() {}

	// Properties
	public CultureInfo CurrentCulture { get{} }
	public CultureInfo CurrentUICulture { get{} }
	public CultureInfo InstalledUICulture { get{} }
	public CultureInfo InvariantCulture { get{} }
	public CultureInfo Parent { get{} }
	public int LCID { get{} }
	public int KeyboardLayoutId { get{} }
	public string Name { get{} }
	public string IetfLanguageTag { get{} }
	public string DisplayName { get{} }
	public string NativeName { get{} }
	public string EnglishName { get{} }
	public string TwoLetterISOLanguageName { get{} }
	public string ThreeLetterISOLanguageName { get{} }
	public string ThreeLetterWindowsLanguageName { get{} }
	public CompareInfo CompareInfo { get{} }
	public TextInfo TextInfo { get{} }
	public bool IsNeutralCulture { get{} }
	public CultureTypes CultureTypes { get{} }
	public NumberFormatInfo NumberFormat { get{} set{} }
	public DateTimeFormatInfo DateTimeFormat { get{} set{} }
	public Calendar Calendar { get{} }
	public Calendar[] OptionalCalendars { get{} }
	public bool UseUserOverride { get{} }
	public bool IsReadOnly { get{} }
}

