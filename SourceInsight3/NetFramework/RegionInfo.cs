public class RegionInfo
{

	// Constructors
	public RegionInfo(string name) {}
	public RegionInfo(int culture) {}

	// Methods
	public virtual bool Equals(object value) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Properties
	public RegionInfo CurrentRegion { get{} }
	public string Name { get{} }
	public string EnglishName { get{} }
	public string DisplayName { get{} }
	public string NativeName { get{} }
	public string TwoLetterISORegionName { get{} }
	public string ThreeLetterISORegionName { get{} }
	public bool IsMetric { get{} }
	public int GeoId { get{} }
	public string ThreeLetterWindowsRegionName { get{} }
	public string CurrencyEnglishName { get{} }
	public string CurrencyNativeName { get{} }
	public string CurrencySymbol { get{} }
	public string ISOCurrencySymbol { get{} }
}

