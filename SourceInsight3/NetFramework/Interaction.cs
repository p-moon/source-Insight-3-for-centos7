public class Interaction
{

	// Methods
	public static int Shell(string PathName, AppWinStyle Style, bool Wait, int Timeout) {}
	public static void AppActivate(int ProcessId) {}
	public static void AppActivate(string Title) {}
	public static string Command() {}
	public static string Environ(int Expression) {}
	public static string Environ(string Expression) {}
	public static void Beep() {}
	public static string InputBox(string Prompt, string Title, string DefaultResponse, int XPos, int YPos) {}
	public static MsgBoxResult MsgBox(object Prompt, MsgBoxStyle Buttons, object Title) {}
	public static object Choose(double Index, object[] Choice) {}
	public static object IIf(bool Expression, object TruePart, object FalsePart) {}
	public static string Partition(long Number, long Start, long Stop, long Interval) {}
	public static object Switch(object[] VarExpr) {}
	public static void DeleteSetting(string AppName, string Section, string Key) {}
	public static string[] GetAllSettings(string AppName, string Section) {}
	public static string GetSetting(string AppName, string Section, string Key, string Default) {}
	public static void SaveSetting(string AppName, string Section, string Key, string Setting) {}
	public static object CreateObject(string ProgId, string ServerName) {}
	public static object GetObject(string PathName, string Class) {}
	public static object CallByName(object ObjectRef, string ProcName, CallType UseCallType, object[] Args) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

