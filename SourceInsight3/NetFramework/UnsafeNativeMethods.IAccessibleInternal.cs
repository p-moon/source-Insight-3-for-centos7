public interface IAccessibleInternal
{

	// Methods
	public abstract virtual void accSelect(int flagsSelect, object varChild) {}
	public abstract virtual void accLocation(out System.Int32& pxLeftout , System.Int32& pyTopout , System.Int32& pcxWidthout , System.Int32& pcyHeight, object varChild) {}
	public abstract virtual object accNavigate(int navDir, object varStart) {}
	public abstract virtual object accHitTest(int xLeft, int yTop) {}
	public abstract virtual void accDoDefaultAction(object varChild) {}
}

