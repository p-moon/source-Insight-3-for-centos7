public class SessionStateUtility
{

	// Methods
	public static void RaiseSessionEnd(IHttpSessionState session, object eventSource, System.EventArgs eventArgs) {}
	public static void AddHttpSessionStateToContext(System.Web.HttpContext context, IHttpSessionState container) {}
	public static void RemoveHttpSessionStateFromContext(System.Web.HttpContext context) {}
	public static IHttpSessionState GetHttpSessionStateFromContext(System.Web.HttpContext context) {}
	public static System.Web.HttpStaticObjectsCollection GetSessionStaticObjects(System.Web.HttpContext context) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

