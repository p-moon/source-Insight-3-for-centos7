public interface IAds
{

	// Methods
	public abstract virtual void GetInfo() {}
	public abstract virtual void SetInfo() {}
	public abstract virtual object Get(string bstrName) {}
	public abstract virtual void Put(string bstrName, object vProp) {}
	public abstract virtual int GetEx(string bstrNameout , System.Object& value) {}
	public abstract virtual void PutEx(int lnControlCode, string bstrName, object vProp) {}
	public abstract virtual void GetInfoEx(object vProperties, int lnReserved) {}

	// Properties
	public string Name { get{} }
	public string Class { get{} }
	public string GUID { get{} }
	public string ADsPath { get{} }
	public string Parent { get{} }
	public string Schema { get{} }
}

