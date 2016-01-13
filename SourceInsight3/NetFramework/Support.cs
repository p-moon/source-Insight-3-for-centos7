public class Support
{

	// Methods
	public static bool Imp(bool a, bool b) {}
	public static byte Imp(byte a, byte b) {}
	public static short Imp(short a, short b) {}
	public static int Imp(int a, int b) {}
	public static long Imp(long a, long b) {}
	public static object Imp(object a, object b) {}
	public static bool Eqv(bool a, bool b) {}
	public static byte Eqv(byte a, byte b) {}
	public static short Eqv(short a, short b) {}
	public static int Eqv(int a, int b) {}
	public static long Eqv(long a, long b) {}
	public static object Eqv(object a, object b) {}
	public static double TwipsToPixelsX(double X) {}
	public static double TwipsToPixelsY(double Y) {}
	public static double PixelsToTwipsX(double X) {}
	public static double PixelsToTwipsY(double Y) {}
	public static double ToPixelsX(double X, ScaleMode FromScale) {}
	public static double ToPixelsY(double Y, ScaleMode FromScale) {}
	public static double FromPixelsX(double X, ScaleMode ToScale) {}
	public static double FromPixelsY(double Y, ScaleMode ToScale) {}
	public static double ToPixelsUserX(double X, double ScaleLeft, double ScaleWidth, int OriginalWidthInPixels) {}
	public static double ToPixelsUserWidth(double Width, double ScaleWidth, int OriginalWidthInPixels) {}
	public static double ToPixelsUserY(double Y, double ScaleTop, double ScaleHeight, int OriginalHeightInPixels) {}
	public static double ToPixelsUserHeight(double Height, double ScaleHeight, int OriginalHeightInPixels) {}
	public static double FromPixelsUserX(double X, double ScaleLeft, double ScaleWidth, int OriginalWidthInPixels) {}
	public static double FromPixelsUserWidth(double Width, double ScaleWidth, int OriginalWidthInPixels) {}
	public static double FromPixelsUserY(double Y, double ScaleTop, double ScaleHeight, int OriginalHeightInPixels) {}
	public static double FromPixelsUserHeight(double Height, double ScaleHeight, int OriginalHeightInPixels) {}
	public static float TwipsPerPixelX() {}
	public static float TwipsPerPixelY() {}
	public static void ShowForm(System.Windows.Forms.Form Form, int Modal, System.Windows.Forms.Form OwnerForm) {}
	public static void WhatsThisMode(System.Windows.Forms.Form Form) {}
	public static void SendKeys(string Keys, bool Wait) {}
	public static bool GetCancel(System.Windows.Forms.Button btn) {}
	public static void SetCancel(System.Windows.Forms.Button btn, bool Cancel) {}
	public static bool GetDefault(System.Windows.Forms.Button btn) {}
	public static void SetDefault(System.Windows.Forms.Button btn, bool Default) {}
	public static System.Windows.Forms.Control GetActiveControl() {}
	public static System.Drawing.Font FontChangeName(System.Drawing.Font CurrentFont, string Name) {}
	public static System.Drawing.Font FontChangeGdiCharSet(System.Drawing.Font CurrentFont, byte GdiCharSet) {}
	public static System.Drawing.Font FontChangeSize(System.Drawing.Font CurrentFont, float Size) {}
	public static System.Drawing.Font FontChangeBold(System.Drawing.Font CurrentFont, bool Bold) {}
	public static System.Drawing.Font FontChangeItalic(System.Drawing.Font CurrentFont, bool Italic) {}
	public static System.Drawing.Font FontChangeStrikeout(System.Drawing.Font CurrentFont, bool Strikeout) {}
	public static System.Drawing.Font FontChangeUnderline(System.Drawing.Font CurrentFont, bool Underline) {}
	public static void ZOrder(System.Windows.Forms.Control Control, int Position) {}
	public static string TabLayout(object[] Args) {}
	public static void ValidateControls(System.Windows.Forms.ContainerControl Form) {}
	public static string GetPath() {}
	public static string GetEXEName() {}
	public static System.IntPtr GetHInstance() {}
	public static System.Array CopyArray(System.Array SourceArray) {}
	public static void SetItemString(System.Windows.Forms.Control Control, int Index, string ItemString) {}
	public static string GetItemString(System.Windows.Forms.Control Control, int Index) {}
	public static void SetItemData(System.Windows.Forms.Control Control, int Index, int ItemData) {}
	public static int GetItemData(System.Windows.Forms.Control Control, int Index) {}
	public static string Format(object Expression, string Style, Microsoft.VisualBasic.FirstDayOfWeek DayOfWeek, Microsoft.VisualBasic.FirstWeekOfYear WeekOfYear) {}
	public static object FontToIFont(System.Drawing.Font fnt) {}
	public static System.Drawing.Font IFontToFont(object objFnt) {}
	public static object CursorToIPicture(System.Windows.Forms.Cursor curs) {}
	public static object IconToIPicture(System.Drawing.Icon ico) {}
	public static object ImageToIPicture(System.Drawing.Image img) {}
	public static object ImageToIPictureDisp(System.Drawing.Image img) {}
	public static System.Drawing.Image IPictureToImage(object pict) {}
	public static System.Drawing.Image IPictureDispToImage(object pict) {}
	public static void SetResourceBaseName(string ProjectNamespace, string BaseFileName) {}
	public static void SetResourceBaseName(string BaseFileName) {}
	public static string LoadResString(int ID) {}
	public static string LoadResString(int ID, System.Globalization.CultureInfo Culture) {}
	public static object LoadResPicture(object ID, LoadResConstants restype) {}
	public static object LoadResPicture(object ID, LoadResConstants restype, System.Globalization.CultureInfo Culture) {}
	public static object LoadResData(object ID, object restype) {}
	public static object LoadResData(object ID, object restype, System.Globalization.CultureInfo Culture) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

