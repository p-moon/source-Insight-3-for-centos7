public interface IAutoComplete2
{

	// Methods
	public abstract virtual int Init(System.Runtime.InteropServices.HandleRef hwndEdit, System.Runtime.InteropServices.ComTypes.IEnumString punkACL, string pwszRegKeyPath, string pwszQuickComplete) {}
	public abstract virtual void Enable(bool fEnable) {}
	public abstract virtual int SetOptions(int dwFlag) {}
	public abstract virtual void GetOptions(out System.IntPtr pdwFlag) {}
}

