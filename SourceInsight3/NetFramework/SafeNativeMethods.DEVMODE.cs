public class DEVMODE
{

	// Constructors
	public DEVMODE() {}

	// Methods
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public string dmDeviceName;
	public short dmSpecVersion;
	public short dmDriverVersion;
	public short dmSize;
	public short dmDriverExtra;
	public int dmFields;
	public short dmOrientation;
	public short dmPaperSize;
	public short dmPaperLength;
	public short dmPaperWidth;
	public short dmScale;
	public short dmCopies;
	public short dmDefaultSource;
	public short dmPrintQuality;
	public short dmColor;
	public short dmDuplex;
	public short dmYResolution;
	public short dmTTOption;
	public short dmCollate;
	public string dmFormName;
	public short dmLogPixels;
	public int dmBitsPerPel;
	public int dmPelsWidth;
	public int dmPelsHeight;
	public int dmDisplayFlags;
	public int dmDisplayFrequency;
	public int dmICMMethod;
	public int dmICMIntent;
	public int dmMediaType;
	public int dmDitherType;
	public int dmICCManufacturer;
	public int dmICCModel;
	public int dmPanningWidth;
	public int dmPanningHeight;
}

