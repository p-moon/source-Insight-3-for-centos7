public class FileSystem
{

	// Methods
	public static void ChDir(string Path) {}
	public static void ChDrive(char Drive) {}
	public static void ChDrive(string Drive) {}
	public static string CurDir() {}
	public static string CurDir(char Drive) {}
	public static string Dir() {}
	public static string Dir(string PathName, FileAttribute Attributes) {}
	public static void MkDir(string Path) {}
	public static void RmDir(string Path) {}
	public static void FileCopy(string Source, string Destination) {}
	public static System.DateTime FileDateTime(string PathName) {}
	public static long FileLen(string PathName) {}
	public static FileAttribute GetAttr(string PathName) {}
	public static void Kill(string PathName) {}
	public static void SetAttr(string PathName, FileAttribute Attributes) {}
	public static void FileOpen(int FileNumber, string FileName, OpenMode Mode, OpenAccess Access, OpenShare Share, int RecordLength) {}
	public static void FileClose(int[] FileNumbers) {}
	public static void FileGetObject(int FileNumber, System.Object& Value, long RecordNumber) {}
	public static void FileGet(int FileNumber, System.ValueType& Value, long RecordNumber) {}
	public static void FileGet(int FileNumber, System.Array& Value, long RecordNumber, bool ArrayIsDynamic, bool StringIsFixedLength) {}
	public static void FileGet(int FileNumber, System.Boolean& Value, long RecordNumber) {}
	public static void FileGet(int FileNumber, System.Byte& Value, long RecordNumber) {}
	public static void FileGet(int FileNumber, System.Int16& Value, long RecordNumber) {}
	public static void FileGet(int FileNumber, System.Int32& Value, long RecordNumber) {}
	public static void FileGet(int FileNumber, System.Int64& Value, long RecordNumber) {}
	public static void FileGet(int FileNumber, System.Char& Value, long RecordNumber) {}
	public static void FileGet(int FileNumber, System.Single& Value, long RecordNumber) {}
	public static void FileGet(int FileNumber, System.Double& Value, long RecordNumber) {}
	public static void FileGet(int FileNumber, System.Decimal& Value, long RecordNumber) {}
	public static void FileGet(int FileNumber, System.String& Value, long RecordNumber, bool StringIsFixedLength) {}
	public static void FileGet(int FileNumber, System.DateTime& Value, long RecordNumber) {}
	public static void FilePutObject(int FileNumber, object Value, long RecordNumber) {}
	public static void FilePut(object FileNumber, object Value, object RecordNumber) {}
	public static void FilePut(int FileNumber, System.ValueType Value, long RecordNumber) {}
	public static void FilePut(int FileNumber, System.Array Value, long RecordNumber, bool ArrayIsDynamic, bool StringIsFixedLength) {}
	public static void FilePut(int FileNumber, bool Value, long RecordNumber) {}
	public static void FilePut(int FileNumber, byte Value, long RecordNumber) {}
	public static void FilePut(int FileNumber, short Value, long RecordNumber) {}
	public static void FilePut(int FileNumber, int Value, long RecordNumber) {}
	public static void FilePut(int FileNumber, long Value, long RecordNumber) {}
	public static void FilePut(int FileNumber, char Value, long RecordNumber) {}
	public static void FilePut(int FileNumber, float Value, long RecordNumber) {}
	public static void FilePut(int FileNumber, double Value, long RecordNumber) {}
	public static void FilePut(int FileNumber, decimal Value, long RecordNumber) {}
	public static void FilePut(int FileNumber, string Value, long RecordNumber, bool StringIsFixedLength) {}
	public static void FilePut(int FileNumber, System.DateTime Value, long RecordNumber) {}
	public static void Print(int FileNumber, object[] Output) {}
	public static void PrintLine(int FileNumber, object[] Output) {}
	public static void Input(int FileNumber, System.Object& Value) {}
	public static void Input(int FileNumber, System.Boolean& Value) {}
	public static void Input(int FileNumber, System.Byte& Value) {}
	public static void Input(int FileNumber, System.Int16& Value) {}
	public static void Input(int FileNumber, System.Int32& Value) {}
	public static void Input(int FileNumber, System.Int64& Value) {}
	public static void Input(int FileNumber, System.Char& Value) {}
	public static void Input(int FileNumber, System.Single& Value) {}
	public static void Input(int FileNumber, System.Double& Value) {}
	public static void Input(int FileNumber, System.Decimal& Value) {}
	public static void Input(int FileNumber, System.String& Value) {}
	public static void Input(int FileNumber, System.DateTime& Value) {}
	public static void Write(int FileNumber, object[] Output) {}
	public static void WriteLine(int FileNumber, object[] Output) {}
	public static string InputString(int FileNumber, int CharCount) {}
	public static string LineInput(int FileNumber) {}
	public static void Lock(int FileNumber) {}
	public static void Lock(int FileNumber, long Record) {}
	public static void Lock(int FileNumber, long FromRecord, long ToRecord) {}
	public static void Unlock(int FileNumber) {}
	public static void Unlock(int FileNumber, long Record) {}
	public static void Unlock(int FileNumber, long FromRecord, long ToRecord) {}
	public static void FileWidth(int FileNumber, int RecordWidth) {}
	public static int FreeFile() {}
	public static void Seek(int FileNumber, long Position) {}
	public static long Seek(int FileNumber) {}
	public static bool EOF(int FileNumber) {}
	public static long Loc(int FileNumber) {}
	public static long LOF(int FileNumber) {}
	public static TabInfo TAB() {}
	public static TabInfo TAB(short Column) {}
	public static SpcInfo SPC(short Count) {}
	public static OpenMode FileAttr(int FileNumber) {}
	public static void Reset() {}
	public static void Rename(string OldPath, string NewPath) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

