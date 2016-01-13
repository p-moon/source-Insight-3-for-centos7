public class PrinterSettings : System.ICloneable
{

	// Constructors
	public PrinterSettings() {}

	// Methods
	public bool IsDirectPrintingSupported(System.Drawing.Imaging.ImageFormat imageFormat) {}
	public bool IsDirectPrintingSupported(System.Drawing.Image image) {}
	public virtual object Clone() {}
	public System.Drawing.Graphics CreateMeasurementGraphics() {}
	public System.Drawing.Graphics CreateMeasurementGraphics(bool honorOriginAtMargins) {}
	public System.Drawing.Graphics CreateMeasurementGraphics(PageSettings pageSettings) {}
	public System.Drawing.Graphics CreateMeasurementGraphics(PageSettings pageSettings, bool honorOriginAtMargins) {}
	public System.IntPtr GetHdevmode() {}
	public System.IntPtr GetHdevmode(PageSettings pageSettings) {}
	public System.IntPtr GetHdevnames() {}
	public void SetHdevmode(System.IntPtr hdevmode) {}
	public void SetHdevnames(System.IntPtr hdevnames) {}
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool CanDuplex { get{} }
	public short Copies { get{} set{} }
	public bool Collate { get{} set{} }
	public PageSettings DefaultPageSettings { get{} }
	public Duplex Duplex { get{} set{} }
	public int FromPage { get{} set{} }
	public StringCollection InstalledPrinters { get{} }
	public bool IsDefaultPrinter { get{} }
	public bool IsPlotter { get{} }
	public bool IsValid { get{} }
	public int LandscapeAngle { get{} }
	public int MaximumCopies { get{} }
	public int MaximumPage { get{} set{} }
	public int MinimumPage { get{} set{} }
	public string PrintFileName { get{} set{} }
	public PaperSizeCollection PaperSizes { get{} }
	public PaperSourceCollection PaperSources { get{} }
	public PrintRange PrintRange { get{} set{} }
	public bool PrintToFile { get{} set{} }
	public string PrinterName { get{} set{} }
	public PrinterResolutionCollection PrinterResolutions { get{} }
	public bool SupportsColor { get{} }
	public int ToPage { get{} set{} }
}

