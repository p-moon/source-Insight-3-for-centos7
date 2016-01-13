public class PostBackOptions
{

	// Constructors
	public PostBackOptions(Control targetControl) {}
	public PostBackOptions(Control targetControl, string argument) {}
	public PostBackOptions(Control targetControl, string argument, string actionUrl, bool autoPostBack, bool requiresJavaScriptProtocol, bool trackFocus, bool clientSubmit, bool performValidation, string validationGroup) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string ActionUrl { get{} set{} }
	public string Argument { get{} set{} }
	public bool AutoPostBack { get{} set{} }
	public bool ClientSubmit { get{} set{} }
	public bool RequiresJavaScriptProtocol { get{} set{} }
	public bool PerformValidation { get{} set{} }
	public string ValidationGroup { get{} set{} }
	public Control TargetControl { get{} }
	public bool TrackFocus { get{} set{} }
}

