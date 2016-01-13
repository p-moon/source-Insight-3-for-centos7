public class Clipboard
{

	// Methods
	public static void SetDataObject(object data) {}
	public static void SetDataObject(object data, bool copy) {}
	public static void SetDataObject(object data, bool copy, int retryTimes, int retryDelay) {}
	public static IDataObject GetDataObject() {}
	public static void Clear() {}
	public static bool ContainsAudio() {}
	public static bool ContainsData(string format) {}
	public static bool ContainsFileDropList() {}
	public static bool ContainsImage() {}
	public static bool ContainsText() {}
	public static bool ContainsText(TextDataFormat format) {}
	public static System.IO.Stream GetAudioStream() {}
	public static object GetData(string format) {}
	public static System.Collections.Specialized.StringCollection GetFileDropList() {}
	public static System.Drawing.Image GetImage() {}
	public static string GetText() {}
	public static string GetText(TextDataFormat format) {}
	public static void SetAudio(byte[] audioBytes) {}
	public static void SetAudio(System.IO.Stream audioStream) {}
	public static void SetData(string format, object data) {}
	public static void SetFileDropList(System.Collections.Specialized.StringCollection filePaths) {}
	public static void SetImage(System.Drawing.Image image) {}
	public static void SetText(string text) {}
	public static void SetText(string text, TextDataFormat format) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

