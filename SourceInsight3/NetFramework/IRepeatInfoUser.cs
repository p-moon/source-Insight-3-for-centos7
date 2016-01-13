public interface IRepeatInfoUser
{

	// Methods
	public abstract virtual Style GetItemStyle(ListItemType itemType, int repeatIndex) {}
	public abstract virtual void RenderItem(ListItemType itemType, int repeatIndex, RepeatInfo repeatInfo, System.Web.UI.HtmlTextWriter writer) {}

	// Properties
	public bool HasHeader { get{} }
	public bool HasFooter { get{} }
	public bool HasSeparators { get{} }
	public int RepeatedItemCount { get{} }
}

