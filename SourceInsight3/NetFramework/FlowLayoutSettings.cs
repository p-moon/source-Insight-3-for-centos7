public class FlowLayoutSettings : LayoutSettings
{

	// Methods
	public void SetFlowBreak(object child, bool value) {}
	public bool GetFlowBreak(object child) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Windows.Forms.Layout.LayoutEngine LayoutEngine { get{} }
	public FlowDirection FlowDirection { get{} set{} }
	public bool WrapContents { get{} set{} }
}

