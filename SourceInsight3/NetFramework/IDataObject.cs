public interface IDataObject
{

	// Methods
	public abstract virtual object GetData(string format, bool autoConvert) {}
	public abstract virtual object GetData(string format) {}
	public abstract virtual object GetData(Type format) {}
	public abstract virtual void SetData(string format, bool autoConvert, object data) {}
	public abstract virtual void SetData(string format, object data) {}
	public abstract virtual void SetData(Type format, object data) {}
	public abstract virtual void SetData(object data) {}
	public abstract virtual bool GetDataPresent(string format, bool autoConvert) {}
	public abstract virtual bool GetDataPresent(string format) {}
	public abstract virtual bool GetDataPresent(Type format) {}
	public abstract virtual string[] GetFormats(bool autoConvert) {}
	public abstract virtual string[] GetFormats() {}
}

