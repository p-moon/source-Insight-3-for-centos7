public class HtmlHistory : System.IDisposable
{

	// Methods
	public virtual void Dispose() {}
	public void Back(int numberBack) {}
	public void Forward(int numberForward) {}
	public void Go(System.Uri url) {}
	public void Go(string urlString) {}
	public void Go(int relativePosition) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Length { get{} }
	public object DomHistory { get{} }
}

