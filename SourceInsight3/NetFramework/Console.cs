public class Console
{

	// Methods
	public static void Beep() {}
	public static void Beep(int frequency, int duration) {}
	public static void Clear() {}
	public static void ResetColor() {}
	public static void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop) {}
	public static void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop, char sourceChar, ConsoleColor sourceForeColor, ConsoleColor sourceBackColor) {}
	public static void SetBufferSize(int width, int height) {}
	public static void SetWindowSize(int width, int height) {}
	public static void SetWindowPosition(int left, int top) {}
	public static void SetCursorPosition(int left, int top) {}
	public static ConsoleKeyInfo ReadKey() {}
	public static ConsoleKeyInfo ReadKey(bool intercept) {}
	public static System.IO.Stream OpenStandardError() {}
	public static System.IO.Stream OpenStandardError(int bufferSize) {}
	public static System.IO.Stream OpenStandardInput() {}
	public static System.IO.Stream OpenStandardInput(int bufferSize) {}
	public static System.IO.Stream OpenStandardOutput() {}
	public static System.IO.Stream OpenStandardOutput(int bufferSize) {}
	public static void SetIn(System.IO.TextReader newIn) {}
	public static void SetOut(System.IO.TextWriter newOut) {}
	public static void SetError(System.IO.TextWriter newError) {}
	public static int Read() {}
	public static string ReadLine() {}
	public static void WriteLine() {}
	public static void WriteLine(bool value) {}
	public static void WriteLine(char value) {}
	public static void WriteLine(char[] buffer) {}
	public static void WriteLine(char[] buffer, int index, int count) {}
	public static void WriteLine(decimal value) {}
	public static void WriteLine(double value) {}
	public static void WriteLine(float value) {}
	public static void WriteLine(int value) {}
	public static void WriteLine(uint value) {}
	public static void WriteLine(long value) {}
	public static void WriteLine(ulong value) {}
	public static void WriteLine(object value) {}
	public static void WriteLine(string value) {}
	public static void WriteLine(string format, object arg0) {}
	public static void WriteLine(string format, object arg0, object arg1) {}
	public static void WriteLine(string format, object arg0, object arg1, object arg2) {}
	public static void WriteLine(string format, object arg0, object arg1, object arg2, object arg3) {}
	public static void WriteLine(string format, object[] arg) {}
	public static void Write(string format, object arg0) {}
	public static void Write(string format, object arg0, object arg1) {}
	public static void Write(string format, object arg0, object arg1, object arg2) {}
	public static void Write(string format, object arg0, object arg1, object arg2, object arg3) {}
	public static void Write(string format, object[] arg) {}
	public static void Write(bool value) {}
	public static void Write(char value) {}
	public static void Write(char[] buffer) {}
	public static void Write(char[] buffer, int index, int count) {}
	public static void Write(double value) {}
	public static void Write(decimal value) {}
	public static void Write(float value) {}
	public static void Write(int value) {}
	public static void Write(uint value) {}
	public static void Write(long value) {}
	public static void Write(ulong value) {}
	public static void Write(object value) {}
	public static void Write(string value) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.IO.TextWriter Error { get{} }
	public System.IO.TextReader In { get{} }
	public System.IO.TextWriter Out { get{} }
	public System.Text.Encoding InputEncoding { get{} set{} }
	public System.Text.Encoding OutputEncoding { get{} set{} }
	public ConsoleColor BackgroundColor { get{} set{} }
	public ConsoleColor ForegroundColor { get{} set{} }
	public int BufferHeight { get{} set{} }
	public int BufferWidth { get{} set{} }
	public int WindowHeight { get{} set{} }
	public int WindowWidth { get{} set{} }
	public int LargestWindowWidth { get{} }
	public int LargestWindowHeight { get{} }
	public int WindowLeft { get{} set{} }
	public int WindowTop { get{} set{} }
	public int CursorLeft { get{} set{} }
	public int CursorTop { get{} set{} }
	public int CursorSize { get{} set{} }
	public bool CursorVisible { get{} set{} }
	public string Title { get{} set{} }
	public bool KeyAvailable { get{} }
	public bool NumberLock { get{} }
	public bool CapsLock { get{} }
	public bool TreatControlCAsInput { get{} set{} }

	// Events
	public event System.ConsoleCancelEventHandler CancelKeyPress;
}

