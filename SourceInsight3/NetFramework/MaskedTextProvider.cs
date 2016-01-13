public class MaskedTextProvider : System.ICloneable
{

	// Constructors
	public MaskedTextProvider(string mask) {}
	public MaskedTextProvider(string mask, bool restrictToAscii) {}
	public MaskedTextProvider(string mask, System.Globalization.CultureInfo culture) {}
	public MaskedTextProvider(string mask, System.Globalization.CultureInfo culture, bool restrictToAscii) {}
	public MaskedTextProvider(string mask, char passwordChar, bool allowPromptAsInput) {}
	public MaskedTextProvider(string mask, System.Globalization.CultureInfo culture, char passwordChar, bool allowPromptAsInput) {}
	public MaskedTextProvider(string mask, System.Globalization.CultureInfo culture, bool allowPromptAsInput, char promptChar, char passwordChar, bool restrictToAscii) {}

	// Methods
	public virtual object Clone() {}
	public bool Add(char input) {}
	public bool Add(char inputout , System.Int32& testPositionout , MaskedTextResultHint& resultHint) {}
	public bool Add(string input) {}
	public bool Add(string inputout , System.Int32& testPositionout , MaskedTextResultHint& resultHint) {}
	public void Clear() {}
	public void Clear(out MaskedTextResultHint& resultHint) {}
	public int FindAssignedEditPositionFrom(int position, bool direction) {}
	public int FindAssignedEditPositionInRange(int startPosition, int endPosition, bool direction) {}
	public int FindEditPositionFrom(int position, bool direction) {}
	public int FindEditPositionInRange(int startPosition, int endPosition, bool direction) {}
	public int FindNonEditPositionFrom(int position, bool direction) {}
	public int FindNonEditPositionInRange(int startPosition, int endPosition, bool direction) {}
	public int FindUnassignedEditPositionFrom(int position, bool direction) {}
	public int FindUnassignedEditPositionInRange(int startPosition, int endPosition, bool direction) {}
	public static bool GetOperationResultFromHint(MaskedTextResultHint hint) {}
	public bool InsertAt(char input, int position) {}
	public bool InsertAt(char input, int positionout , System.Int32& testPositionout , MaskedTextResultHint& resultHint) {}
	public bool InsertAt(string input, int position) {}
	public bool InsertAt(string input, int positionout , System.Int32& testPositionout , MaskedTextResultHint& resultHint) {}
	public bool IsAvailablePosition(int position) {}
	public bool IsEditPosition(int position) {}
	public static bool IsValidInputChar(char c) {}
	public static bool IsValidMaskChar(char c) {}
	public static bool IsValidPasswordChar(char c) {}
	public bool Remove() {}
	public bool Remove(out System.Int32& testPositionout , MaskedTextResultHint& resultHint) {}
	public bool RemoveAt(int position) {}
	public bool RemoveAt(int startPosition, int endPosition) {}
	public bool RemoveAt(int startPosition, int endPositionout , System.Int32& testPositionout , MaskedTextResultHint& resultHint) {}
	public bool Replace(char input, int position) {}
	public bool Replace(char input, int positionout , System.Int32& testPositionout , MaskedTextResultHint& resultHint) {}
	public bool Replace(char input, int startPosition, int endPositionout , System.Int32& testPositionout , MaskedTextResultHint& resultHint) {}
	public bool Replace(string input, int position) {}
	public bool Replace(string input, int positionout , System.Int32& testPositionout , MaskedTextResultHint& resultHint) {}
	public bool Replace(string input, int startPosition, int endPositionout , System.Int32& testPositionout , MaskedTextResultHint& resultHint) {}
	public bool Set(string input) {}
	public bool Set(string inputout , System.Int32& testPositionout , MaskedTextResultHint& resultHint) {}
	public string ToDisplayString() {}
	public virtual string ToString() {}
	public string ToString(bool ignorePasswordChar) {}
	public string ToString(int startPosition, int length) {}
	public string ToString(bool ignorePasswordChar, int startPosition, int length) {}
	public string ToString(bool includePrompt, bool includeLiterals) {}
	public string ToString(bool includePrompt, bool includeLiterals, int startPosition, int length) {}
	public string ToString(bool ignorePasswordChar, bool includePrompt, bool includeLiterals, int startPosition, int length) {}
	public bool VerifyChar(char input, int positionout , MaskedTextResultHint& hint) {}
	public bool VerifyEscapeChar(char input, int position) {}
	public bool VerifyString(string input) {}
	public bool VerifyString(string inputout , System.Int32& testPositionout , MaskedTextResultHint& resultHint) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool AllowPromptAsInput { get{} }
	public int AssignedEditPositionCount { get{} }
	public int AvailableEditPositionCount { get{} }
	public System.Globalization.CultureInfo Culture { get{} }
	public char DefaultPasswordChar { get{} }
	public int EditPositionCount { get{} }
	public System.Collections.IEnumerator EditPositions { get{} }
	public bool IncludeLiterals { get{} set{} }
	public bool IncludePrompt { get{} set{} }
	public bool AsciiOnly { get{} }
	public bool IsPassword { get{} set{} }
	public int InvalidIndex { get{} }
	public int LastAssignedPosition { get{} }
	public int Length { get{} }
	public string Mask { get{} }
	public bool MaskCompleted { get{} }
	public bool MaskFull { get{} }
	public char PasswordChar { get{} set{} }
	public char PromptChar { get{} set{} }
	public bool ResetOnPrompt { get{} set{} }
	public bool ResetOnSpace { get{} set{} }
	public bool SkipLiterals { get{} set{} }
	public char Item { get{} }
}

