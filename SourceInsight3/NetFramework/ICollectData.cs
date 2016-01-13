public interface ICollectData
{

	// Methods
	public abstract virtual void CollectData(int id, System.IntPtr valueName, System.IntPtr data, int totalBytesout , System.IntPtr& res) {}
	public abstract virtual void CloseData() {}
}

