public class SpecialFolder : Enum, IComparable, IFormattable, IConvertible
{

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public virtual string ToString(string format, IFormatProvider provider) {}
	public virtual int CompareTo(object target) {}
	public virtual string ToString(IFormatProvider provider) {}
	public virtual TypeCode GetTypeCode() {}
	public string ToString(string format) {}
	public Type GetType() {}

	// Fields
	public int value__;
	public SpecialFolder ApplicationData;
	public SpecialFolder CommonApplicationData;
	public SpecialFolder LocalApplicationData;
	public SpecialFolder Cookies;
	public SpecialFolder Desktop;
	public SpecialFolder Favorites;
	public SpecialFolder History;
	public SpecialFolder InternetCache;
	public SpecialFolder Programs;
	public SpecialFolder MyComputer;
	public SpecialFolder MyMusic;
	public SpecialFolder MyPictures;
	public SpecialFolder Recent;
	public SpecialFolder SendTo;
	public SpecialFolder StartMenu;
	public SpecialFolder Startup;
	public SpecialFolder System;
	public SpecialFolder Templates;
	public SpecialFolder DesktopDirectory;
	public SpecialFolder Personal;
	public SpecialFolder MyDocuments;
	public SpecialFolder ProgramFiles;
	public SpecialFolder CommonProgramFiles;
}

