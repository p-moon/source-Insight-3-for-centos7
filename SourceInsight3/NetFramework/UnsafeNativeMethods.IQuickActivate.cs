public interface IQuickActivate
{

	// Methods
	public abstract virtual void QuickActivate(tagQACONTAINER pQaContainerout , tagQACONTROL pQaControl) {}
	public abstract virtual void SetContentExtent(tagSIZEL pSizel) {}
	public abstract virtual void GetContentExtent(out tagSIZEL pSizel) {}
}

