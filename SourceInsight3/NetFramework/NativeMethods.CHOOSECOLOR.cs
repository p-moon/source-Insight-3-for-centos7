public class CHOOSECOLOR
{

	// Constructors
	public CHOOSECOLOR() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int lStructSize;
	public System.IntPtr hwndOwner;
	public System.IntPtr hInstance;
	public int rgbResult;
	public System.IntPtr lpCustColors;
	public int Flags;
	public System.IntPtr lCustData;
	public WndProc lpfnHook;
	public string lpTemplateName;
}

