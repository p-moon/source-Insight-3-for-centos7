public interface IDropTarget
{

	// Methods
	public abstract virtual void OnDragEnter(DragEventArgs e) {}
	public abstract virtual void OnDragLeave(System.EventArgs e) {}
	public abstract virtual void OnDragDrop(DragEventArgs e) {}
	public abstract virtual void OnDragOver(DragEventArgs e) {}
}

