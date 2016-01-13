public interface ISnapinAbout
{

	// Methods
	public abstract virtual void GetSnapinDescription(out System.IntPtr& lpDescription) {}
	public abstract virtual void GetProvider(out System.IntPtr& pName) {}
	public abstract virtual void GetSnapinVersion(out System.IntPtr& lpVersion) {}
	public abstract virtual void GetSnapinImage(out System.IntPtr& hAppIcon) {}
	public abstract virtual void GetStaticFolderImage(out System.IntPtr& hSmallImageout , System.IntPtr& hSmallImageOpenout , System.IntPtr& hLargeImageout , System.Int32& cMask) {}
}

