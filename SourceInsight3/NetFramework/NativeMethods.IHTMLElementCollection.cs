public interface IHTMLElementCollection
{

	// Methods
	public abstract virtual string toString() {}
	public abstract virtual void SetLength(int p) {}
	public abstract virtual int GetLength() {}
	public abstract virtual object Get_newEnum() {}
	public abstract virtual IHTMLElement Item(object name, object index) {}
	public abstract virtual object Tags(object tagName) {}
}

