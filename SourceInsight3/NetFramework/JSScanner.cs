public class JSScanner
{

	// Constructors
	public JSScanner() {}
	public JSScanner(Context sourceContext) {}

	// Methods
	public void SetAuthoringMode(bool mode) {}
	public void SetSource(Context sourceContext) {}
	public void GetNextToken() {}
	public int GetCurrentPosition(bool absolute) {}
	public int GetCurrentLine() {}
	public int GetStartLinePosition() {}
	public string GetStringLiteral() {}
	public string GetSourceCode() {}
	public bool GotEndOfLine() {}
	public int SkipMultiLineComment() {}
	public static bool IsOperator(JSToken token) {}
	public static bool IsKeyword(JSToken token) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

