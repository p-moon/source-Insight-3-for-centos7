public class X509Certificate2UI
{

	// Methods
	public static void DisplayCertificate(X509Certificate2 certificate) {}
	public static void DisplayCertificate(X509Certificate2 certificate, System.IntPtr hwndParent) {}
	public static X509Certificate2Collection SelectFromCollection(X509Certificate2Collection certificates, string title, string message, X509SelectionFlag selectionFlag) {}
	public static X509Certificate2Collection SelectFromCollection(X509Certificate2Collection certificates, string title, string message, X509SelectionFlag selectionFlag, System.IntPtr hwndParent) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

