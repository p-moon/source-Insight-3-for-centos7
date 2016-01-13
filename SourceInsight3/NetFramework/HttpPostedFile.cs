public class HttpPostedFile
{

	// Methods
	public void SaveAs(string filename) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string FileName { get{} }
	public string ContentType { get{} }
	public int ContentLength { get{} }
	public System.IO.Stream InputStream { get{} }
}

