public interface IPictureDisp
{

	// Methods
	public abstract virtual void Render(System.IntPtr hdc, int x, int y, int cx, int cy, int xSrc, int ySrc, int cxSrc, int cySrc) {}

	// Properties
	public System.IntPtr Handle { get{} }
	public System.IntPtr HPal { get{} }
	public short PictureType { get{} }
	public int Width { get{} }
	public int Height { get{} }
}

