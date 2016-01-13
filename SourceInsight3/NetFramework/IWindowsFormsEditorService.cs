public interface IWindowsFormsEditorService
{

	// Methods
	public abstract virtual void CloseDropDown() {}
	public abstract virtual void DropDownControl(System.Windows.Forms.Control control) {}
	public abstract virtual System.Windows.Forms.DialogResult ShowDialog(System.Windows.Forms.Form dialog) {}
}

