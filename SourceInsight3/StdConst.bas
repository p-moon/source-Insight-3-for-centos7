' StdConst.bas
' This file contains declarations for core Visual Basic language constants
'
' Adding this file to a Source Insight project will enable auto-completion and other
' symbolic features for these constant symbols from within Source Insight.


'1 Alignment Constants

Global Const vbAlignNone =  0  'Size and location set at design time or in code 
Global Const vbAlignTop =  1  'Align control to top of form 
Global Const vbAlignBottom =  2  'Align control to bottom of form 
Global Const vbAlignLeft =  3  'Align control to left of form 
Global Const vbAlignRight =  4  'Align control to right of form 
Global Const vbLeftJustify =  0  'Left align 
Global Const vbRightJustify =  1  'Right align 
Global Const vbCenter =  2  'Center 

' AsyncType Constant 
Global Const vbAsyncTypePicture =  0  'The data is provided in a Picture object. 
Global Const vbAsyncTypeFile =  1  'The data is provided in a file that is created by Visual Basic. 
Global Const vbAsyncTypeByteArray =  2  'The data is provided as a byte array that contains the retrieved data.  It is assumed that the control author will know how to handle the data. 

' AsyncStatusCode 
Global Const vbAsyncStatusCodeError =  0  'An error occurred during the asynchronous download. 
Global Const vbAsyncStatusCodeFindingResource =  1  'AsyncRead is finding the resource specified in AsyncProperty.Status that holds the storage being downloaded. 
Global Const vbAsyncStatusCodeConnecting =  2  'AsyncRead is connecting to the resource specified in AsyncProperty.Status that holds the storage being downloaded. 
Global Const vbAsyncStatusCodeRedirecting =  3  'AsyncRead has been redirected to a different location specified in AsyncRead.Property.Status. 
Global Const vbAsyncStatusCodeBeginDownloadData =  4  'AsyncRead has begun receiving data for the storage specified in AsyncProperty.Status. 
Global Const vbAsyncStatusCodeDownloadingData =  5  'AsyncRead has received more data for the storage specified in AsyncProperty.Status. 
Global Const vbAsyncStatusCodeEndDownloadData =  6  'AsyncRead has finished receiving data for the storage specified in AsyncProperty.Status. 
Global Const vbAsyncStatusCodeUsingCashedCopy =  10  'AsyncRead is retrieving the requested storage from a cached copy. AsyncProperty.Status is empty. 
Global Const vbAsyncStatusCodeSendingRequest =  11  'AsyncRead is requesting the storage specified in AsyncProperty.Status. 
Global Const vbAsybcStatusCodeMIMETypeAvailable =  13  'The MIME type of the requested storage is specified in AsyncProperty.Status. 
Global Const vbAsyncStatusCodeCacheFileNameAvailable =  14  'The filename of the local file cache for requested storage is specified in AsyncProperty.Status. 
Global Const vbAsyncStatusCodeBeginSyncOperation =  15  'The AsyncRead will operate synchronously. 
Global Const vbAsyncstatusCodeEndSyncOperation =  16  'The AsyncRead has completed synchronous operation. 

Global Const vbScrollBars = &H80000000  'Scroll bar color 
Global Const vbDesktop = &H80000001  'Desktop color 
Global Const vbActiveTitleBar = &H80000002  'Color of the title bar for the active window 
Global Const vbInactiveTitleBar = &H80000003  'Color of the title bar for the inactive window 
Global Const vbMenuBar = &H80000004  'Menu background color 
Global Const vbWindowBackground = &H80000005  'Window background color 
Global Const vbWindowFrame = &H80000006  'Window frame color 
Global Const vbMenuText = &H80000007  'Color of text on menus 
Global Const vbWindowText = &H80000008  'Color of text in windows 
Global Const vbTitleBarText = &H80000009  'Color of text in caption, size box, and scroll arrow 
Global Const vbActiveBorder = &H8000000A  'Border color of active window 
Global Const vbInactiveBorder = &H8000000B  'Border color of inactive window 
Global Const vbApplicationWorkspace = &H8000000C  'Background color of multiple-document interface (MDI) applications 
Global Const vbHighlight = &H8000000D  'Background color of items selected in a control 
Global Const vbHighlightText = &H8000000E  'Text color of items selected in a control 
Global Const vbButtonFace = &H8000000F  'Color of shading on the face of command buttons 
Global Const vbButtonShadow = &H80000010  'Color of shading on the edge of command buttons 
Global Const vbGrayText = &H80000011  'Grayed (disabled) text 
Global Const vbButtonText = &H80000012  'Text color on push buttons 
Global Const vbInactiveCaptionText = &H80000013  'Color of text in an inactive caption 
Global Const vb3DHighlight = &H80000014  'Highlight color for 3D display elements 
Global Const vb3DDKShadow = &H80000015  'Darkest shadow color for 3D display elements 
Global Const vb3DLight = &H80000016  'Second lightest of the 3D colors after vb3Dhighlight 
Global Const vb3DFace = &H8000000F  'Color of text face 
Global Const vb3Dshadow = &H80000010  'Color of text shadow 
Global Const vbInfoText = &H80000017  'Color of text in ToolTips 
Global Const vbInfoBackground = &H80000018  'Background color of ToolTips 


' Border Style (Form)
Global Const vbBSNone = 0 ' No border 
Global Const vbFixedSingle = 1 ' Fixed single 
Global Const vbSizable = 2 ' Sizable (forms only) 
Global Const vbFixedDialog = 3 ' Fixed dialog (forms only) 
Global Const vbFixedToolWindow = 4 ' Fixed tool window 
Global Const vbSizableToolWindow = 5 ' Sizable tool window 


' BorderStyle Property (Shape and Line)
Global Const vbTransparent = 0 ' Transparent 
Global Const vbBSSolid = 1 ' Solid 
Global Const vbBSDash = 2 ' Dash 
Global Const vbBSDot = 3 ' Dot 
Global Const vbBSDashDot = 4 ' Dash-dot 
Global Const vbBSDashDotDot = 5 ' Dash-dot-dot 
Global Const vbBSInsideSolid = 6 ' Inside solid 


' Color Constants
Global Const vbBlack = &H0 ' Black 
Global Const vbRed = &HFF ' Red 
Global Const vbGreen = &HFF00 ' Green 
Global Const vbYellow = &HFFFF ' Yellow 
Global Const vbBlue = &HFF0000 ' Blue 
Global Const vbMagenta = &HFF00FF ' Magenta 
Global Const vbCyan = &HFFFF00 ' Cyan 
Global Const vbWhite = &HFFFFFF ' White 


' Date Format Constants
Global Const vbGeneralDate = 0 ' Display a date and/or time. For real numbers, display a data and time. If there is no fractional part, display only a date. If there is no integer part, display time only. Date and time display is determined by your system settings. 
Global Const vbLongDate = 1 ' Display a date using the long date format specified in your computer's regional settings. 
Global Const vbShortDate = 2 ' Display a date using the short date format specified in your computer's regional settings. 
Global Const vbLongTime = 3 ' Display a time using the long time format specified in your computer's regional settings. 
Global Const vbShortTime = 4 ' Display a time using the short time format specified in your computer's regional settings. 


'1 Data Report Designer Constants

' Alignment Constants

Global Const rptJustifyLeft = 0 ' The text is aligned left. 
Global Const rptJustifyRight = 1 ' The text is aligned right. 
Global Const rptJustifyCenter = 2 ' The text is centered. 

' AsyncType Constants

Global Const rptAsyncPreview = 0 ' Preview mode. Occurs after invoking the Show method. 
Global Const rptAsyncPrint = 1 ' Indicates a job has been sent to the printer. 
Global Const rptAsyncExport = 2 ' Indicates a file is being exported. 


' BackStyle Constants
Global Const rptBkTransparent = 0 ' The control is transparent. 
Global Const rptBkOpaque = 1 ' The control is opaque. 


' BorderStyle Constants
Global Const rptBSTransparent = 0 ' The border is transparent. 
Global Const rptBSSolid = 1 ' The border is solid. 
Global Const rptBSDashes = 2 ' The border consists of dashes. 
Global Const rptBSDots = 3 ' The border consists of dots. 
Global Const rptBSDashDot = 4 ' The border consists of dashes and dots. 
Global Const rptBSDashDotDot = 5 ' The border consists of a dash followed by two dots. 


' Error Constants
Global Const rptErrAccessDenied = 8513 ' (&H2141) Access denied. 
Global Const rptErrBoundCtlNotAllowed = 8551 ' (&H2167) The control can't be placed in this section. 
Global Const rptErrChapterInit = 8521 ' (&H2149) Unable to initialize the chapter. 
Global Const rptErrCollectionIsEmpty = 8573 ' (&H217D) The collection is empty. 
Global Const rptErrCreatingFont = 8556 ' (&H216C) An error occurred creating the font. 
Global Const rptErrCreatingWindow = 8572 ' (&H217C) An error occurred creating the window. 
Global Const rptErrDuplicateKey = 8500 ' (&H2134) There is a duplicate key value in the collection. 
Global Const rptErrExportFormatsEmpty = 8506 ' (&H213A) The ExportFormats collection is empty. 
Global Const rptErrFileAlreadyExists = 8512 ' (&H2140) The file already exists. 
Global Const rptErrGeneralFileIO = 8510 ' (&H213E) File I/O error. 
Global Const rptErrInvalidArg = 8507 ' (&H213B) An argument is invalid. 
Global Const rptErrInvalidColIndex = 8523 ' (&H214B) The column index is invalid. 
Global Const rptErrInvalidDataField = 8526 ' (&H214E) The data field can't be found. 
Global Const rptErrInvalidDateSource = 8520 ' (&H2148) The data source is invalid. 
Global Const rptErrInvalidFileFilter = 8517 ' (&H2145) The file filter is invalid, or in an invalid format. 
Global Const rptErrInvalidFileVersion = 8511 ' (&H213F) The file version is invalid. 
Global Const rptErrInvalidKey = 8504 ' (&H2138) The key is invalid. 
Global Const rptErrInvalidName = 8503 ' (&H2137) The name is invalid. 
Global Const rptErrInvalidPropertyValue = 380 ' (&H17C) A property value is invalid. 
Global Const rptErrInvalidRowIndex = 8524 ' (&H214C) The row index is invalid. 
Global Const rptErrInvalidRowset = 8522 ' (&H214A) The rowset is invalid. 
Global Const rptErrInvalidTemplate = 8516 ' (&H2144) The ExportFormat template is invalid. 
Global Const rptErrKeyNotFound = 8501 ' (&H2135) The key can't be found. 
Global Const rptErrLineBreak = 8553 ' (&H2169) An error occurred wrapping lines of text in the control. 
Global Const rptErrMarginsTooTall = 8541 ' (&H215D) Top and bottom margins are higher than the paper height. 
Global Const rptErrMarginsTooWide = 8540 ' (&H215C) Left and right margins are wider than the paper width. 
Global Const rptErrNotAllowedInReportGenerating = 8576 ' (&H2180) This property or method cannot be accessed during the generation of the report. 
Global Const rptErrObjectNotFoundInCollection = 8574 ' (&H217E) The object can't be found in the collection. 
Global Const rptErrOutOfMemory = 7 ' Out of memory. 
Global Const rptErrPathNotFound = 8514 ' (&H2142) The path can't be found. 
Global Const rptErrPrint = 8558 ' (&H216E) An error occurred during printing. 
Global Const rptErrPrinterInfo = 8555 ' (&H216B) Error obtaining printer information. 
Global Const rptErrPrintInit = 8557 ' (&H216D) An error occurred initializing the printer. 
Global Const rptErrReportTooTall = 8571 ' (&H217B) Sections do not fit vertically on the page. 
Global Const rptErrReportTooWide = 8542 ' (&H215E) Report width is larger than the paper width. 
Global Const rptErrSectDontMatchData = 8570 ' (&H217A) Report sections do not match data source. 
Global Const rptErrSharingViolation = 8515 ' (&H2143) Cannot access the file because it is being used by another process. 
Global Const rptErrSubscriptRange = 9 ' The subscript is out of range. 
Global Const rptErrTempFileName = 8550 ' (&H2166) Error generating temporary filename. 
Global Const rptErrTempFileRead = 8554 ' (&H216A) Error opening or reading from temporary file. 
Global Const rptErrTempFileWrite = 8552 ' (&H2168) Error creating or writing to temporary file. 
Global Const rptErrTypeMismatch = 13 ' Type mismatch. 
Global Const rptErrUnexpected = 8505 ' (&H2139) Unexpected error. 
Global Const rptErrUnknown = 8502 ' (&H2136) General error. 


' ExportFormat Constants
Global Const rptFmtHTML = 0 ' HTML format. 
Global Const rptFmtText = 1 ' Text format. 
Global Const rptFmtUnicodeText = 2 ' Unicode. 
Global Const rptFmtUnicodeHTML_UTF8 = 3 ' HTML encoded in Universal Character Set (UTF - 8) 


' FunctionType Constants
Global Const rptFuncSum = 0 ' Sum function. 
Global Const rptFuncAve = 1 ' Average. 
Global Const rptFuncMin = 2 ' Minimum 
Global Const rptFuncMax = 3 ' Maximum. 
Global Const rptFuncRCnt = 4 ' Counts the rows in the section. 
Global Const rptFuncVCnt = 5 ' Counts the fields with non-null values. 
Global Const rptFuncSDEV = 6 ' Calculates the standard deviation. 
Global Const rptFuncSERR = 7 ' Calculates the standard error. 


' LineSlant Constants
Global Const rptSlantNWSE = 0 ' Line slants from northwest to southeast. 
Global Const rptSlantNESW = 1 ' Line slants from northeast to southwest. 


' PageBreak Constants
Global Const rptPageBreakNone = 0 ' No page breaks on the section. 
Global Const rptPageBreakBefore = 1 ' Page break occurs before the section. 
Global Const rptPageBreakAfter = 2 ' Page break occurs after the section. 
Global Const rptPageBreakBeforeAndAfter = 3 ' Page break occurs before and after the section. 


' PageRange Constants
Global Const rptRangeAllPages = 0 ' Print or export all pages. 
Global Const rptRangeFromTo = 1 ' Print or export only the named range of pages. 


' PictureAlignment Constants
Global Const rptPATopLeft = 0 ' The picture appears at the top left. 
Global Const rptPATop = 1 ' The picture appears at the top. 
Global Const rptPATopRight = 2 ' The picture appears at the top right. 
Global Const rptPARight = 3 ' The picture appears at the right. 
Global Const rptPABottomRight = 4 ' The picture appears at the bottom right. 
Global Const rptPABottom = 5 ' The picture appears at the bottom. 
Global Const rptPABottomLeft = 6 ' The picture appears at the bottom left. 
Global Const rptPALeft = 7 ' The picture appears at the left. 
Global Const rptPACenter = 8 ' The picture appears centered. 


' Shape Constants
Global Const rptShpRectangle = 0 ' Rectangle shape. 
Global Const rptShpSquare = 1 ' Square shape. 
Global Const rptShpOval = 2 ' Oval shape. 
Global Const rptShpCircle = 3 ' Circle shape. 
Global Const rptShpRoundedRectangle = 4 ' Rounded rectangle shape. 
Global Const rptShpRoundedSquare = 5 ' Rounded square shape. 



'1 DDE Constants

'linkerr (LinkError Event)
Global Const vbWrongFormat = 1 ' Another application requested data in wrong format 
Global Const vbDDESourceClosed = 6 ' Destination application attempted to continue after source closed 
Global Const vbTooManyLinks = 7 ' All source links are in use 
Global Const vbDataTransferFailed = 8 ' Failure to update data in destination 


' LinkMode Property (Forms and Controls)
Global Const vbLinkNone = 0 ' None 
Global Const vbLinkSource = 1 ' Source (forms only) 
Global Const vbLinkAutomatic = 1 ' Automatic (controls only) 
Global Const vbLinkManual = 2 ' Manual (controls only) 
Global Const vbLinkNotify = 3 ' Notify (controls only) 


' LinkMode Property 
' (Only for backward compatibility with Visual Basic version 1.0; use new constants instead)
Global Const vbHot = 1 ' Hot (controls only) 
Global Const vbServer = 1 ' Server (forms only) 
Global Const vbCold = 2 ' Cold (controls only) 


'1 Drag-and-Drop Constants

' DragOver and OLEDragOver Event
Global Const vbEnter = 0 ' Source control dragged into target 
Global Const vbLeave = 1 ' Source control dragged out of target 
Global Const vbOver = 2 ' Source control dragged from one position in target to another 


' Drag Method (Controls)
Global Const vbCancel = 0 ' Cancel drag operation 
Global Const vbBeginDrag = 1 ' Begin dragging control 
Global Const vbEndDrag = 2 ' Drop control 


' DragMode Property
Global Const vbManual = 0 ' Manual 
Global Const vbAutomatic = 1 ' Automatic 


' OLEDragMode Property
Global Const vbOLEDragManual = 0 ' Manual 
Global Const vbOLEDragAutomatic = 1 ' Automatic 


' OLEDropMode Property
Global Const vbOLEDropNone = 0 ' None 
Global Const vbOLEDropManual = 1 ' Manual 
Global Const vbOLEDropAutomatic = 2 ' Automatic 


' OLE Drop Effect
Global Const vbOLEDropEffectNone = 0 ' No OLE drag/drop operation has taken place 
Global Const vbOLEDropEffectCopy = 1 ' A mask indicating that a copy operation has taken, or would take, place 
Global Const vbOLEDropEffectMove = 2 ' A mask indicating that a move operation has taken, or would take, place 
Global Const vbOLEDropEffectScroll = &H80000000 ' A mask indicating that the drop target window has scrolled, or will scroll 


'1 Drawing Constants

' DrawMode Property
Global Const vbBlackness = 1 ' Black 
Global Const vbNotMergePen = 2 ' Not Merge pen 
Global Const vbMaskNotPen = 3 ' Mask Not pen 
Global Const vbNotCopyPen = 4 ' Not Copy pen 
Global Const vbMaskPenNot = 5 ' Mask pen Not 
Global Const vbInvert = 6 ' Invert 
Global Const vbXorPen = 7 ' Xor pen 
Global Const vbNotMaskPen = 8 ' Not Mask pen 
Global Const vbMaskPen = 9 ' Mask pen 
Global Const vbNotXorPen = 10 ' Not Xor pen 
Global Const vbNop = 11 ' No operation; output remains unchanged 
Global Const vbMergeNotPen = 12 ' Merge Not pen 
Global Const vbCopyPen = 13 ' Copy pen 
Global Const vbMergePenNot = 14 ' Merge pen Not 
Global Const vbMergePen = 15 ' Merge pen 
Global Const vbWhiteness = 16 ' White 


' DrawStyle Property
Global Const vbSolid = 0 ' Solid 
Global Const vbDash = 1 ' Dash 
Global Const vbDot = 2 ' Dot 
Global Const vbDashDot = 3 ' Dash-dot 
Global Const vbDashDotDot = 4 ' Dash-dot-dot 
Global Const vbInvisible = 5 ' Invisible 
Global Const vbInsideSolid = 6 ' Inside solid 


' DriveType Constants
Global Const Unknown = 0 ' Drive type can't be determined. 
Global Const Removable = 1 ' Drive has removable media. This includes all floppy drives and many other varieties of storage devices. 
Global Const Fixed = 2 ' Drive has fixed (nonremovable) media. This includes all hard drives, including hard drives that are removable. 
Global Const Remote = 3 ' Network drives. This includes drives shared anywhere on a network. 
Global Const CDROM = 4 ' Drive is a CD-ROM. No distinction is made between read-only and read/write CD-ROM drives. 
Global Const RAMDisk = 5 ' Drive is a block of Random Access Memory (RAM) on the local computer that behaves like a disk drive. 


' File Attribute Constants
Global Const Normal = 0 ' Normal file. No attributes are set. 
Global Const ReadOnly = 1 ' Read-only file. Attribute is read/write. 
Global Const Hidden = 2 ' Hidden file. Attribute is read/write. 
Global Const System = 4 ' System file. Attribute is read/write. 
Global Const Volume = 8 ' Disk drive volume label. Attribute is read-only. 
Global Const Directory = 16 ' Folder or directory. Attribute is read-only. 
Global Const Archive = 32 ' File has changed since last backup. Attribute is read/write. 
Global Const Alias = 64 ' Link or shortcut. Attribute is read-only. 
Global Const Compressed = 128 ' Compressed file. Attribute is read-only. 


' File Input/Output Constants
Global Const ForReading = 1 ' Open a file for reading only. You can't write to this file. 
Global Const ForWriting = 2 ' Open a file for writing. If a file with the same name exists, its previous contents are overwritten. 
Global Const ForAppending = 8 ' Open a file and write to the end of the file. 


'1 Graphics Constants

' FillStyle Property
Global Const vbFSSolid = 0 ' Solid 
Global Const vbFSTransparent = 1 ' Transparent 
Global Const vbHorizontalLine = 2 ' Horizontal line 
Global Const vbVerticalLine = 3 ' Vertical line 
Global Const vbUpwardDiagonal = 4 ' Upward diagonal 
Global Const vbDownwardDiagonal = 5 ' Downward diagonal 
Global Const vbCross = 6 ' Cross 
Global Const vbDiagonalCross = 7 ' Diagonal cross 


' ScaleMode Property
Global Const vbUser = 0 ' User 
Global Const vbTwips = 1 ' Twips 
Global Const vbPoints = 2 ' Points 
Global Const vbPixels = 3 ' Pixels 
Global Const vbCharacters = 4 ' Characters 
Global Const vbInches = 5 ' Inches 
Global Const vbMillimeters = 6 ' Millimeters 
Global Const vbCentimeters = 7 ' Centimeters 
Global Const vbHiMetric = 8 ' HiMetric 
Global Const vbContainerPosition = 9 ' Units used by the control's container to determine the control's position 
Global Const vbContainerSize = 10 ' Units used by the control's container to determine the control's size 


' PaletteMode Property
Global Const vbPaletteModeHalfTone = 0 ' Use system halftone palette 
Global Const vbPaletteModeUseZOrder = 1 ' Use palette from topmost control that has a palette 
Global Const vbPaletteModeCustom = 2 ' Use palette specified in Palette property 
Global Const vbPaletteModeContainer = 3 ' Use the container's palette for containers that support ambient Palette property 
Global Const vbPaletteModeNone = 4 ' Do not use any palette 
Global Const vbPaletteModeObject = 5 ' Use the ActiveX designer's palette 


' Help Constants
Global Const cdlHelpContext = &H1 ' Displays Help for a particular topic 
Global Const cdlHelpQuit = &H2 ' Notifies the Help application that the specified Help file is no longer in use 
Global Const cdlHelpIndex = &H3 ' Displays the index of the specified Help file 
Global Const cdlHelpContents = &H3 ' Displays the contents topic in the current Help file 
Global Const cdlHelpHelpOnHelp = &H4 ' Displays Help for using the Help application itself 
Global Const cdlHelpSetIndex = &H5 ' Sets the current index for multi-index Help 
Global Const cdlHelpSetContents = &H5 ' Designates a specific topic as the contents topic 
Global Const cdlHelpContextPopup = &H8 ' Displays a topic identified by a context number 
Global Const cdlHelpForceFile = &H9 ' Creates a Help file that displays text in only one font 
Global Const cdlHelpKey = &H101 ' Displays Help for a particular keyword 
Global Const cdlHelpCommandHelp = &H102 ' Displays Help for a particular command 
Global Const cdlHelpPartialKey = &H105 ' Calls the search engine in Windows Help 


'1 Key Code Constants

Global Const vbKeyLButton = 1 ' Left mouse button 
Global Const vbKeyRButton = 2 ' Right mouse button 
Global Const vbKeyCancel = 3 ' CANCEL key 
Global Const vbKeyMButton = 4 ' Middle mouse button 
Global Const vbKeyBack = 8 ' BACKSPACE key 
Global Const vbKeyTab = 9 ' TAB key 
Global Const vbKeyClear = 12 ' CLEAR key 
Global Const vbKeyReturn = 13 ' ENTER key 
Global Const vbKeyShift = 16 ' SHIFT key 
Global Const vbKeyControl = 17 ' CTRL key 
Global Const vbKeyMenu = 18 ' MENU key 
Global Const vbKeyPause = 19 ' PAUSE key 
Global Const vbKeyCapital = 20 ' CAPS LOCK key 
Global Const vbKeyEscape = 27 ' ESC key 
Global Const vbKeySpace = 32 ' SPACEBAR key 
Global Const vbKeyPageUp = 33 ' PAGE UP key 
Global Const vbKeyPageDown = 34 ' PAGE DOWN key 
Global Const vbKeyEnd = 35 ' END key 
Global Const vbKeyHome = 36 ' HOME key 
Global Const vbKeyLeft = 37 ' LEFT ARROW key 
Global Const vbKeyUp = 38 ' UP ARROW key 
Global Const vbKeyRight = 39 ' RIGHT ARROW key 
Global Const vbKeyDown = 40 ' DOWN ARROW key 
Global Const vbKeySelect = 41 ' SELECT key 
Global Const vbKeyPrint = 42 ' PRINT SCREEN key 
Global Const vbKeyExecute = 43 ' EXECUTE key 
Global Const vbKeySnapshot = 44 ' SNAPSHOT key 
Global Const vbKeyInsert = 45 ' INS key 
Global Const vbKeyDelete = 46 ' DEL key 
Global Const vbKeyHelp = 47 ' HELP key 
Global Const vbKeyNumlock = 144 ' NUM LOCK key 


' KeyA Through KeyZ Are the Same as Their ASCII Equivalents: 'A' Through 'Z'
Global Const vbKeyA = 65 ' A key 
Global Const vbKeyB = 66 ' B key 
Global Const vbKeyC = 67 ' C key 
Global Const vbKeyD = 68 ' D key 
Global Const vbKeyE = 69 ' E key 
Global Const vbKeyF = 70 ' F key 
Global Const vbKeyG = 71 ' G key 
Global Const vbKeyH = 72 ' H key 
Global Const vbKeyI = 73 ' I key 
Global Const vbKeyJ = 74 ' J key 
Global Const vbKeyK = 75 ' K key 
Global Const vbKeyL = 76 ' L key 
Global Const vbKeyM = 77 ' M key 
Global Const vbKeyN = 78 ' N key 
Global Const vbKeyO = 79 ' O key 
Global Const vbKeyP = 80 ' P key 
Global Const vbKeyQ = 81 ' Q key 
Global Const vbKeyR = 82 ' R key 
Global Const vbKeyS = 83 ' S key 
Global Const vbKeyT = 84 ' T key 
Global Const vbKeyU = 85 ' U key 
Global Const vbKeyV = 86 ' V key 
Global Const vbKeyW = 87 ' W key 
Global Const vbKeyX = 88 ' X key 
Global Const vbKeyY = 89 ' Y key 
Global Const vbKeyZ = 90 ' Z key 


' Key0 Through Key9 Are the Same as Their ASCII Equivalents: '0' Through '9
Global Const vbKey0 = 48 ' 0 key 
Global Const vbKey1 = 49 ' 1 key 
Global Const vbKey2 = 50 ' 2 key 
Global Const vbKey3 = 51 ' 3 key 
Global Const vbKey4 = 52 ' 4 key 
Global Const vbKey5 = 53 ' 5 key 
Global Const vbKey6 = 54 ' 6 key 
Global Const vbKey7 = 55 ' 7 key 
Global Const vbKey8 = 56 ' 8 key 
Global Const vbKey9 = 57 ' 9 key 


' Keys on the Numeric Keypad
Global Const vbKeyNumpad0 = 96 ' 0 key 
Global Const vbKeyNumpad1 = 97 ' 1 key 
Global Const vbKeyNumpad2 = 98 ' 2 key 
Global Const vbKeyNumpad3 = 99 ' 3 key 
Global Const vbKeyNumpad4 = 100 ' 4 key 
Global Const vbKeyNumpad5 = 101 ' 5 key 
Global Const vbKeyNumpad6 = 102 ' 6 key 
Global Const vbKeyNumpad7 = 103 ' 7 key 
Global Const vbKeyNumpad8 = 104 ' 8 key 
Global Const vbKeyNumpad9 = 105 ' 9 key 
Global Const vbKeyMultiply = 106 ' MULTIPLICATION SIGN (*) key 
Global Const vbKeyAdd = 107 ' PLUS SIGN (+) key 
Global Const vbKeySeparator = 108 ' ENTER (keypad) key 
Global Const vbKeySubtract = 109 ' MINUS SIGN (-) key 
Global Const vbKeyDecimal = 110 ' DECIMAL POINT(.) key 
Global Const vbKeyDivide = 111 ' DIVISION SIGN (/) key 


' Function Keys
Global Const vbKeyF1 = 112 ' F1 key 
Global Const vbKeyF2 = 113 ' F2 key 
Global Const vbKeyF3 = 114 ' F3 key 
Global Const vbKeyF4 = 115 ' F4 key 
Global Const vbKeyF5 = 116 ' F5 key 
Global Const vbKeyF6 = 117 ' F6 key 
Global Const vbKeyF7 = 118 ' F7 key 
Global Const vbKeyF8 = 119 ' F8 key 
Global Const vbKeyF9 = 120 ' F9 key 
Global Const vbKeyF10 = 121 ' F10 key 
Global Const vbKeyF11 = 122 ' F11 key 
Global Const vbKeyF12 = 123 ' F12 key 
Global Const vbKeyF13 = 124 ' F13 key 
Global Const vbKeyF14 = 125 ' F14 key 
Global Const vbKeyF15 = 126 ' F15 key 
Global Const vbKeyF16 = 127 ' F16 key 


'1 Miscellaneous Constants

' AsyncRead Method
Global Const vbAsyncTypePicture = 0 ' Data is provided in a Picture object 
Global Const vbAsyncTypeFile = 1 ' Data is provided in a file provide by Visual Basic 
Global Const vbAsyncTypeByteArray = 2 ' Data is provided in a byte array that contains the retrieved data 


' Application Start Mode
Global Const vbSModeStandalone = 0 ' Stand-alone application 
Global Const vbSModeAutomation = 1 ' Automated ActiveX component 


' Buttons (Applies to CommandButton, CheckBox, and OptionButton controls)
Global Const vbButtonStandard = 0 ' Buttons have standard Windows appearance 
Global Const vbButtonGraphical = 1 ' Buttons have graphical appearance (that is, they contain pictures, text, and/or a non-standard BackColor) 


' LoadResPicture Method
Global Const vbResBitmap = 0 ' Bitmap resource 
Global Const vbResIcon = 1 ' Icon resource 
Global Const vbResCursor = 2 ' Cursor resource 


' LogEvent Method
Global Const vbLogEventTypeError = 1 ' Log an Error event 
Global Const vbLogEventTypeWarning = 2 ' Log a Warning event 
Global Const vbLogEventTypeInformation = 4 ' Log an Information event 


' Mouse Button Parameter Masks
Global Const vbLeftButton = 1 ' Left mouse button 
Global Const vbRightButton = 2 ' Right mouse button 
Global Const vbMiddleButton = 4 ' Middle mouse button 


' QueryUnload Method
Global Const vbAppWindows = 2 ' Current Windows session ending 
Global Const vbFormMDIForm = 4 ' MDI child form is closing because the MDI form is closing 
Global Const vbFormCode = 1 ' Unload method invoked from code 
Global Const vbFormControlMenu = 0 ' User has chosen Close command from the Control-menu box on a form 
Global Const vbAppTaskManager = 3 ' Windows Task Manager is closing the application 


' Shift Parameter Masks
Global Const vbShiftMask = 1 ' SHIFT key bit mask 
Global Const vbCtrlMask = 2 ' CTRL key bit mask 
Global Const vbAltMask = 4 ' ALT key bit mask 


' ZOrder Method
Global Const vbBringToFront = 0 ' Bring to front 
Global Const vbSendToBack = 1 ' Send to back 


' Mouse Pointer Constants
Global Const vbDefault = 0 ' Default 
Global Const vbArrow = 1 ' Arrow 
Global Const vbCrosshair = 2 ' Cross 
Global Const vbIbeam = 3 ' I beam 
Global Const vbIconPointer = 4 ' Icon 
Global Const vbSizePointer = 5 ' Size 
Global Const vbSizeNESW = 6 ' Size NE, SW 
Global Const vbSizeNS = 7 ' Size N, S 
Global Const vbSizeNWSE = 8 ' Size NW, SE 
Global Const vbSizeWE = 9 ' Size W, E 
Global Const vbUpArrow = 10 ' Up arrow 
Global Const vbHourglass = 11 ' Hourglass 
Global Const vbNoDrop = 12 ' No drop 
Global Const vbArrowHourglass = 13 ' Arrow and hourglass 
Global Const vbArrowQuestion = 14 ' Arrow and question mark 
Global Const vbSizeAll = 15 ' Size all 
Global Const vbCustom = 99 ' Custom icon specified by the MouseIcon property 


' RasterOp Constants
Global Const vbDstInvert = &H00550009 ' Inverts the destination bitmap 
Global Const vbMergeCopy = &H00C000CA ' Combines the pattern and the source bitmap 
Global Const vbMergePaint = &H00BB0226 ' Combines the inverted source bitmap with the destination bitmap by using Or 
Global Const vbNotSrcCopy = &H00330008 ' Copies the inverted source bitmap to the destination 
Global Const vbNotSrcErase = &H001100A6 ' Inverts the result of combining the destination and source bitmaps by using Or 
Global Const vbPatCopy = &H00F00021L ' Copies the pattern to the destination bitmap 
Global Const vbPatInvert = &H005A0049L ' Combines the destination bitmap with the pattern by using Xor 
Global Const vbPatPaint = &H00FB0A09L ' Combines the inverted source bitmap with the pattern by using Or. Combines the result of this operation with the destination bitmap by using Or 
Global Const vbSrcAnd = &H008800C6 ' Combines pixels of the destination and source bitmaps by using And 
Global Const vbSrcCopy = &H00CC0020 ' Copies the source bitmap to the destination bitmap 
Global Const vbSrcErase = &H00440328 ' Inverts the destination bitmap and combines the result with the source bitmap by using And 
Global Const vbSrcInvert = &H00660046 ' Combines pixels of the destination and source bitmaps by using Xor 
Global Const vbSrcPaint = &H00EE0086 ' Combines pixels of the destination and source bitmaps by using Or 


' SpecialFolder Constants
Global Const WindowsFolder = 0 ' The Windows folder contains files installed by the Windows operating system. 
Global Const SystemFolder = 1 ' The System folder contains libraries, fonts, and device drivers. 
Global Const TemporaryFolder = 2 ' The Temp folder is used to store temporary files. Its path is found in the TMP environment variable. 


' StateManagement Property Constants
Global Const WcNoState = 1 ' The WebClass object will be instantiated and destroyed for every HTTP request that is processed. Any required state information must be stored externally, such as in a database, within the Session object, within the URL itself using the URLData property, or in cookies using the Response.Cookies collection.  
Global Const wcRetainInstance = 2 ' The WebClass object is instantiated when the first HTTP request is received and not destroyed until either the ReleaseInstance method is called or the session times out. State can be safely kept within properties of the WebClass object; however, this will increase the size and decrease the scalability of your application. 


' Tristate Constants
Global Const vbTrue = 1 ' True 
Global Const vbFalse = 0 ' False 
Global Const vbUseDefault = 2 ' Use default setting 


' Variant Type Constants
Global Const vbVEmpty = 0 ' Empty (uninitialized) 
Global Const vbVNull = 1 ' Null (no valid data) 
Global Const vbVInteger = 2 ' Integer data type 
Global Const vbVLong = 3 ' Long integer data type 
Global Const vbVSingle = 4 ' Single-precision floating-point data type 
Global Const vbVDouble = 5 ' Double-precision floating-point data type 
Global Const vbVCurrency = 6 ' Currency (scaled integer) data type 
Global Const vbVDate = 7 ' Date data type 
Global Const vbVString = 8 ' String data type 


' Menu Accelerator Constants
Global Const vbMenuAccelCtrlA = 1 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelCtrlB = 2 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelCtrlC = 3 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelCtrlD = 4 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelCtrlE = 5 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelCtrlF = 6 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelCtrlG = 7 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelCtrlH = 8 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelCtrlI = 9 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelCtrlJ = 10 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelCtrlK = 11 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelCtrlL = 12 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelCtrlM = 13 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelCtrlN = 14 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelCtrlO = 15 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelCtrlP = 16 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelCtrlQ = 17 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelCtrlR = 18 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelCtrlS = 19 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelCtrlT = 20 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelCtrlU = 21 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelCtrlV = 22 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelCtrlW = 23 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelCtrlX = 24 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelCtrlY = 25 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelCtrlZ = 26 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelF1 = 27 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelF2 = 28 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelF3 = 29 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelF4 = 30 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelF5 = 31 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelF6 = 32 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelF7 = 33 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelF8 = 34 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelF9 = 35 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelF11 = 36 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelF12 = 37 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelCtrlF1 = 38 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelCtrlF2 = 39 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelCtrlF3 = 40 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelCtrlF4 = 41 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelCtrlF5 = 42 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelCtrlF6 = 43 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelCtrlF7 = 44 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelCtrlF8 = 45 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelCtrlF9 = 46 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelCtrlF11 = 47 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelCtrlF12 = 48 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelShiftF1 = 49 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelShiftF2 = 50 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelShiftF3 = 51 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelShiftF4 = 52 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelShiftF5 = 53 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelShiftF6 = 54 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelShiftF7 = 55 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelShiftF8 = 56 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelShiftF9 = 57 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelShiftF11 = 58 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelShiftF12 = 59 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelShiftCtrlF1 = 60 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelShiftCtrlF2 = 61 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelShiftCtrlF3 = 62 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelShiftCtrlF4 = 63 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelShiftCtrlF5 = 64 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelShiftCtrlF6 = 65 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelShiftCtrlF7 = 66 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelShiftCtrlF8 = 67 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelShiftCtrlF9 = 68 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelShiftCtrlF11 = 69 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelShiftCtrlF12 = 70 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelCtrlIns = 71 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelShiftIns = 72 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelDel = 73 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelShiftDel = 74 ' User-defined shortcut keystrokes 
Global Const vbMenuAccelAltBksp = 75 ' User-defined shortcut keystrokes 

'1 Control Constants


' ComboBox Control
Global Const vbComboDropdown = 0 ' Dropdown Combo 
Global Const vbComboSimple = 1 ' Simple Combo 
Global Const vbComboDropdownList = 2 ' Dropdown List 


' CheckBox Control
Global Const vbUnchecked = 0 ' Unchecked 
Global Const vbChecked = 1 ' Checked 
Global Const vbGrayed = 2 ' Grayed 


' ListBox Control
Global Const vbListBoxStandard = 0 ' Standard Windows ListBox appearance 
Global Const vbListBoxCheckBox = 1 ' Listbox entries contain selectable CheckBoxes 
Global Const vbMultiSelectNone = 0 ' No multiple selection 
Global Const vbMultiSelectSimple = 1 ' Simple multiple selection 
Global Const vbMultiSelectExtended = 2 ' Extended multiple selection 


' ScrollBar Control
Global Const vbSBNone = 0 ' None 
Global Const vbHorizontal = 1 ' Horizontal 
Global Const vbVertical = 2 ' Vertical 
Global Const vbBoth = 3 ' Both 


' Shape Control
Global Const vbShapeRectangle = 0 ' Rectangle 
Global Const vbShapeSquare = 1 ' Square 
Global Const vbShapeOval = 2 ' Oval 
Global Const vbShapeCircle = 3 ' Circle 
Global Const vbShapeRoundedRectangle = 4 ' Rounded rectangle 
Global Const vbShapeRoundedSquare = 5 ' Rounded square 


'1 CommonDialog Control Constants


' File Open/Save Dialog Box Flags
Global Const cdlOFNAllowMultiselect = &H200 ' Specifies that the File Namelist box allows multiple selections.
Global Const cdlOFNCreatePrompt = &H2000 ' Specifies that the dialog box prompts the user to create a file that doesn't currently exist. This flag automatically sets the cdlOFNPathMustExist and cdlOFNFileMustExist flags. 
Global Const cdlOFNExplorer = &H80000 ' Use the Explorer-like Open A File dialog box template. Common dialogs that use this flag do not work under Windows NT using the Windows 95 shell. 
Global Const CdlOFNExtensionDifferent = &H400 ' Indicates that the extension of the returned filename is different from the extension specified by the DefaultExt property. This flag isn't set if the DefaultExt property is Null, if the extensions match, or if the file has no extension. This flag value can be checked upon closing the dialog box. 
Global Const cdlOFNFileMustExist = &H1000 ' Specifies that the user can enter only names of existing files in the File Name text box. If this flag is set and the user enters an invalid filename, a warning is displayed. This flag automatically sets the cdlOFNPathMustExist flag. 
Global Const cdlOFNHelpButton = &H10 ' Causes the dialog box to display the Help button. 
Global Const cdlOFNHideReadOnly = &H4 ' Hides the Read Onlycheck box. 
Global Const cdlOFNLongNames = &H200000 ' Use long filenames. 
Global Const cdlOFNNoChangeDir = &H8 ' Forces the dialog box to set the current directory to what it was when the dialog box was opened. 
Global Const CdlOFNNoDereferenceLinks = &H100000 ' Do not dereference shell links (also known as shortcuts). By default, choosing a shell link causes it to be dereferenced by the shell. 
Global Const cdlOFNNoLongNames = &H40000 'Do not use long file names. 
Global Const CdlOFNNoReadOnlyReturn = &H8000  ' Specifies that the returned file won't have the Read Only attribute set and won't be in a write-protected directory. 
Global Const cdlOFNNoValidate = &H100 ' Specifies that the common dialog box allows invalid characters in the returned filename. 
Global Const cdlOFNOverwritePrompt = &H2 ' Causes the Save As dialog box to generate a message box if the selected file already exists. The user must confirm whether to overwrite the file. 
Global Const cdlOFNPathMustExist = &H800 ' Specifies that the user can enter only validpaths. If this flag is set and the user enters an invalid path, a warning message is displayed. 
Global Const cdlOFNReadOnly = &H1 ' Causes the Read Only check box to be initially checked when the dialog box is created. This flag also indicates the state of the Read Only check box when the dialog box is closed. 
Global Const CdlOFNShareAware = &H4000 ' Specifies that sharing violation errors will be ignored. 


' Color Dialog Box Flags
Global Const cdlCCFullOpen = &H2 ' Entire dialog box is displayed, including the Define Custom Colors section 
Global Const cdlCCShowHelp = &H8 ' Causes the dialog box to display a Help button 
Global Const cdlCCPreventFullOpen = &H4 ' Disables the Define Custom Colors command button and prevents the user from defining custom colors 
Global Const cdlCCRGBInit = &H1 ' Sets the initial color value for the dialog box 


' Fonts Dialog Box Flags
Global Const cdlCFANSIOnly = &H400 ' Specifies that the dialog box allows only a selection of the fonts that use the Windows character set. If this flag is set, the user won't be able to select a font that contains only symbols. 
Global Const cdlCFApply = &H200 ' Enables the Apply button on the dialog box. 
Global Const cdlCFBoth = &H3 ' Causes the dialog box to list the available printer and screen fonts. The hDC property identifies thedevice context associated with the printer. 
Global Const cdlCFEffects = &H100 ' Specifies that the dialog box enables strikethrough, underline, and color effects. 
Global Const cdlCFFixedPitchOnly = &H4000 ' Specifies that the dialog box selects only fixed-pitch fonts. 
Global Const cdlCFForceFontExist = &H10000 ' Specifies that an error message box is displayed if the user attempts to select a font or style that doesn't exist. 
Global Const cdlCFHelpButton = &H4 ' Causes the dialog box to display a Help button. 
Global Const cdlCFLimitSize = &H2000 ' Specifies that the dialog box selects only font sizes within the range specified by the Min and Max properties. 
Global Const cdlCFNoFaceSel = &H80000 ' No font name selected. 
Global Const cdlCFNoSimulations = &H1000 ' Specifies that the dialog box doesn't allow graphic device interface (GDI) font simulations. 
Global Const cdlCFNoSizeSel = &H200000 ' No font size selected. 
Global Const cdlCFNoStyleSel = &H100000 ' No style was selected. 
Global Const cdlCFNoVectorFonts = &H800 ' Specifies that the dialog box doesn't allow vector-font selections. 
Global Const cdlCFPrinterFonts = &H2 ' Causes the dialog box to list only the fonts supported by the printer, specified by the hDC property. 
Global Const cdlCFScalableOnly = &H20000 ' Specifies that the dialog box allows only the selection of fonts that can be scaled.  
Global Const cdlCFScreenFonts = &H1 ' Causes the dialog box to list only the screen fonts supported by the system. 
Global Const cdlCFTTOnly = &H40000 ' Specifies that the dialog box allows only the selection of TrueType fonts. 
Global Const cdlCFWYSIWYG = &H8000 ' Specifies that the dialog box allows only the selection of fonts that are available on both the printer and on screen. If this flag is set, the cdlCFBoth and cdlCFScalableOnly flags should also be set. 


' Printer Dialog Box Flags
Global Const cdlPDAllPages = &H0 ' Returns or sets the state of the All Pagesoption button. 
Global Const cdlPDCollate = &H10 ' Returns or sets the state of the Collatecheck box. 
Global Const cdlPDDisablePrintToFile = &H80000 ' Disables the Print To File check box. 
Global Const cdlPDHelpButton = &H800 ' Causes the dialog box to display the Help button. 
Global Const cdlPDHidePrintToFile = &H100000 ' Hides the Print To File check box. 
Global Const cdlPDNoPageNums = &H8 ' Disables the Pages option button and the associated edit control. 
Global Const cdlPDNoSelection = &H4 ' Disables the Selection option button. 
Global Const cdlPDNoWarning = &H80 ' Prevents a warning message from being displayed when there is no default printer. 
Global Const cdlPDPageNums = &H2 ' Returns or sets the state of the Pages option button. 
Global Const cdlPDPrintSetup = &H40 ' Causes the system to display the Print Setup dialog box rather than the Print dialog box. 
Global Const cdlPDPrintToFile = &H20 ' Returns or sets the state of the Print To File check box. 
Global Const cdlPDReturnDC = &H100 ' Returns adevice context for the printer selection made in the dialog box. The device context is returned in the dialog box's hDC property. 
Global Const cdlPDReturnDefault = &H400 ' Returns default printer name. 
Global Const cdlPDReturnIC = &H200 ' Returns an information context for the printer selection made in the dialog box. An information context provides a fast way to get information about the device without creating a device context. The information context is returned in the dialog box's hDC property. 
Global Const cdlPDSelection = &H1 ' Returns or sets the state of the Selection option button. If neither cdlPDPageNums nor cdlPDSelection is specified, the All option button is in the selected state. 
Global Const cdlPDUseDevModeCopies = &H40000 ' If a printer driver doesn't support multiple copies, setting this flag disables the copies edit control. If a driver does support multiple copies, setting this flag indicates that the dialog box stores the requested number of copies in the Copies property. 


' Help Constants
Global Const cdlHelpCommandHelp = &H102 ' Displays Help for a particular command 
Global Const cdlHelpContents = &H3 ' Displays the contents topic in the current Help file 
Global Const cdlHelpContext = &H1 ' Displays Help for a particular topic 
Global Const cdlHelpContextPopup = &H8 ' Displays a topic identified by a context number 
Global Const cdlHelpForceFile = &H9 ' Creates a Help file that displays text in only one font 
Global Const cdlHelpHelpOnHelp = &H4 ' Displays Help for using the Help application itself 
Global Const cdlHelpIndex = &H3 ' Displays the index of the specified Help file 
Global Const cdlHelpKey = &H101 ' Displays Help for a particular keyword 
Global Const cdlHelpPartialKey = &H105 ' Calls the search engine in Windows Help 
Global Const cdlHelpQuit = &H2 ' Notifies the Help application that the specified Help file is no longer in use 
Global Const cdlHelpSetContents = &H5 ' Designates a specific topic as the contents topic 
Global Const cdlHelpSetIndex = &H5 ' Sets the current index for multi-index Help 


' CommonDialog Error Constants
Global Const cdlAlloc = &H7FF0 ' Couldn't allocate memory for FileName or Filter property 
Global Const cdlCancel = &H7FF3 ' Cancel was selected 
Global Const cdlDialogFailure = &H8000 ' The function failed to load the dialog box 
Global Const cdlFindResFailure = &H7FF9 ' The function failed to load a specified resource 
Global Const cdlHelp = &H7FEF ' Call to Windows Help failed 
Global Const cdlInitialization = &H7FFD ' The function failed during initialization 
Global Const cdlLoadResFailure = &H7FF8 ' The function failed to load a specified string 
Global Const cdlLockResFailure = &H7FF7 ' The function failed to lock a specified resource 
Global Const cdlMemAllocFailure = &H7FF6 ' The function was unable to allocate memory for internal data structures 
Global Const cdlMemLockFailure = &H7FF5 ' The function was unable to lock the memory associated with a handle 
Global Const cdlNoFonts = &H5FFE ' No fonts exist 
Global Const cdlBufferTooSmall = &H4FFC ' The buffer at which the member lpstrFile points is too small 
Global Const cdlInvalidFileName = &H4FFD ' Filename is invalid 
Global Const cdlSubclassFailure = &H4FFE ' An attempt to subclass a list box failed due to insufficient memory 
Global Const cdlCreateICFailure = &H6FF5 ' The PrintDlg function failed when it attempted to create an information context 
Global Const cdlDndmMismatch = &H6FF6 ' Data in the DevMode and DevNames data structures describe two different printers 
Global Const cdlGetDevModeFail = &H6FFA ' The printer device driver failed to initialize a DevMode data structure 
Global Const cdlInitFailure = &H6FF9 ' The PrintDlg function failed during initialization 
Global Const cdlLoadDrvFailure = &H6FFB ' The PrintDlg function failed to load the specified printer's device driver 
Global Const cdlLoadStrFailure = &H7FFA ' The function failed to load a specified string. 
Global Const cdlNoDefaultPrn = &H6FF7 ' A default printer doesn't exist 
Global Const cdlNoDevices = &H6FF8 ' No printer device drivers were found 
Global Const cdlParseFailure = &H6FFD ' The CommonDialog function failed to parse the strings in the [devices] section of registry 
Global Const cdlPrinterCodes = &H6FFF ' The PDReturnDefault flag was set, but either the hDevMode or hDevNames field was nonzero 
Global Const cdlPrinterNotFound = &H6FF4 ' The [devices] section of the registry doesn't contain an entry for the requested printer 
Global Const cdlRetDefFailure = &H6FFC ' The PDReturnDefault flag was set, but either the hDevMode or hDevNames field was nonzero 
Global Const cdlSetupFailure = &H6FFE ' Failed to load required resources 


'1 ADO Data Control Constants


' Appearance Constants
Global Const adFlatBevel = 0 ' Flat bevel 
Global Const ad3Dbevel = 1 ' 3D bevel 


' BOFAction Constants
Global Const adDoMoveFirst = 0 ' Move to the first record 
Global Const adStayBOF = 1 ' Remain at the beginning 


' CommandType Constants
Global Const adCmdText = 1 ' Text 
Global Const adCmdTable = 2 ' Table 
Global Const adCmdStoredProc = 4 ' Stored procedure 
Global Const adCmdUnknown = 8 ' Unknown 


' Mode Constants
Global Const adModeUnknown = 0 ' Unknown 
Global Const adModeRead = 1 ' Read 
Global Const adModeWrite = 2 ' Write 
Global Const adModeReadWrite = 3 ' Read/Write 
Global Const adModeShareDenyRead = 4 ' DenyRead 
Global Const adModeShareDenyWrite = 8 ' DenyWrite 
Global Const adModeShareExclusive = 12 ' Exclusive 
Global Const adModeShareDenyNone = 16 ' DenyNone 


' ConnectionString Constants
Global Const adConnectStringTypeUnknown = 0 ' Unknown. 
Global Const adOLEDB = 1 ' OLEDB connection string. 
Global Const adOLEDBFile = 2 ' Use OLEDB file. 
Global Const adODBC = 3 ' Use ODBC. 


' CursorLocation Constants
Global Const adUseServer = 2 ' Use server cursors 
Global Const adUseClient = 3 ' Use client batch cursors 


' CursorType Constants
Global Const adOpenKeyset = 1 ' Keyset Cursor 
Global Const adOpenDynamic = 2 ' Dynamic Cursor 
Global Const adOpenStatic = 3 ' Static Cursor 


' EOFAction Constants
Global Const adDoMoveLast = 0 ' Move to last record 
Global Const adStayEOF = 1 ' Stay at the EOF 
Global Const adDoAddNew = 2 ' Add a new record 


' EventReason Constants
Global Const adRsnAddNew = 1 ' New record to be added. 
Global Const adRsnDelete = 2 ' Record deleted. 
Global Const adRsnUpdate = 3 ' Record to be updated. 
Global Const adRsnUndoUpdate = 4 ' Undo update. 
Global Const adRsnUndoAddNew = 5 ' Undo add new record. 
Global Const adRsnUndoDelete = 6 ' Undo delete. 
Global Const adRsnRequery = 7 ' Requery 
Global Const adRsnResynch = 8 ' Resynchronize 
Global Const adRsnClose = 9 ' Close 
Global Const adRsnMove = 10 ' Move 


' EventStatus Constants
Global Const adStatusOK = 1 ' OK 
Global Const adStatusErrorsOccurred = 2 ' Errors occurred. 
Global Const adStatusCantDeny = 3 '  
Global Const adStatusCancel = 4 ' Cancel 
Global Const adStatusUnwantedEvent = 5 '  


' LockType Constants
Global Const adLockUnspecified = -1 'Unspecified LockType 
Global Const adLockReadOnly = 1 ' ReadOnly LockType 
Global Const adLockPessimistic = 2 ' Pessimistic LockType 
Global Const adLockOptimistic = 3 ' Optimistic LockType 
Global Const adLockBatchOptimistic = 4 ' BatchOptimistic LockType 


' Orientation Constants
Global Const adHorizontal = 0 ' Horizontal orientation 
Global Const adVertical = 1 ' Vertical orientation 


'1 DataGrid Control Constants


' AddNewMode Constants
Global Const dbgNoAddNew = 0 ' No AddNew 
Global Const dbgAddNewCurrent = 1 ' AddNew current 
Global Const dbgAddNewPending = 2 ' AddNew pending 


' Alignment Constants
Global Const dbgLeft = 0 ' Left 
Global Const dbgRight = 1 ' Right 
Global Const dbgCenter = 2 ' Center 
Global Const dbgGeneral = 3 ' General 


' Appearance Constants
Global Const dbgFlat = 0 ' Flat appearance 
Global Const dbg3D = 1 ' 3D appearance 


' BorderStyle Constants
Global Const dbgNoBorder = 0 ' None 
Global Const dbgFixedSingle = 1 ' FixedSingle 


' DividerStyle Constants
Global Const dbgNoDividers = 0 ' No dividers 
Global Const dbgBlackLine = 1 ' Black line 
Global Const dbgDarkGrayLine = 2 ' Dark gray line 
Global Const dbgRaised = 3 ' Raised 
Global Const dbgInset = 4 ' Inset 
Global Const dbgUseForeColor = 5 ' Use forecolor 
Global Const dbgLightGrayLine = 6 ' Light gray line 


' Error Constants
Global Const dbgActionCanceled = 7011 ' Action is canceled 
Global Const dbgAddError = 6154 ' Error occurred while trying to add record 
Global Const dbgBadEvent = 6161 ' Operation is invalid within the event 
Global Const dbgBindError = 4097 ' Cannot initialize data bindings 
Global Const dbgCNotFound = 6147 ' Column not found 
Global Const dbgColIndex = 6145 ' Invalid column index 
Global Const dbgColReadOnly = 7010 ' The column is read only 
Global Const dbgConvertData = 7006 ' Data type conversion error 
Global Const dbgDataAccess = 6160 ' Data access error 
Global Const dbgDelError = 6155 ' Error occurred while trying to delete record 
Global Const dbgDelMultRows = 6159 ' Cannot delete multiple rows 
Global Const dbgErrorSetCurrent = 6152 ' Error occurred while trying to set current row 
Global Const dbgErrUpdateColumn = 7007 ' Error occurred while trying to update the column value 
Global Const dbgInvalidPropertyValue = 380 ' Invalid property value 
Global Const dbgInvalidSafeModeProcCall = 680 ' Invalid procedure call in safe mode 
Global Const dbgInvBookmark = 6149 ' Invalid bookmark 
Global Const dbgInvRowNum = 6148 ' Invalid row number 
Global Const dbgMustHaveSplit = 7002 ' Cannot delete last split 
Global Const dbgNoCurrentRow = 7008 ' The current row is not available 
Global Const dbgNoMethodNow = 7003 ' Method is not available in this context 
Global Const dbgNoPropNow = 6162 ' Property is not available in this context 
Global Const dbgNoRowFound = 7009 ' Cannot find the row 
Global Const dbgNoRowset = 7005 ' Rowset not available 
Global Const dbgNotBookmarkable = 7004 ' The rowset is not bookmarkable 
Global Const dbgOrphaned = 7000 ' Supporting object on the grid has been deleted 
Global Const dbgOutOfMemory = 7 ' Out of memory 
Global Const dbgScrollRange = 6151 ' Scroll arguments out of range 
Global Const dbgSplitIndex = 6244 ' Invalid split index 
Global Const dbgSubscriptRange = 9 ' Subscript out of range 
Global Const dbgTypeMismatch = 13 ' Type mismatch 
Global Const dbgUnknown = 7001 ' An unknown error code was received where it was not expected 
Global Const dbgUpdError = 6153 ' Error occurred while trying to update record 


' MarqueeStyle Constants
Global Const dbgDottedCellBorder = 0 ' Dotted cell border 
Global Const dbgSolidCellBorder = 1 ' Solid cell border 
Global Const dbgHighlightCell = 2 ' Highlight the cell 
Global Const dbgHighlightRow = 3 ' Highlight the row 
Global Const dbgHighlightRowRaiseCell = 4 ' Highlight row, raise cell 
Global Const dbgNoMarquee = 5 ' No marquee 
Global Const dbgFloatingEditor = 6 ' Floating editor 


' ScrollBar Constants
Global Const dbgNone = 0 ' None 
Global Const dbgHorizontal = 1 ' Horizontal 
Global Const dbgVertical = 2 ' Vertical 
Global Const dbgBoth = 3 ' Both 
Global Const dbgAutomatic = 4 ' Automatic 


' SplitSizeMode Constants
Global Const dbgScalable = 0 ' Scalable 
Global Const dbgExact = 1 ' Exact 


' TabAction Constants
Global Const dbgControlNavigation = 0 ' Control navigation 
Global Const dbgColumnNavigation = 1 ' Column navigation 
Global Const dbgGridNavigation = 2 ' Grid navigation 


'1 DataRepeater Control Constants


' Appearance Constants
Global Const drpflat = 0 ' Control appears flat. 
Global Const drp3D = 1 ' Control has 3D features. 


' BorderStyle Constants
Global Const drpNoBorder = 0 ' Control has no border. 
Global Const drpFixedSingle = 1 ' Control has a single line border 


' CaptionStyle Constants
Global Const drpNoCaption = 0 ' Caption is hidden. 
Global Const drpLeftAligned = 1 ' Caption is left-aligned. 
Global Const drpRightAligned = 2 ' Caption is right-aligned. 
Global Const drpCentered = 3 ' Caption is centered. 


' Error Constants
Global Const drpOutOfMemory = 7 ' Out of memory. 
Global Const drpTypeMismatch = 13 ' Type mismatch. 
Global Const drpObjVarNotSet = 91 ' (&H5B) Object variable or With block variable not set. 
Global Const drpInvalidPropertyValue = 380 ' (&H17C) Invalid property value. 
Global Const drpInvalidPropertyArrayIndex = 381 ' (&H17D) Invalid property array index. 
Global Const drpSetNotSupportedAtRuntime = 382 ' (&H17E) The property can't be set at run time. 
Global Const drpSetNotSupported = 383 ' (&H17F) Property is read-only. 
Global Const drpSetNotPermitted = 387 ' (&H183) Property can't be set on this control. 
Global Const drpGetNotSupported = 394 ' (&H18A) Property is write-only. 
Global Const drpObjectDoesntSupportProp = 438 ' (&H1B6) Object doesn't support this property or method. 
Global Const drpCreateRepeaterControl = 32000 ' (&H7D00) Unable to create RepeatedControl 
Global Const drpInvalidProgID = 32001 ' (&H7D01) Invalid ProgID or class object not supported. 
Global Const drpInvalidBookmark = 32002 ' (&H7D02) Invalid bookmark 
Global Const drpNoDataSource = 32003 ' (&H7D03) No datasource or datasource is empty. 
Global Const drpNoVisibleRows = 32004 ' (&H7D04) There are no visible rows. 
Global Const drpCantSetActiveRow = 32005 ' (&H7D05) The active row cannot be set without affecting the current record position. 
Global Const drpBadVisibleRecordIndex = 32006 ' (&H7D06) VisibleRecord index must be between zero and VisibleRows-1. 
Global Const drpInvalidRecordBookmark = 32007 ' (&H7D07) The bookmark is invalid or the corresponding record is no longer present. 
Global Const drpIndexOutOfBounds = 35600 ' (&H8B10) Index out of bounds. 
Global Const drpElemNotFound = 35601 ' (&H8B11) Element not found. 
Global Const drpNonUniqueKey = 35602 ' (&H8B12) Key is not unique in collection. 
Global Const drpInvalidKey = 35603 ' (&H8B13) Invalid key. 
Global Const drpElemNotPartOfCollection = 35605 ' (&H8B15) Object is no longer a collection member. 
Global Const drpCollectionChangedDuringEnum = 35606 ' (&H8B16) Control's collection has been modified. 
Global Const drpBadObjectReference = 35610 ' (&H8B1A) Invalid object. 
Global Const drpWouldIntroduceCycle = 35614 ' (&H8B1E) Action would introduce a cycle. 
Global Const drpCircularReference = 35700 ' (&H8B74) Circular object referencing is not allowed. 
Global Const drpPropertyNotBindable = 35701 ' (&H8B75) Property is not bindable. 
Global Const drpInvalidIndexOrKey = 35702 ' (&H8B76) Invalid index or key. 
Global Const drpAlreadyBound = 35703 ' (&H8B77) PropertyName already bound. 
Global Const drpInvalidPropertyName = 35704 ' (&H8B78) Invalid PropertyName. 
Global Const drpInvalidDataField = 35705 ' (&H8B79) Invalid DataField. 


' MousePointer Constants
Global Const drpDefault = 0 ' Default. 
Global Const drpArrow = 1 ' Arrow mouse pointer. 
Global Const drpCross = 2 ' Cross mouse pointer. 
Global Const drpIBeam = 3 ' I-Beam mouse pointer. 
Global Const drpIcon = 4 ' Icon mouse pointer. 
Global Const drpSize = 5 ' Size mouse pointer. 
Global Const drpSizeNESW = 6 ' Size NE SW mouse pointer. 
Global Const drpSizeNS = 7 ' Size N S mouse pointer. 
Global Const drpSizeNWSE = 8 ' Size NW SE mouse pointer. 
Global Const drpSizeEW = 9 ' Size W E mouse pointer. 
Global Const drpUpArrow = 10 ' Up arrow mouse pointer. 
Global Const drpHourglass = 11 ' Hourglass mouse pointer. 
Global Const drpNoDrop = 12 ' No drop mouse pointer. 
Global Const drpArrowHourglass = 13 ' Arrow and Hourglass mouse pointer 
Global Const drpArrowQuestion = 14 ' Arrow and Question mark mouse pointer. 
Global Const drpSizeAll = 15 ' Size all mouse pointer. 
Global Const drpCustom = 99 ' (&H63) Custom mouse pointer icon specified by the MouseIcon property. 


' RowDividerStyle Constants
Global Const drpNoDivider = 0 ' No line drawn between rows. 
Global Const drpFlatLine = 1 ' Flat line drawn between rows. 
Global Const drpInset = 2 ' 3D inset line drawn between rows. 
Global Const drpRaised = 3 ' 3D raised line drawn between rows. 


' Scrollbars Constants
Global Const drpNoScrollBars = 0 ' No scrollbars. 
Global Const drpHorizontal = 1 ' Horizontal scrollbars only. 
Global Const drpVertical = 2 ' Vertical scrollbars only. 
Global Const drpBoth = 3 ' Horizontal and Vertical scrollbars appear. 
Global Const drpAuto = 4 ' Scrollbars are drawn as required. 


'1 Masked Edit Control Constants


' Appearance Constants
Global Const mskFlat = 0 ' Flat. Paints controls and forms without visual effects. 
Global Const mskThreeD = 1 ' (Default) 3D. Paints controls with three-dimensional effects. 


' BorderStyle Constants
Global Const vbBSNone = 0 ' No border 
Global Const vbFixedSingle = 1 ' Fixed single 


' ClipBoard Constants
Global Const mskCFRTF = &HFFFFBF01 ' Rich Text Format (.rtf file) 
Global Const mskCFText = 1 ' Text (.txt file) 
Global Const mskCFBitmap = 2 ' Bitmap (.bmp file) 
Global Const mskCFMetafile = 3 ' Metafile (.wmf file) 
Global Const mskCFDIB = 8 ' Device-independent bitmap 
Global Const mskCFPalette = 9 ' Color palette 
Global Const mskCFEMetafile = 14 ' Extended Metafile (.emf file) 
Global Const mskCFFiles = 15 ' Filename list 


' ClipMode Constants
Global Const mskIncludeLiterals = 0 ' Include literals on cut or copy. 
Global Const mskExcludeLiterals = 1 ' Exclude literals on cut or copy. 


' DragOver Constants
Global Const mskEnter = 0 ' Source control dragged into target. 
Global Const mskLeave = 1 ' Source control dragged out of target. 
Global Const mskOver = 2 ' Source control dragged from one position in target to another. 


' Error Constants
Global Const mskDataObjectLocked = 672 ' DataObject formats list may not be cleared or expanded outside of the OLEStartDrag event. 
Global Const mskExpectedAnArgument = 673 ' Expected at least one argument. 
Global Const mskFormatNotByteArray = 675 ' Non-intrinsic OLE drag and drop formats used with SetData require Byte array data. GetData may return more bytes than were given to SetData. 
Global Const mskGetNotSupported = 394 ' Property is write-only. 
Global Const mskInvalidObjectUse = 425 ' Invalid object use. 
Global Const mskInvalidProcedureCall = 5 ' Invalid procedure call. 
Global Const mskInvalidPropertyValue = 380 ' Invalid property value. 
Global Const mskRecursiveOleDrag = 674 ' Illegal recursive invocation of OLE drag and drop. 
Global Const mskSetNotSupported = 383 ' Property is read-only. 
Global Const mskWrongClipboardFormat = 461 ' Specified format doesn't match format of data. 


' MousePointer Constants
Global Const mskDefault = 0 ' Default 
Global Const mskArrow = 1 ' Arrow 
Global Const mskCross = 2 ' Crosshair 
Global Const mskIbeam = 3 ' I beam 
Global Const mskIcon = 4 ' Icon 
Global Const mskSize = 5 ' Size 
Global Const mskSizeNESW = 6 ' Size NE, SW mouse pointer 
Global Const mskSizeNS = 7 ' Size N, S mouse pointer 
Global Const mskSizeNWSE = 8 ' Size NW, SE mouse pointer 
Global Const mskSizeEW = 9 ' Size W, E mouse pointer 
Global Const mskUpArrow = 10 ' Up arrow 
Global Const mskHourglass = 11 ' Hourglass 
Global Const mskNoDrop = 12 ' No drop 
Global Const mskArrowHourglass = 13 ' Arrow and hourglass 
Global Const mskArrowQuestion = 14 ' Arrow and question mark 
Global Const mskSizeAll = 15 ' Size all 
Global Const mskCustom = 99 ' Custom icon specified by the MouseIcon property 


' OLEDrag Constants
Global Const mskOLEDragManual = 0 ' OLE drag/drop is initialized only under programmatic control. 
Global Const mskOLEDragAutomatic = 1 ' OLE drag/drop is initialized when the user drags 'out' of the control, or under programmatic control. 


' OLEDrop Constants
Global Const mskOLEDropNone = 0 ' Accepts no OLE drag/drop operations. 
Global Const mskOLEDropManual = 1 ' Accepts an OLE drag/drop under programmatic control only. 
Global Const mskOLEDropAutomatic = 2 ' Accepts an OLE drag/drop without programmatic control. 


' OLEDropEffect Constants
Global Const mskOLEDropEffectNone = 0 ' No OLE drag/drop operation has taken place/would take place. 
Global Const mskOLEDropEffectCopy = 1 ' A mask to indicate that a copy has taken place/would take place. 
Global Const mskOLEDropEffectMove = 2 ' A mask to indicate that a move has take place/would take place. 
Global Const mskOLEDropEffectScroll = &H80000000 ' A mask to indicate that the drop target window has scrolled/would scroll. 


'1 Menu Control Constants


' PopupMenu Method Alignment
Global Const vbPopupMenuLeftAlign = 0 ' Pop-up menu left-aligned 
Global Const vbPopupMenuCenterAlign = 4 ' Pop-up menu centered 
Global Const vbPopupMenuRightAlign = 8 ' Pop-up menu right-aligned 


' PopupMenu Mouse Button Recognition
Global Const vbPopupMenuLeftButton = 0 ' Pop-up menu recognizes left mouse button only 
Global Const vbPopupMenuRightButton = 2 ' Pop-up menu recognizes right and left mouse buttons 


'1 MSHFlexGrid Control Constants


' AddModeSettings Property (MSHFlexGrid)
Global Const flexNoAddNew = 0 ' The current cell is not in the last row, and no AddNew operation is pending. 
Global Const flexAddNewCurrent = 1 ' The current cell is in the last row, but no AddNew operation is pending. 
Global Const flexAddNewPending = 2 ' The current cell is in the next to last row. This is a result of either a pending AddNew operation initiated by the user through the user interface of the MSHFlexGrid, or setting a column’s Value or Text property programmatically. 


' AllowUserResizing Property
Global Const flexResizeNone = 0 ' The user cannot resize with the mouse. This is the default. 
Global Const flexResizeColumns = 1 ' The user can resize columns using the mouse. 
Global Const flexResizeRows = 2 ' The user can resize rows using the mouse. 
Global Const flexResizeBoth = 3 ' The user can resize columns and rows using the mouse. 


' Appearance Property
Global Const flexFlat = 0 ' The overall look of MSHFlexGrid is flat, or normal. 
Global Const flex3D = 1 ' The overall look of MSHFlexGrid is three-dimensional. 


' BorderStyle Property
Global Const flexBorderNone = 0 ' There is no border. 
Global Const flexBorderSingle = 1 ' There is a single border. 


' CellAlignment Property
Global Const flexAlignLeftTop = 0 ' The cell content is aligned left, top. 
Global Const flexAlignLeftCenter = 1 ' The cell content is aligned left, center. This is the default for strings. 
Global Const flexAlignLeftBottom = 2 ' The cell content is aligned left, bottom. 
Global Const flexAlignCenterTop = 3 ' The cell content is aligned center, top. 
Global Const flexAlignCenterCenter = 4 ' The cell content is aligned center, center. 
Global Const flexAlignCenterBottom = 5 ' The cell content is aligned center, bottom. 
Global Const flexAlignRightTop = 6 ' The cell content is aligned right, top. 
Global Const flexAlignRightCenter = 7 ' The cell content is aligned right, center. This is the default for numbers. 
Global Const flexAlignRightBottom = 8 ' The cell content is aligned right, bottom. 
Global Const flexAlignGeneral = 9 ' The cell content is of general alignment. This is "left, center" for strings and "right, center" for numbers. 


' CellPictureAlignment Property
Global Const flexAlignLeftTop = 0 ' The picture is aligned left, top. 
Global Const flexAlignLeftCenter = 1 ' The picture is aligned left, center. 
Global Const flexAlignLeftBottom = 2 ' The picture is aligned left, bottom. 
Global Const flexAlignCenterTop = 3 ' The picture is aligned center, top. 
Global Const flexAlignCenterCenter = 4 ' The picture is aligned center, center. 
Global Const flexAlignCenterBottom = 5 ' The picture is aligned center, bottom. 
Global Const flexAlignRightTop = 6 ' The picture is aligned right, top. 
Global Const flexAlignRightCenter = 7 ' The picture is aligned right, center. 
Global Const flexAlignRightBottom = 8 ' The picture is aligned right, bottom. 


' CellTextStyle, TextStyle, TextStyleFixed Properties
Global Const flexTextFlat = 0 ' The text is normal, flat text. 
Global Const flexTextRaised = 1 ' The text appears raised. 
Global Const flexTextInset = 2 ' The text appears inset. 
Global Const flexTextRaisedLight = 3 ' The text appears slightly raised. 
Global Const flexTextInsetLight = 4 ' The text appears slightly inset. 


' CellType Properties (MSHFlexGrid)
Global Const flexCellTypeStandard = 0 ' The cell is a standard cell. 
Global Const flexCellTypeFixed = 1 ' The cell is contained in a fixed row or column. 
Global Const flexCellTypeHeader = 2 ' The cell is a header cell for a band of data. 
Global Const flexCellTypeIndent = 3 ' The cell is used in a column that indents a band of data. 
Global Const flexCellTypeUnpopulated = 4 ' The cell is an unpopulated cell. 


' ColAlignment Properties
Global Const flexAlignLeftTop = 0 ' The column content is aligned left, top. 
Global Const flexAlignLeftCenter = 1 ' The column content is aligned left, center. This is the default for strings. 
Global Const flexAlignLeftBottom = 2 ' The column content is aligned left, bottom. 
Global Const flexAlignCenterTop = 3 ' The column content is aligned center, top. 
Global Const flexAlignCenterCenter = 4 ' The column content is aligned center, center. 
Global Const flexAlignCenterBottom = 5 ' The column content is aligned center, bottom. 
Global Const flexAlignRightTop = 6 ' The column content is aligned right, top. 
Global Const flexAlignRightCenter = 7 ' The column content is aligned right, center. This is the default for numbers. 
Global Const flexAlignRightBottom = 8 ' The column content is aligned right, bottom. 
Global Const flexAlignGeneral = 9 ' The column content is of general alignment. This is left center for strings and right center for numbers. 


' ColHeader Property (MSHFlexGrid)
Global Const flexColHeaderOff = 0 ' No headers display for the band. 
Global Const flexColHeaderOn  = 1 ' The headers display for each band.  


' DisplayBandSettings Property (MSHFlexGrid)
Global Const flexBandDisplayHorizontal = 0 ' The bands within the MSHFlexGrid display horizontally (across). This is the default. 
Global Const flexBandDisplayVertical = 1 ' The bands within the MSHFlexGrid display vertically (up and down). 


' DisplayCellSettings Property (MSHFlexGrid)
Global Const FlexCellDisplayHorizontal = 0 ' The bands within the MSHFlexGrid display horizontally (across). 
Global Const flexCellDisplayVertical = 1 ' The bands within the MSHFlexGrid display vertically (up and down). 


' FillStyle Property
Global Const flexFillSingle = 0 ' Single. Changing Text or any of the cell properties only affects the active cell. This is the default. 
Global Const flexFillRepeat = 1 ' Repeat. Changing the Text or any of the cell properties affects all selected cells. 


' FocusRect Property
Global Const flexFocusNone = 0 ' There is no focus rectangle around the current cell. 
Global Const flexFocusLight = 1 ' There is a light focus rectangle around the current cell. This is the default. 
Global Const flexFocusHeavy = 2 ' There is a heavy focus rectangle around the current cell. 


' GridLines, GridLinesFixed Properties
Global Const flexGridNone = 0 ' No Lines. There are no lines between cells. In the MSFlexGrid, this is the default for GridLines. 
Global Const flexGridFlat = 1 ' Lines. The line style between cells is set to normal, flat lines. In the MSHFlexGrid, this is the default for GridLines. 
Global Const flexGridInset = 2 ' Inset Lines. The line style between cells is set to inset lines. In the MSFlexGrid, this is the default for GridLinesFixed. 
Global Const flexGridRaised = 3 ' Raised Lines. The line style between cells is set to raised lines. In the MSHFlexGrid, this is the default for GridLinesFixed. 


' HighLight Property
Global Const flexHighlightNever = 0 ' There is no highlight on the selected cells. 
Global Const flexHighlightAlways = 1 ' The selected cells are always highlighted. This is the default. 
Global Const flexHighlightWithFocus = 2 ' The highlight appears only when the control has focus. 


' MergeCells Property
Global Const flexMergeNever = 0 ' Never. The cells containing identical content are not grouped. This is the default. 
Global Const flexMergeFree = 1 ' Free. Cells with identical content always merge. 
Global Const flexMergeRestrictRows = 2 ' Restrict Rows. Only adjacent cells (to the left) within the row containing identical content merge. 
Global Const flexMergeRestrictColumns = 3 ' Restrict Columns. Only adjacent cells (to the top) within the column containing identical content merge. 
Global Const flexMergeRestrictBoth = 4 ' Restrict Both. Only adjacent cells within the row (to the left) or column (to the top) containing identical content merge. 


' MousePointer Property
Global Const flexDefault = 0 ' The outline of MSHFlexGrid. 
Global Const flexArrow = 1 ' An arrow pointer. 
Global Const flexCross = 2 ' A set of crosshairs. 
Global Const flexIBeam = 3 ' An "I"-shaped beam to allow for text entry. 
Global Const flexIcon = 4 ' A square within a square. 
Global Const flexSize = 5 ' A resizing pointer with arrows facing up, down, left, and right. 
Global Const flexSizeNESW = 6 ' A resizing pointer with arrows pointing to the upper right and lower left. 
Global Const flexSizeNS = 7 ' A resizing pointer with arrows pointing up and down. 
Global Const flexSizeNWSE = 8 ' A resizing pointer with arrows pointing to the upper left and lower right. 
Global Const flexSizeEW = 9 ' A resizing pointer with arrows pointing left and right. 
Global Const flexUpArrow = 10 ' An arrow pointing up. 
Global Const flexHourGlass = 11 ' An hourglass symbol. 
Global Const flexNoDrop = 12 ' A no drop pointer. 
Global Const flexCustom = 13 ' A custom style pointer. 


' PictureType Property
Global Const flexPictureColor = 0 ' This produces a high-quality full-color image.  
Global Const flexPictureMonochrome = 1 ' This produces a lower-quality, monochrome, image that consumes less memory. 


' RowSizingSettings Property (MSHFlexGrid)
Global Const flexRowSizeIndividual = 0 ' Resizing a row changes only the height of the row sized. This is the default. 
Global Const flexRowSizeAll = 1 ' Resizing a row changes the height of all rows in the MSHFlexGrid. 


' SelectionMode Property
Global Const flexSelectionFree = 0 ' Free. This allows individual cells in the MSHFlexGrid to be selected, spreadsheet-style. (Default) 
Global Const flexSelectionByRow = 1 ' By Row. This forces selections to span entire rows, as in a multi-column list box or record-based display. 
Global Const flexSelectionByColumn = 2 ' By Column. This forces selections to span entire columns, as if selecting ranges for a chart or fields for sorting. 


' ScrollBars Property
Global Const flexScrollNone = 0 ' The MSHFlexGrid has no scroll bars. 
Global Const flexScrollHorizontal = 1 ' The MSHFlexGrid has a horizontal scroll bar. 
Global Const flexScrollVertical = 2 ' The MSHFlexGrid has a vertical scroll bar. 
Global Const flexScrollBoth = 3 ' The MSHFlexGrid has horizontal and vertical scroll bars. This is the default. 


' Sort Property
Global Const flexSortNone = 0 ' None. No sorting is performed. 
Global Const flexSortGenericAscending = 1 ' Generic Ascending. An ascending sort, which estimates whether text is string or number, is performed. 
Global Const flexSortGenericDescending = 2 ' Generic Descending. A descending sort, which estimates whether text is string or number, is performed. 
Global Const flexSortNumericAscending = 3 ' Numeric Ascending. An ascending sort, which converts strings to numbers, is performed. 
Global Const flexSortNumericDescending = 4 ' Numeric Descending. A descending sort, which converts strings to numbers, is performed. 
Global Const flexSortStringNoCaseAsending = 5 ' String Ascending. An ascending sort using case-insensitive string comparison is performed. 
Global Const flexSortNoCaseDescending = 6 ' String Descending. A descending sort using case-insensitive string comparison is performed. 
Global Const flexSortStringAscending = 7 ' String Ascending. An ascending sort using case-sensitive string comparison is performed. 
Global Const flexSortStringDescending = 8 ' String Descending. A descending sort using case-sensitive string comparison is performed. 
Global Const flexSortCustom = 9 ' Custom. This uses the Compare event to compare rows. 


'1 OLE Container Control Constants


' OLEType Property
Global Const vbOLELinked = 0 ' OLE container control contains a linked object 
Global Const vbOLEEmbedded = 1 ' OLE container control contains an embedded object 
Global Const vbOLENone = 3 ' OLE container control doesn't contain an object 


' OLETypeAllowed Property
Global Const vbOLEEither = 2 ' OLE container control can contain either a linked or an embedded object 


' UpdateOptions Property
Global Const vbOLEAutomatic = 0 ' Object is updated each time the linked data changes 
Global Const vbOLEFrozen = 1 ' Object is updated whenever the user saves the linked document from within the application in which it was created 
Global Const vbOLEManual = 2 ' Object is updated only when the Action property is set to 6 (Update) 


' AutoActivate Property
Global Const vbOLEActivateManual = 0 ' OLE object isn't automatically activated 
Global Const vbOLEActivateGetFocus = 1 ' Object is activated when the OLE container control gets the focus 
Global Const vbOLEActivateDoubleclick = 2 ' Object is activated when the OLE container control is double-clicked 
Global Const vbOLEActivateAuto = 3 ' Object is activated based on the object's default method of activation 


' SizeMode Property
Global Const vbOLESizeClip = 0 ' Object's image is clipped by the OLE container control's borders 
Global Const vbOLESizeStretch = 1 ' Object's image is sized to fill the OLE container control 
Global Const vbOLESizeAutoSize = 2 ' OLE container control is automatically resized to display the entire object 
Global Const vbOLESizeZoom = 3 ' Object's image is stretched but in proportion 


' DisplayType Property
Global Const vbOLEDisplayContent = 0 ' Object's data is displayed in the OLE container control 
Global Const vbOLEDisplayIcon = 1 ' Object's icon is displayed in the OLE container control 


' Updated Event Constants
Global Const vbOLEChanged = 0 ' Object's data has changed 
Global Const vbOLESaved = 1 ' Object's data has been saved by the application that created the object 
Global Const vbOLEClosed = 2 ' Application file containing the linked object's data has been closed 
Global Const vbOLERenamed = 3 ' Application file containing the linked object's data has been renamed 


' Special Verb Values
Global Const vbOLEPrimary = 0 ' Default action for the object 
Global Const vbOLEShow = -1 ' Activates the object for editing 
Global Const vbOLEOpen = -2 ' Opens the object in a separate application window 
Global Const vbOLEHide = -3 ' For embedded objects, hides the application that created the object 
Global Const vbOLEUIActivate = -4 ' All UI's associated with the object are visible and ready for use 
Global Const vbOLEInPlaceActivate = -5 ' Object is ready for the user to click inside it and start working with it 
Global Const vbOLEDiscardUndoState = -6 ' For discarding all record of changes that the object's application can undo 


' Verb Flag Bit Masks
Global Const vbOLEFlagGrayed = &H1 ' Grayed menu item 
Global Const vbOLEFlagDisabled = &H2 ' Disabled menu item 
Global Const vbOLEFlagChecked = &H8 ' Checked menu item 
Global Const vbOLEFlagSeparator = &H800 ' Separator bar in menu item list 
Global Const vbOLEMiscFlagMemStorage = &H1 ' Causes control to use memory to store the object while it's loaded 
Global Const vbOLEMiscFlagDisableInPlace = &H2 ' Forces OLE container control to activate objects in a separate window 


'1 UpdateFlags Constants

' Constant Value Description 
Global Const VtChNoDisplay = 0 ' Absence of update flags; the chart display is not affected. 
Global Const VtChDisplayPlot = 1 ' Update will cause the plot to repaint.  
Global Const VtChLayoutPlot = 2 ' Update will cause the plot to layout. 
Global Const VtChDisplayLegend = 4 ' Update will cause the legend to repaint. 
Global Const VtChLayoutLegend = 8 ' Update will cause the legend to layout. 
Global Const VtChLayoutSeries = 16 ' Update will cause the series to lay out. 
Global Const VtChPositionSection = 32 ' A chart section has been moved or resized. 


' Clipboard Object Constants
Global Const vbCFRTF = -16639 ' Rich Text Format (.rtf file) 
Global Const vbCFLink = -16640 ' DDE conversation information 
Global Const vbCFText = 1 ' Text (.txt file) 
Global Const vbCFBitmap = 2 ' Bitmap (.bmp file) 
Global Const vbCFMetafile = 3 ' Metafile (.wmf file) 
Global Const vbCFDIB = 8 ' Device-independent bitmap 
Global Const vbCFPalette = 9 ' Color palette 
Global Const vbCFEMetaFile = 14 ' Enhanced metafile (.emf file) 
Global Const vbCFFiles = 15 ' File list from Windows Explorer 


'1 Form Constants


' Show Parameters
Global Const vbModal = 1 ' Modal form 
Global Const vbModeless = 0 ' Modeless form 


' Arrange Method for MDI Forms
Global Const vbCascade = 0 ' Cascade all nonminimized MDI child forms 
Global Const vbTileHorizontal = 1 ' Horizontally tile all nonminimized MDI child forms 
Global Const vbTileVertical = 2 ' Vertically tile all nonminimized MDI child forms 
Global Const vbArrangeIcons = 3 ' Arrange icons for minimized MDI child forms 


' WindowState Property
Global Const vbNormal = 0 ' Normal 
Global Const vbMinimized = 1 ' Minimized 
Global Const vbMaximized = 2 ' Maximized 


'1 Printer Object Constants


' Printer Color Mode
Global Const vbPRCMMonochrome = 1 ' Monochrome output 
Global Const vbPRCMColor = 2 ' Color output 


' Duplex Printing
Global Const vbPRDPSimplex = 1 ' Single-sided printing 
Global Const vbPRDPHorizontal = 2 ' Double-sided horizontal printing 
Global Const vbPRDPVertical = 3 ' Double-sided vertical printing 


' Printer Orientation
Global Const vbPRORPortrait = 1 ' Documents print with the top at the narrow side of the paper 
Global Const vbPRORLandscape = 2 ' Documents print with the top at the wide side of the paper 


' Print Quality
Global Const vbPRPQDraft = -1 ' Draft print quality 
Global Const vbPRPQLow = -2 ' Low print quality 
Global Const vbPRPQMedium = -3 ' Medium print quality 
Global Const vbPRPQHigh = -4 ' High print quality 


' PaperBin Property
Global Const vbPRBNUpper = 1 ' Use paper from the upper bin 
Global Const vbPRBNLower = 2 ' Use paper from the lower bin 
Global Const vbPRBNMiddle = 3 ' Use paper from the middle bin 
Global Const vbPRBNManual = 4 ' Wait for manual insertion of each sheet of paper 
Global Const vbPRBNEnvelope = 5 ' Use envelopes from the envelope feeder 
Global Const vbPRBNEnvManual = 6 ' Use envelopes from the envelope feeder, but wait for manual insertion 
Global Const vbPRBNAuto = 7 ' (Default) Use paper from the current default bin 
Global Const vbPRBNTractor = 8 ' Use paper fed from the tractor feeder 
Global Const vbPRBNSmallFmt = 9 ' Use paper from the small paper feeder 
Global Const vbPRBNLargeFmt = 10 ' Use paper from the large paper bin 
Global Const vbPRBNLargeCapacity = 11 ' Use paper from the large capacity feeder 
Global Const vbPRBNCassette = 14 ' Use paper from the attached cassette cartridge 


' PaperSize Property
Global Const vbPRPSLetter = 1 ' Letter, 8 1/2 x 11 in 
Global Const vbPRPSLetterSmall = 2 ' +A611Letter Small, 8 1/2 x 11 in 
Global Const vbPRPSTabloid = 3 ' Tabloid, 11 x 17 in 
Global Const vbPRPSLedger = 4 ' Ledger, 17 x 11 in 
Global Const vbPRPSLegal = 5 ' Legal, 8 1/2 x 14 in 
Global Const vbPRPSStatement = 6 ' Statement, 5 1/2 x 8 1/2 in 
Global Const vbPRPSExecutive = 7 ' Executive, 7 1/2 x 10 1/2 in 
Global Const vbPRPSA3 = 8 ' A3, 297 x 420 mm 
Global Const vbPRPSA4 = 9 ' A4, 210 x 297 mm 
Global Const vbPRPSA4Small = 10 ' A4 Small, 210 x 297 mm 
Global Const vbPRPSA5 = 11 ' A5, 148 x 210 mm 
Global Const vbPRPSB4 = 12 ' B4, 250 x 354 mm 
Global Const vbPRPSB5 = 13 ' B5, 182 x 257 mm 
Global Const vbPRPSFolio = 14 ' Folio, 8 1/2 x 13 in 
Global Const vbPRPSQuarto = 15 ' Quarto, 215 x 275 mm 
Global Const vbPRPS10x14 = 16 ' 10 x 14 in 
Global Const vbPRPS11x17 = 17 ' 11 x 17 in 
Global Const vbPRPSNote = 18 ' Note, 8 1/2 x 11 in 
Global Const vbPRPSEnv9 = 19 ' Envelope #9, 3 7/8 x 8 7/8 in 
Global Const vbPRPSEnv10 = 20 ' Envelope #10, 4 1/8 x 9 1/2 in 
Global Const vbPRPSEnv11 = 21 ' Envelope #11, 4 1/2 x 10 3/8 in 
Global Const vbPRPSEnv12 = 22 ' Envelope #12, 4 1/2 x 11 in 
Global Const vbPRPSEnv14 = 23 ' Envelope #14, 5 x 11 1/2 in 
Global Const vbPRPSCSheet = 24 ' C size sheet 
Global Const vbPRPSDSheet = 25 ' D size sheet 
Global Const vbPRPSESheet = 26 ' E size sheet 
Global Const vbPRPSEnvDL = 27 ' Envelope DL, 110 x 220 mm 
Global Const vbPRPSEnvC3 = 29 ' Envelope C3, 324 x 458 mm 
Global Const vbPRPSEnvC4 = 30 ' Envelope C4, 229 x 324 mm 
Global Const vbPRPSEnvC5 = 28 ' Envelope C5, 162 x 229 mm 
Global Const vbPRPSEnvC6 = 31 ' Envelope C6, 114 x 162 mm 
Global Const vbPRPSEnvC65 = 32 ' Envelope C65, 114 x 229 mm 
Global Const vbPRPSEnvB4 = 33 ' Envelope B4, 250 x 353 mm 
Global Const vbPRPSEnvB5 = 34 ' Envelope B5, 176 x 250 mm 
Global Const vbPRPSEnvB6 = 35 ' Envelope B6, 176 x 125 mm 
Global Const vbPRPSEnvItaly = 36 ' Envelope, 110 x 230 mm 
Global Const vbPRPSEnvMonarch = 37 ' Envelope Monarch, 3 7/8 x 7 1/2 in 
Global Const vbPRPSEnvPersonal = 38 ' Envelope, 3 5/8 x 6 1/2 in 
Global Const vbPRPSFanfoldUS = 39 ' U.S. Standard Fanfold, 14 7/8 x 11 in 
Global Const vbPRPSFanfoldStdGerman = 40 ' German Standard Fanfold, 8 1/2 x 12 in 
Global Const vbPRPSFanfoldLglGerman = 41 ' German Legal Fanfold, 8 1/2 x 13 in 
Global Const vbPRPSUser = 256 ' User-defined 


' StdPicture Object Constants
Global Const vbPicTypeNone = 0 ' None (empty) 
Global Const vbPicTypeBitmap = 1 ' Bitmap type of StdPicture object 
Global Const vbPicTypeMetafile = 2 ' Metafile type of StdPicture object 
Global Const vbPicTypeIcon = 3 ' Icon type of StdPicture object 
Global Const vbPicTypeEMetaFile = 4 ' Enhanced metafile type of StdPicture object 

