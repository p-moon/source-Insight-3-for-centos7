public class RemotingServices
{

	// Methods
	public static bool IsTransparentProxy(object proxy) {}
	public static System.Runtime.Remoting.Proxies.RealProxy GetRealProxy(object proxy) {}
	public static ObjRef Marshal(System.MarshalByRefObject Obj, string URI) {}
	public static bool IsObjectOutOfContext(object tp) {}
	public static bool IsObjectOutOfAppDomain(object tp) {}
	public static string GetSessionIdForMethodMessage(System.Runtime.Remoting.Messaging.IMethodMessage msg) {}
	public static object GetLifetimeService(System.MarshalByRefObject obj) {}
	public static string GetObjectUri(System.MarshalByRefObject obj) {}
	public static void SetObjectUriForMarshal(System.MarshalByRefObject obj, string uri) {}
	public static ObjRef Marshal(System.MarshalByRefObject Obj) {}
	public static ObjRef Marshal(System.MarshalByRefObject Obj, string ObjURI, Type RequestedType) {}
	public static void GetObjectData(object obj, System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public static object Unmarshal(ObjRef objectRef) {}
	public static object Unmarshal(ObjRef objectRef, bool fRefine) {}
	public static object Connect(Type classToProxy, string url) {}
	public static object Connect(Type classToProxy, string url, object data) {}
	public static bool Disconnect(System.MarshalByRefObject obj) {}
	public static System.Runtime.Remoting.Messaging.IMessageSink GetEnvoyChainForProxy(System.MarshalByRefObject obj) {}
	public static ObjRef GetObjRefForProxy(System.MarshalByRefObject obj) {}
	public static System.Reflection.MethodBase GetMethodBaseFromMethodMessage(System.Runtime.Remoting.Messaging.IMethodMessage msg) {}
	public static bool IsMethodOverloaded(System.Runtime.Remoting.Messaging.IMethodMessage msg) {}
	public static bool IsOneWay(System.Reflection.MethodBase method) {}
	public static Type GetServerTypeForUri(string URI) {}
	public static System.Runtime.Remoting.Messaging.IMethodReturnMessage ExecuteMessage(System.MarshalByRefObject target, System.Runtime.Remoting.Messaging.IMethodCallMessage reqMsg) {}
	public static void LogRemotingStage(int stage) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

