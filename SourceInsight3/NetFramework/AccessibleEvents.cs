public class AccessibleEvents : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
{

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public virtual string ToString(string format, System.IFormatProvider provider) {}
	public virtual int CompareTo(object target) {}
	public virtual string ToString(System.IFormatProvider provider) {}
	public virtual System.TypeCode GetTypeCode() {}
	public string ToString(string format) {}
	public Type GetType() {}

	// Fields
	public int value__;
	public AccessibleEvents SystemSound;
	public AccessibleEvents SystemAlert;
	public AccessibleEvents SystemForeground;
	public AccessibleEvents SystemMenuStart;
	public AccessibleEvents SystemMenuEnd;
	public AccessibleEvents SystemMenuPopupStart;
	public AccessibleEvents SystemMenuPopupEnd;
	public AccessibleEvents SystemCaptureStart;
	public AccessibleEvents SystemCaptureEnd;
	public AccessibleEvents SystemMoveSizeStart;
	public AccessibleEvents SystemMoveSizeEnd;
	public AccessibleEvents SystemContextHelpStart;
	public AccessibleEvents SystemContextHelpEnd;
	public AccessibleEvents SystemDragDropStart;
	public AccessibleEvents SystemDragDropEnd;
	public AccessibleEvents SystemDialogStart;
	public AccessibleEvents SystemDialogEnd;
	public AccessibleEvents SystemScrollingStart;
	public AccessibleEvents SystemScrollingEnd;
	public AccessibleEvents SystemSwitchStart;
	public AccessibleEvents SystemSwitchEnd;
	public AccessibleEvents SystemMinimizeStart;
	public AccessibleEvents SystemMinimizeEnd;
	public AccessibleEvents Create;
	public AccessibleEvents Destroy;
	public AccessibleEvents Show;
	public AccessibleEvents Hide;
	public AccessibleEvents Reorder;
	public AccessibleEvents Focus;
	public AccessibleEvents Selection;
	public AccessibleEvents SelectionAdd;
	public AccessibleEvents SelectionRemove;
	public AccessibleEvents SelectionWithin;
	public AccessibleEvents StateChange;
	public AccessibleEvents LocationChange;
	public AccessibleEvents NameChange;
	public AccessibleEvents DescriptionChange;
	public AccessibleEvents ValueChange;
	public AccessibleEvents ParentChange;
	public AccessibleEvents HelpChange;
	public AccessibleEvents DefaultActionChange;
	public AccessibleEvents AcceleratorChange;
}

