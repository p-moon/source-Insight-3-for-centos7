public class PrinterResolutionCollection : System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public PrinterResolutionCollection(PrinterResolution[] array) {}

	// Methods
	public System.Collections.IEnumerator GetEnumerator() {}
	public void CopyTo(PrinterResolution[] printerResolutions, int index) {}
	public int Add(PrinterResolution printerResolution) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public PrinterResolution Item { get{} }
}

