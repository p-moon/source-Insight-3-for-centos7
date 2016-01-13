public interface IButtonControl
{

	// Properties
	public bool CausesValidation { get{} set{} }
	public string CommandArgument { get{} set{} }
	public string CommandName { get{} set{} }
	public string PostBackUrl { get{} set{} }
	public string Text { get{} set{} }
	public string ValidationGroup { get{} set{} }

	// Events
	public event System.EventHandler Click;
	public event System.Web.UI.WebControls.CommandEventHandler Command;
}

