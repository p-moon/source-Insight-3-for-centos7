public class tagQACONTAINER
{

	// Constructors
	public tagQACONTAINER() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int cbSize;
	public IOleClientSite pClientSite;
	public object pAdviseSink;
	public IPropertyNotifySink pPropertyNotifySink;
	public object pUnkEventSink;
	public int dwAmbientFlags;
	public uint colorFore;
	public uint colorBack;
	public object pFont;
	public object pUndoMgr;
	public int dwAppearance;
	public int lcid;
	public System.IntPtr hpal;
	public object pBindHost;
}

