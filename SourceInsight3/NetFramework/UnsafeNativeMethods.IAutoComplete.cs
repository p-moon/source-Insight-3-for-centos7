public interface IAutoComplete
{

	// Methods
	public abstract virtual int Init(System.Runtime.InteropServices.HandleRef hwndEdit, System.Runtime.InteropServices.ComTypes.IEnumString punkACL, string pwszRegKeyPath, string pwszQuickComplete) {}
	public abstract virtual void Enable(bool fEnable) {}
}

