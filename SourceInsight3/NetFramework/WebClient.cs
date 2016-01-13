public class WebClient : System.ComponentModel.Component, System.ComponentModel.IComponent, System.IDisposable
{

	// Constructors
	public WebClient() {}

	// Methods
	public byte[] DownloadData(string address) {}
	public byte[] DownloadData(System.Uri address) {}
	public void DownloadFile(string address, string fileName) {}
	public void DownloadFile(System.Uri address, string fileName) {}
	public System.IO.Stream OpenRead(string address) {}
	public System.IO.Stream OpenRead(System.Uri address) {}
	public System.IO.Stream OpenWrite(string address) {}
	public System.IO.Stream OpenWrite(System.Uri address) {}
	public System.IO.Stream OpenWrite(string address, string method) {}
	public System.IO.Stream OpenWrite(System.Uri address, string method) {}
	public byte[] UploadData(string address, byte[] data) {}
	public byte[] UploadData(System.Uri address, byte[] data) {}
	public byte[] UploadData(string address, string method, byte[] data) {}
	public byte[] UploadData(System.Uri address, string method, byte[] data) {}
	public byte[] UploadFile(string address, string fileName) {}
	public byte[] UploadFile(System.Uri address, string fileName) {}
	public byte[] UploadFile(string address, string method, string fileName) {}
	public byte[] UploadFile(System.Uri address, string method, string fileName) {}
	public byte[] UploadValues(string address, System.Collections.Specialized.NameValueCollection data) {}
	public byte[] UploadValues(System.Uri address, System.Collections.Specialized.NameValueCollection data) {}
	public byte[] UploadValues(string address, string method, System.Collections.Specialized.NameValueCollection data) {}
	public byte[] UploadValues(System.Uri address, string method, System.Collections.Specialized.NameValueCollection data) {}
	public string UploadString(string address, string data) {}
	public string UploadString(System.Uri address, string data) {}
	public string UploadString(string address, string method, string data) {}
	public string UploadString(System.Uri address, string method, string data) {}
	public string DownloadString(string address) {}
	public string DownloadString(System.Uri address) {}
	public void OpenReadAsync(System.Uri address) {}
	public void OpenReadAsync(System.Uri address, object userToken) {}
	public void OpenWriteAsync(System.Uri address) {}
	public void OpenWriteAsync(System.Uri address, string method) {}
	public void OpenWriteAsync(System.Uri address, string method, object userToken) {}
	public void DownloadStringAsync(System.Uri address) {}
	public void DownloadStringAsync(System.Uri address, object userToken) {}
	public void DownloadDataAsync(System.Uri address) {}
	public void DownloadDataAsync(System.Uri address, object userToken) {}
	public void DownloadFileAsync(System.Uri address, string fileName) {}
	public void DownloadFileAsync(System.Uri address, string fileName, object userToken) {}
	public void UploadStringAsync(System.Uri address, string data) {}
	public void UploadStringAsync(System.Uri address, string method, string data) {}
	public void UploadStringAsync(System.Uri address, string method, string data, object userToken) {}
	public void UploadDataAsync(System.Uri address, byte[] data) {}
	public void UploadDataAsync(System.Uri address, string method, byte[] data) {}
	public void UploadDataAsync(System.Uri address, string method, byte[] data, object userToken) {}
	public void UploadFileAsync(System.Uri address, string fileName) {}
	public void UploadFileAsync(System.Uri address, string method, string fileName) {}
	public void UploadFileAsync(System.Uri address, string method, string fileName, object userToken) {}
	public void UploadValuesAsync(System.Uri address, System.Collections.Specialized.NameValueCollection data) {}
	public void UploadValuesAsync(System.Uri address, string method, System.Collections.Specialized.NameValueCollection data) {}
	public void UploadValuesAsync(System.Uri address, string method, System.Collections.Specialized.NameValueCollection data, object userToken) {}
	public void CancelAsync() {}
	public virtual void Dispose() {}
	public virtual string ToString() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Text.Encoding Encoding { get{} set{} }
	public string BaseAddress { get{} set{} }
	public ICredentials Credentials { get{} set{} }
	public bool UseDefaultCredentials { get{} set{} }
	public WebHeaderCollection Headers { get{} set{} }
	public System.Collections.Specialized.NameValueCollection QueryString { get{} set{} }
	public WebHeaderCollection ResponseHeaders { get{} }
	public IWebProxy Proxy { get{} set{} }
	public System.Net.Cache.RequestCachePolicy CachePolicy { get{} set{} }
	public bool IsBusy { get{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.Net.OpenReadCompletedEventHandler OpenReadCompleted;
	public event System.Net.OpenWriteCompletedEventHandler OpenWriteCompleted;
	public event System.Net.DownloadStringCompletedEventHandler DownloadStringCompleted;
	public event System.Net.DownloadDataCompletedEventHandler DownloadDataCompleted;
	public event System.ComponentModel.AsyncCompletedEventHandler DownloadFileCompleted;
	public event System.Net.UploadStringCompletedEventHandler UploadStringCompleted;
	public event System.Net.UploadDataCompletedEventHandler UploadDataCompleted;
	public event System.Net.UploadFileCompletedEventHandler UploadFileCompleted;
	public event System.Net.UploadValuesCompletedEventHandler UploadValuesCompleted;
	public event System.Net.DownloadProgressChangedEventHandler DownloadProgressChanged;
	public event System.Net.UploadProgressChangedEventHandler UploadProgressChanged;
	public event System.EventHandler Disposed;
}

