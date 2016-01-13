public interface ICheckBoxControl
{

	// Properties
	public bool Checked { get{} set{} }

	// Events
	public event System.EventHandler CheckedChanged;
}

