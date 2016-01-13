public class WebPartManagerInternals
{

	// Methods
	public void AddWebPart(WebPart webPart) {}
	public void CallOnClosing(WebPart webPart) {}
	public void CallOnConnectModeChanged(WebPart webPart) {}
	public void CallOnDeleting(WebPart webPart) {}
	public void CallOnEditModeChanged(WebPart webPart) {}
	public object CreateObjectFromType(Type type) {}
	public bool ConnectionDeleted(WebPartConnection connection) {}
	public void DeleteConnection(WebPartConnection connection) {}
	public string GetZoneID(WebPart webPart) {}
	public void LoadConfigurationState(WebPartTransformer transformer, object savedState) {}
	public void RemoveWebPart(WebPart webPart) {}
	public object SaveConfigurationState(WebPartTransformer transformer) {}
	public void SetConnectErrorMessage(WebPart webPart, string connectErrorMessage) {}
	public void SetHasUserData(WebPart webPart, bool hasUserData) {}
	public void SetHasSharedData(WebPart webPart, bool hasSharedData) {}
	public void SetIsClosed(WebPart webPart, bool isClosed) {}
	public void SetIsShared(WebPartConnection connection, bool isShared) {}
	public void SetIsShared(WebPart webPart, bool isShared) {}
	public void SetIsStandalone(WebPart webPart, bool isStandalone) {}
	public void SetIsStatic(WebPartConnection connection, bool isStatic) {}
	public void SetIsStatic(WebPart webPart, bool isStatic) {}
	public void SetTransformer(WebPartConnection connection, WebPartTransformer transformer) {}
	public void SetZoneID(WebPart webPart, string zoneID) {}
	public void SetZoneIndex(WebPart webPart, int zoneIndex) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

