public class PageSettings : System.ICloneable
{

	// Constructors
	public PageSettings() {}
	public PageSettings(PrinterSettings printerSettings) {}

	// Methods
	public virtual object Clone() {}
	public void CopyToHdevmode(System.IntPtr hdevmode) {}
	public void SetHdevmode(System.IntPtr hdevmode) {}
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Drawing.Rectangle Bounds { get{} }
	public bool Color { get{} set{} }
	public float HardMarginX { get{} }
	public float HardMarginY { get{} }
	public bool Landscape { get{} set{} }
	public Margins Margins { get{} set{} }
	public PaperSize PaperSize { get{} set{} }
	public PaperSource PaperSource { get{} set{} }
	public System.Drawing.RectangleF PrintableArea { get{} }
	public PrinterResolution PrinterResolution { get{} set{} }
	public PrinterSettings PrinterSettings { get{} set{} }
}

