public class Network
{

	// Constructors
	public Network() {}

	// Methods
	public bool Ping(string hostNameOrAddress) {}
	public bool Ping(System.Uri address) {}
	public bool Ping(string hostNameOrAddress, int timeout) {}
	public bool Ping(System.Uri address, int timeout) {}
	public void DownloadFile(string address, string destinationFileName) {}
	public void DownloadFile(System.Uri address, string destinationFileName) {}
	public void DownloadFile(string address, string destinationFileName, string userName, string password) {}
	public void DownloadFile(System.Uri address, string destinationFileName, string userName, string password) {}
	public void DownloadFile(string address, string destinationFileName, string userName, string password, bool showUI, int connectionTimeout, bool overwrite) {}
	public void DownloadFile(string address, string destinationFileName, string userName, string password, bool showUI, int connectionTimeout, bool overwrite, Microsoft.VisualBasic.FileIO.UICancelOption onUserCancel) {}
	public void DownloadFile(System.Uri address, string destinationFileName, string userName, string password, bool showUI, int connectionTimeout, bool overwrite) {}
	public void DownloadFile(System.Uri address, string destinationFileName, string userName, string password, bool showUI, int connectionTimeout, bool overwrite, Microsoft.VisualBasic.FileIO.UICancelOption onUserCancel) {}
	public void DownloadFile(System.Uri address, string destinationFileName, System.Net.ICredentials networkCredentials, bool showUI, int connectionTimeout, bool overwrite) {}
	public void DownloadFile(System.Uri address, string destinationFileName, System.Net.ICredentials networkCredentials, bool showUI, int connectionTimeout, bool overwrite, Microsoft.VisualBasic.FileIO.UICancelOption onUserCancel) {}
	public void UploadFile(string sourceFileName, string address) {}
	public void UploadFile(string sourceFileName, System.Uri address) {}
	public void UploadFile(string sourceFileName, string address, string userName, string password) {}
	public void UploadFile(string sourceFileName, System.Uri address, string userName, string password) {}
	public void UploadFile(string sourceFileName, string address, string userName, string password, bool showUI, int connectionTimeout) {}
	public void UploadFile(string sourceFileName, string address, string userName, string password, bool showUI, int connectionTimeout, Microsoft.VisualBasic.FileIO.UICancelOption onUserCancel) {}
	public void UploadFile(string sourceFileName, System.Uri address, string userName, string password, bool showUI, int connectionTimeout) {}
	public void UploadFile(string sourceFileName, System.Uri address, string userName, string password, bool showUI, int connectionTimeout, Microsoft.VisualBasic.FileIO.UICancelOption onUserCancel) {}
	public void UploadFile(string sourceFileName, System.Uri address, System.Net.ICredentials networkCredentials, bool showUI, int connectionTimeout) {}
	public void UploadFile(string sourceFileName, System.Uri address, System.Net.ICredentials networkCredentials, bool showUI, int connectionTimeout, Microsoft.VisualBasic.FileIO.UICancelOption onUserCancel) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool IsAvailable { get{} }

	// Events
	public event Microsoft.VisualBasic.Devices.NetworkAvailableEventHandler NetworkAvailabilityChanged;
}

