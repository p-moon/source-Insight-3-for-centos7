public class PagerSettings : System.Web.UI.IStateManager
{

	// Constructors
	public PagerSettings() {}

	// Methods
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string FirstPageImageUrl { get{} set{} }
	public string FirstPageText { get{} set{} }
	public string LastPageImageUrl { get{} set{} }
	public string LastPageText { get{} set{} }
	public PagerButtons Mode { get{} set{} }
	public string NextPageImageUrl { get{} set{} }
	public string NextPageText { get{} set{} }
	public int PageButtonCount { get{} set{} }
	public PagerPosition Position { get{} set{} }
	public string PreviousPageImageUrl { get{} set{} }
	public string PreviousPageText { get{} set{} }
	public bool Visible { get{} set{} }

	// Events
	public event System.EventHandler PropertyChanged;
}

