public class BrowseInfos : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
{

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public virtual string ToString(string format, System.IFormatProvider provider) {}
	public virtual int CompareTo(object target) {}
	public virtual string ToString(System.IFormatProvider provider) {}
	public virtual System.TypeCode GetTypeCode() {}
	public string ToString(string format) {}
	public Type GetType() {}

	// Fields
	public int value__;
	public BrowseInfos ReturnOnlyFSDirs;
	public BrowseInfos DontGoBelowDomain;
	public BrowseInfos StatusText;
	public BrowseInfos ReturnFSAncestors;
	public BrowseInfos EditBox;
	public BrowseInfos Validate;
	public BrowseInfos NewDialogStyle;
	public BrowseInfos UseNewUI;
	public BrowseInfos AllowUrls;
	public BrowseInfos BrowseForComputer;
	public BrowseInfos BrowseForPrinter;
	public BrowseInfos BrowseForEverything;
	public BrowseInfos ShowShares;
}

