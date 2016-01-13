public class RepeatInfo
{

	// Constructors
	public RepeatInfo() {}

	// Methods
	public void RenderRepeater(System.Web.UI.HtmlTextWriter writer, IRepeatInfoUser user, Style controlStyle, WebControl baseControl) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Caption { get{} set{} }
	public TableCaptionAlign CaptionAlign { get{} set{} }
	public bool OuterTableImplied { get{} set{} }
	public int RepeatColumns { get{} set{} }
	public RepeatDirection RepeatDirection { get{} set{} }
	public RepeatLayout RepeatLayout { get{} set{} }
	public bool UseAccessibleHeader { get{} set{} }
}

