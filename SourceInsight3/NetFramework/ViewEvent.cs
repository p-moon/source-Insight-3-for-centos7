public class ViewEvent
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public ViewEvent Click;
	public ViewEvent Paint;
	public ViewEvent TemplateModeChanged;
}

