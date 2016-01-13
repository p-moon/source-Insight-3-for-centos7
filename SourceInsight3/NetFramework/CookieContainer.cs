public class CookieContainer
{

	// Constructors
	public CookieContainer() {}
	public CookieContainer(int capacity) {}
	public CookieContainer(int capacity, int perDomainCapacity, int maxCookieSize) {}

	// Methods
	public void Add(Cookie cookie) {}
	public void Add(CookieCollection cookies) {}
	public void Add(System.Uri uri, Cookie cookie) {}
	public void Add(System.Uri uri, CookieCollection cookies) {}
	public CookieCollection GetCookies(System.Uri uri) {}
	public string GetCookieHeader(System.Uri uri) {}
	public void SetCookies(System.Uri uri, string cookieHeader) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int DefaultCookieLimit;
	public int DefaultPerDomainCookieLimit;
	public int DefaultCookieLengthLimit;

	// Properties
	public int Capacity { get{} set{} }
	public int Count { get{} }
	public int MaxCookieSize { get{} set{} }
	public int PerDomainCapacity { get{} set{} }
}

