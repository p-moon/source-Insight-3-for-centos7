public class CultureAndRegionInfoBuilder
{

	// Constructors
	public CultureAndRegionInfoBuilder(string cultureName, CultureAndRegionModifiers flags) {}

	// Methods
	public void LoadDataFromCultureInfo(CultureInfo culture) {}
	public void LoadDataFromRegionInfo(RegionInfo region) {}
	public void Save(string filename) {}
	public static CultureAndRegionInfoBuilder CreateFromLdml(string xmlFileName) {}
	public void Register() {}
	public static void Unregister(string cultureName) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CultureInfo Parent { get{} set{} }
	public DateTimeFormatInfo GregorianDateTimeFormat { get{} set{} }
	public Calendar[] AvailableCalendars { get{} set{} }
	public CompareInfo CompareInfo { get{} set{} }
	public string CultureEnglishName { get{} set{} }
	public int KeyboardLayoutId { get{} set{} }
	public CultureTypes CultureTypes { get{} }
	public string CultureName { get{} }
	public string CultureNativeName { get{} set{} }
	public NumberFormatInfo NumberFormat { get{} set{} }
	public TextInfo TextInfo { get{} set{} }
	public string ThreeLetterISOLanguageName { get{} set{} }
	public string ThreeLetterWindowsLanguageName { get{} set{} }
	public string TwoLetterISOLanguageName { get{} set{} }
	public bool IsRightToLeft { get{} set{} }
	public string RegionName { get{} }
	public string RegionEnglishName { get{} set{} }
	public string RegionNativeName { get{} set{} }
	public string ThreeLetterISORegionName { get{} set{} }
	public string TwoLetterISORegionName { get{} set{} }
	public string ThreeLetterWindowsRegionName { get{} set{} }
	public string ISOCurrencySymbol { get{} set{} }
	public string IetfLanguageTag { get{} set{} }
	public bool IsMetric { get{} set{} }
	public int GeoId { get{} set{} }
	public string CurrencyNativeName { get{} set{} }
	public string CurrencyEnglishName { get{} set{} }
	public int LCID { get{} }
	public CultureInfo ConsoleFallbackUICulture { get{} set{} }
}

