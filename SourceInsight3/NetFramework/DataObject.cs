public class DataObject : IDataObject, System.Runtime.InteropServices.ComTypes.IDataObject
{

	// Constructors
	public DataObject() {}
	public DataObject(object data) {}
	public DataObject(string format, object data) {}

	// Methods
	public virtual object GetData(string format, bool autoConvert) {}
	public virtual object GetData(string format) {}
	public virtual object GetData(Type format) {}
	public virtual bool GetDataPresent(Type format) {}
	public virtual bool GetDataPresent(string format, bool autoConvert) {}
	public virtual bool GetDataPresent(string format) {}
	public virtual string[] GetFormats(bool autoConvert) {}
	public virtual string[] GetFormats() {}
	public virtual bool ContainsAudio() {}
	public virtual bool ContainsFileDropList() {}
	public virtual bool ContainsImage() {}
	public virtual bool ContainsText() {}
	public virtual bool ContainsText(TextDataFormat format) {}
	public virtual System.IO.Stream GetAudioStream() {}
	public virtual System.Collections.Specialized.StringCollection GetFileDropList() {}
	public virtual System.Drawing.Image GetImage() {}
	public virtual string GetText() {}
	public virtual string GetText(TextDataFormat format) {}
	public virtual void SetAudio(byte[] audioBytes) {}
	public virtual void SetAudio(System.IO.Stream audioStream) {}
	public virtual void SetFileDropList(System.Collections.Specialized.StringCollection filePaths) {}
	public virtual void SetImage(System.Drawing.Image image) {}
	public virtual void SetText(string textData) {}
	public virtual void SetText(string textData, TextDataFormat format) {}
	public virtual void SetData(string format, bool autoConvert, object data) {}
	public virtual void SetData(string format, object data) {}
	public virtual void SetData(Type format, object data) {}
	public virtual void SetData(object data) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

