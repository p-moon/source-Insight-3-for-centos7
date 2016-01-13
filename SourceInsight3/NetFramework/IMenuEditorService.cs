public interface IMenuEditorService
{

	// Methods
	public abstract virtual System.Windows.Forms.Menu GetMenu() {}
	public abstract virtual bool IsActive() {}
	public abstract virtual void SetMenu(System.Windows.Forms.Menu menu) {}
	public abstract virtual void SetSelection(System.Windows.Forms.MenuItem item) {}
	public abstract virtual bool MessageFilter(System.Windows.Forms.Message& m) {}
}

