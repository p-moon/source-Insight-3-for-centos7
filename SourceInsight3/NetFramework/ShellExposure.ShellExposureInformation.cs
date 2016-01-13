public class ShellExposureInformation
{

	// Methods
	public static ShellExposureInformation CreateShellExposureInformation(DefinitionIdentity subscriptionIdentity) {}
	public static ShellExposureInformation CreateShellExposureInformation(string publisher, string product, string shortcutAppId) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string ApplicationFolderPath { get{} }
	public string ApplicationShortcutPath { get{} }
	public string SupportShortcutPath { get{} }
	public string ARPDisplayName { get{} }
	public string AppVendor { get{} }
	public string AppProduct { get{} }
	public string AppSupportShortcut { get{} }
	public string ShortcutAppId { get{} set{} }
}

