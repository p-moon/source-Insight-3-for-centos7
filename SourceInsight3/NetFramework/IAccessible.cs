public interface IAccessible
{

	// Methods
	public abstract virtual void accSelect(int flagsSelect, object varChild) {}
	public abstract virtual void accLocation(out System.Int32& pxLeftout , System.Int32& pyTopout , System.Int32& pcxWidthout , System.Int32& pcyHeight, object varChild) {}
	public abstract virtual object accNavigate(int navDir, object varStart) {}
	public abstract virtual object accHitTest(int xLeft, int yTop) {}
	public abstract virtual void accDoDefaultAction(object varChild) {}

	// Properties
	public object accParent { get{} }
	public int accChildCount { get{} }
	public object accChild { get{} }
	public string accName { get{} set{} }
	public string accValue { get{} set{} }
	public string accDescription { get{} }
	public object accRole { get{} }
	public object accState { get{} }
	public string accHelp { get{} }
	public int accHelpTopic { get{} }
	public string accKeyboardShortcut { get{} }
	public object accFocus { get{} }
	public object accSelection { get{} }
	public string accDefaultAction { get{} }
}

