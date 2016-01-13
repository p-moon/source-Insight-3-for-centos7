public class ClipboardProxy
{

	// Methods
	public string GetText() {}
	public string GetText(System.Windows.Forms.TextDataFormat format) {}
	public bool ContainsText() {}
	public bool ContainsText(System.Windows.Forms.TextDataFormat format) {}
	public void SetText(string text) {}
	public void SetText(string text, System.Windows.Forms.TextDataFormat format) {}
	public System.Drawing.Image GetImage() {}
	public bool ContainsImage() {}
	public void SetImage(System.Drawing.Image image) {}
	public System.IO.Stream GetAudioStream() {}
	public bool ContainsAudio() {}
	public void SetAudio(byte[] audioBytes) {}
	public void SetAudio(System.IO.Stream audioStream) {}
	public System.Collections.Specialized.StringCollection GetFileDropList() {}
	public bool ContainsFileDropList() {}
	public void SetFileDropList(System.Collections.Specialized.StringCollection filePaths) {}
	public object GetData(string format) {}
	public bool ContainsData(string format) {}
	public void SetData(string format, object data) {}
	public void Clear() {}
	public System.Windows.Forms.IDataObject GetDataObject() {}
	public void SetDataObject(System.Windows.Forms.DataObject data) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

