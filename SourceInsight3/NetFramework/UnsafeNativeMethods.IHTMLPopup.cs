public interface IHTMLPopup
{

	// Methods
	public abstract virtual void show(int x, int y, int w, int h, System.Object& element) {}
	public abstract virtual void hide() {}
	public abstract virtual IHTMLDocument GetDocument() {}
	public abstract virtual bool IsOpen() {}
}

