public class DataGridView : Control, System.ComponentModel.IComponent, System.IDisposable, IOleControl, IOleObject, IOleInPlaceObject, IOleInPlaceActiveObject, IOleWindow, IViewObject, IViewObject2, IPersist, IPersistStreamInit, IPersistPropertyBag, IPersistStorage, IQuickActivate, ISupportOleDropSource, IDropTarget, System.ComponentModel.ISynchronizeInvoke, IWin32Window, System.Windows.Forms.Layout.IArrangedElement, IBindableComponent, System.ComponentModel.ISupportInitialize
{

	// Constructors
	public DataGridView() {}

	// Methods
	public virtual void Sort(DataGridViewColumn dataGridViewColumn, System.ComponentModel.ListSortDirection direction) {}
	public virtual void Sort(System.Collections.IComparer comparer) {}
	public void UpdateCellErrorText(int columnIndex, int rowIndex) {}
	public void UpdateCellValue(int columnIndex, int rowIndex) {}
	public void UpdateRowErrorText(int rowIndex) {}
	public void UpdateRowErrorText(int rowIndexStart, int rowIndexEnd) {}
	public void UpdateRowHeightInfo(int rowIndex, bool updateToEnd) {}
	public bool RefreshEdit() {}
	public virtual void ResetText() {}
	public void SelectAll() {}
	public void AutoResizeRowHeadersWidth(int rowIndex, DataGridViewRowHeadersWidthSizeMode rowHeadersWidthSizeMode) {}
	public void AutoResizeRows() {}
	public void AutoResizeRows(DataGridViewAutoSizeRowsMode autoSizeRowsMode) {}
	public virtual bool BeginEdit(bool selectAll) {}
	public bool CancelEdit() {}
	public void ClearSelection() {}
	public bool CommitEdit(DataGridViewDataErrorContexts context) {}
	public int DisplayedColumnCount(bool includePartialColumns) {}
	public int DisplayedRowCount(bool includePartialRow) {}
	public bool EndEdit() {}
	public bool EndEdit(DataGridViewDataErrorContexts context) {}
	public int GetCellCount(DataGridViewElementStates includeFilter) {}
	public System.Drawing.Rectangle GetCellDisplayRectangle(int columnIndex, int rowIndex, bool cutOverflow) {}
	public virtual DataObject GetClipboardContent() {}
	public System.Drawing.Rectangle GetColumnDisplayRectangle(int columnIndex, bool cutOverflow) {}
	public System.Drawing.Rectangle GetRowDisplayRectangle(int rowIndex, bool cutOverflow) {}
	public HitTestInfo HitTest(int x, int y) {}
	public void InvalidateCell(DataGridViewCell dataGridViewCell) {}
	public void InvalidateCell(int columnIndex, int rowIndex) {}
	public void InvalidateColumn(int columnIndex) {}
	public void InvalidateRow(int rowIndex) {}
	public virtual void NotifyCurrentCellDirty(bool dirty) {}
	public virtual DataGridViewAdvancedBorderStyle AdjustColumnHeaderBorderStyle(DataGridViewAdvancedBorderStyle dataGridViewAdvancedBorderStyleInput, DataGridViewAdvancedBorderStyle dataGridViewAdvancedBorderStylePlaceholder, bool isFirstDisplayedColumn, bool isLastVisibleColumn) {}
	public bool AreAllCellsSelected(bool includeInvisibleCells) {}
	public void AutoResizeColumn(int columnIndex) {}
	public void AutoResizeColumn(int columnIndex, DataGridViewAutoSizeColumnMode autoSizeColumnMode) {}
	public void AutoResizeColumnHeadersHeight() {}
	public void AutoResizeColumnHeadersHeight(int columnIndex) {}
	public void AutoResizeColumns() {}
	public void AutoResizeColumns(DataGridViewAutoSizeColumnsMode autoSizeColumnsMode) {}
	public void AutoResizeRow(int rowIndex) {}
	public void AutoResizeRow(int rowIndex, DataGridViewAutoSizeRowMode autoSizeRowMode) {}
	public void AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode rowHeadersWidthSizeMode) {}
	public void ResetImeMode() {}
	public void PerformLayout() {}
	public virtual bool PreProcessMessage(Message& msg) {}
	public virtual void ResetBackColor() {}
	public virtual void ResetCursor() {}
	public virtual void ResetFont() {}
	public virtual void ResetForeColor() {}
	public virtual void ResetRightToLeft() {}
	public virtual void Refresh() {}
	public void ResumeLayout() {}
	public void ResumeLayout(bool performLayout) {}
	public void SetBounds(int x, int y, int width, int height, BoundsSpecified specified) {}
	public void SuspendLayout() {}
	public void PerformLayout(Control affectedControl, string affectedProperty) {}
	public System.Drawing.Point PointToClient(System.Drawing.Point p) {}
	public System.Drawing.Point PointToScreen(System.Drawing.Point p) {}
	public PreProcessControlState PreProcessControlMessage(Message& msg) {}
	public System.Drawing.Rectangle RectangleToClient(System.Drawing.Rectangle r) {}
	public System.Drawing.Rectangle RectangleToScreen(System.Drawing.Rectangle r) {}
	public void Scale(float ratio) {}
	public void Scale(float dx, float dy) {}
	public void Scale(System.Drawing.SizeF factor) {}
	public void Select() {}
	public bool SelectNextControl(Control ctl, bool forward, bool tabStopOnly, bool nested, bool wrap) {}
	public void SendToBack() {}
	public void SetBounds(int x, int y, int width, int height) {}
	public void Show() {}
	public void Update() {}
	public virtual System.IAsyncResult BeginInvoke(System.Delegate method, object[] args) {}
	public void CreateControl() {}
	public virtual object EndInvoke(System.IAsyncResult asyncResult) {}
	public void Invalidate() {}
	public virtual object Invoke(System.Delegate method, object[] args) {}
	public System.IAsyncResult BeginInvoke(System.Delegate method) {}
	public void BringToFront() {}
	public bool Contains(Control ctl) {}
	public System.Drawing.Graphics CreateGraphics() {}
	public DragDropEffects DoDragDrop(object data, DragDropEffects allowedEffects) {}
	public void DrawToBitmap(System.Drawing.Bitmap bitmap, System.Drawing.Rectangle targetBounds) {}
	public Form FindForm() {}
	public bool Focus() {}
	public Control GetChildAtPoint(System.Drawing.Point pt, GetChildAtPointSkip skipValue) {}
	public Control GetChildAtPoint(System.Drawing.Point pt) {}
	public IContainerControl GetContainerControl() {}
	public Control GetNextControl(Control ctl, bool forward) {}
	public void Hide() {}
	public void Invalidate(System.Drawing.Region region) {}
	public void Invalidate(System.Drawing.Region region, bool invalidateChildren) {}
	public void Invalidate(bool invalidateChildren) {}
	public void Invalidate(System.Drawing.Rectangle rc) {}
	public void Invalidate(System.Drawing.Rectangle rc, bool invalidateChildren) {}
	public object Invoke(System.Delegate method) {}
	public virtual System.Drawing.Size GetPreferredSize(System.Drawing.Size proposedSize) {}
	public void ResetBindings() {}
	public virtual void Dispose() {}
	public virtual string ToString() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public DataGridViewAdvancedBorderStyle AdjustedTopLeftHeaderBorderStyle { get{} }
	public DataGridViewAdvancedBorderStyle AdvancedCellBorderStyle { get{} }
	public DataGridViewAdvancedBorderStyle AdvancedColumnHeadersBorderStyle { get{} }
	public DataGridViewAdvancedBorderStyle AdvancedRowHeadersBorderStyle { get{} }
	public bool AllowUserToAddRows { get{} set{} }
	public bool AllowUserToDeleteRows { get{} set{} }
	public bool AllowUserToOrderColumns { get{} set{} }
	public bool AllowUserToResizeColumns { get{} set{} }
	public bool AllowUserToResizeRows { get{} set{} }
	public DataGridViewCellStyle AlternatingRowsDefaultCellStyle { get{} set{} }
	public bool AutoGenerateColumns { get{} set{} }
	public bool AutoSize { get{} set{} }
	public DataGridViewAutoSizeColumnsMode AutoSizeColumnsMode { get{} set{} }
	public DataGridViewAutoSizeRowsMode AutoSizeRowsMode { get{} set{} }
	public System.Drawing.Color BackColor { get{} set{} }
	public System.Drawing.Color BackgroundColor { get{} set{} }
	public System.Drawing.Image BackgroundImage { get{} set{} }
	public ImageLayout BackgroundImageLayout { get{} set{} }
	public BorderStyle BorderStyle { get{} set{} }
	public DataGridViewCellBorderStyle CellBorderStyle { get{} set{} }
	public DataGridViewClipboardCopyMode ClipboardCopyMode { get{} set{} }
	public int ColumnCount { get{} set{} }
	public DataGridViewHeaderBorderStyle ColumnHeadersBorderStyle { get{} set{} }
	public DataGridViewCellStyle ColumnHeadersDefaultCellStyle { get{} set{} }
	public int ColumnHeadersHeight { get{} set{} }
	public DataGridViewColumnHeadersHeightSizeMode ColumnHeadersHeightSizeMode { get{} set{} }
	public bool ColumnHeadersVisible { get{} set{} }
	public DataGridViewColumnCollection Columns { get{} }
	public DataGridViewCell CurrentCell { get{} set{} }
	public System.Drawing.Point CurrentCellAddress { get{} }
	public DataGridViewRow CurrentRow { get{} }
	public string DataMember { get{} set{} }
	public object DataSource { get{} set{} }
	public DataGridViewCellStyle DefaultCellStyle { get{} set{} }
	public System.Drawing.Rectangle DisplayRectangle { get{} }
	public DataGridViewEditMode EditMode { get{} set{} }
	public Control EditingControl { get{} }
	public Panel EditingPanel { get{} }
	public bool EnableHeadersVisualStyles { get{} set{} }
	public DataGridViewCell FirstDisplayedCell { get{} set{} }
	public int FirstDisplayedScrollingColumnHiddenWidth { get{} }
	public int FirstDisplayedScrollingColumnIndex { get{} set{} }
	public int FirstDisplayedScrollingRowIndex { get{} set{} }
	public System.Drawing.Color ForeColor { get{} set{} }
	public System.Drawing.Font Font { get{} set{} }
	public System.Drawing.Color GridColor { get{} set{} }
	public int HorizontalScrollingOffset { get{} set{} }
	public bool IsCurrentCellDirty { get{} }
	public bool IsCurrentCellInEditMode { get{} }
	public bool IsCurrentRowDirty { get{} }
	public bool MultiSelect { get{} set{} }
	public int NewRowIndex { get{} }
	public Padding Padding { get{} set{} }
	public bool ReadOnly { get{} set{} }
	public int RowCount { get{} set{} }
	public DataGridViewHeaderBorderStyle RowHeadersBorderStyle { get{} set{} }
	public DataGridViewCellStyle RowHeadersDefaultCellStyle { get{} set{} }
	public bool RowHeadersVisible { get{} set{} }
	public int RowHeadersWidth { get{} set{} }
	public DataGridViewRowHeadersWidthSizeMode RowHeadersWidthSizeMode { get{} set{} }
	public DataGridViewRowCollection Rows { get{} }
	public DataGridViewCellStyle RowsDefaultCellStyle { get{} set{} }
	public DataGridViewRow RowTemplate { get{} set{} }
	public ScrollBars ScrollBars { get{} set{} }
	public DataGridViewSelectedCellCollection SelectedCells { get{} }
	public DataGridViewSelectedColumnCollection SelectedColumns { get{} }
	public DataGridViewSelectedRowCollection SelectedRows { get{} }
	public DataGridViewSelectionMode SelectionMode { get{} set{} }
	public bool ShowCellErrors { get{} set{} }
	public bool ShowCellToolTips { get{} set{} }
	public bool ShowEditingIcon { get{} set{} }
	public bool ShowRowErrors { get{} set{} }
	public DataGridViewColumn SortedColumn { get{} }
	public SortOrder SortOrder { get{} }
	public bool StandardTab { get{} set{} }
	public string Text { get{} set{} }
	public DataGridViewCell Item { get{} set{} }
	public DataGridViewCell Item { get{} set{} }
	public DataGridViewHeaderCell TopLeftHeaderCell { get{} set{} }
	public Cursor UserSetCursor { get{} }
	public int VerticalScrollingOffset { get{} }
	public bool VirtualMode { get{} set{} }
	public AccessibleObject AccessibilityObject { get{} }
	public string AccessibleDefaultActionDescription { get{} set{} }
	public string AccessibleDescription { get{} set{} }
	public string AccessibleName { get{} set{} }
	public AccessibleRole AccessibleRole { get{} set{} }
	public bool AllowDrop { get{} set{} }
	public AnchorStyles Anchor { get{} set{} }
	public System.Drawing.Point AutoScrollOffset { get{} set{} }
	public System.Windows.Forms.Layout.LayoutEngine LayoutEngine { get{} }
	public BindingContext BindingContext { get{} set{} }
	public int Bottom { get{} }
	public System.Drawing.Rectangle Bounds { get{} set{} }
	public bool CanFocus { get{} }
	public bool CanSelect { get{} }
	public bool Capture { get{} set{} }
	public bool CausesValidation { get{} set{} }
	public System.Drawing.Rectangle ClientRectangle { get{} }
	public System.Drawing.Size ClientSize { get{} set{} }
	public string CompanyName { get{} }
	public bool ContainsFocus { get{} }
	public ContextMenu ContextMenu { get{} set{} }
	public ContextMenuStrip ContextMenuStrip { get{} set{} }
	public ControlCollection Controls { get{} }
	public bool Created { get{} }
	public Cursor Cursor { get{} set{} }
	public ControlBindingsCollection DataBindings { get{} }
	public bool IsDisposed { get{} }
	public bool Disposing { get{} }
	public DockStyle Dock { get{} set{} }
	public bool Enabled { get{} set{} }
	public bool Focused { get{} }
	public System.IntPtr Handle { get{} }
	public bool HasChildren { get{} }
	public int Height { get{} set{} }
	public bool IsHandleCreated { get{} }
	public bool InvokeRequired { get{} }
	public bool IsAccessible { get{} set{} }
	public bool IsMirrored { get{} }
	public int Left { get{} set{} }
	public System.Drawing.Point Location { get{} set{} }
	public Padding Margin { get{} set{} }
	public System.Drawing.Size MaximumSize { get{} set{} }
	public System.Drawing.Size MinimumSize { get{} set{} }
	public string Name { get{} set{} }
	public Control Parent { get{} set{} }
	public string ProductName { get{} }
	public string ProductVersion { get{} }
	public bool RecreatingHandle { get{} }
	public System.Drawing.Region Region { get{} set{} }
	public int Right { get{} }
	public RightToLeft RightToLeft { get{} set{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.Drawing.Size Size { get{} set{} }
	public int TabIndex { get{} set{} }
	public bool TabStop { get{} set{} }
	public object Tag { get{} set{} }
	public int Top { get{} set{} }
	public Control TopLevelControl { get{} }
	public bool UseWaitCursor { get{} set{} }
	public bool Visible { get{} set{} }
	public int Width { get{} set{} }
	public IWindowTarget WindowTarget { get{} set{} }
	public System.Drawing.Size PreferredSize { get{} }
	public ImeMode ImeMode { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.EventHandler AllowUserToAddRowsChanged;
	public event System.EventHandler AllowUserToDeleteRowsChanged;
	public event System.EventHandler AllowUserToOrderColumnsChanged;
	public event System.EventHandler AllowUserToResizeColumnsChanged;
	public event System.EventHandler AllowUserToResizeRowsChanged;
	public event System.EventHandler AlternatingRowsDefaultCellStyleChanged;
	public event System.EventHandler AutoGenerateColumnsChanged;
	public event System.Windows.Forms.DataGridViewAutoSizeColumnsModeEventHandler AutoSizeColumnsModeChanged;
	public event System.Windows.Forms.DataGridViewAutoSizeModeEventHandler AutoSizeRowsModeChanged;
	public event System.EventHandler BackColorChanged;
	public event System.EventHandler BackgroundColorChanged;
	public event System.EventHandler BackgroundImageChanged;
	public event System.EventHandler BackgroundImageLayoutChanged;
	public event System.EventHandler BorderStyleChanged;
	public event System.EventHandler CellBorderStyleChanged;
	public event System.EventHandler ColumnHeadersBorderStyleChanged;
	public event System.EventHandler ColumnHeadersDefaultCellStyleChanged;
	public event System.EventHandler ColumnHeadersHeightChanged;
	public event System.Windows.Forms.DataGridViewAutoSizeModeEventHandler ColumnHeadersHeightSizeModeChanged;
	public event System.EventHandler DataMemberChanged;
	public event System.EventHandler DataSourceChanged;
	public event System.EventHandler DefaultCellStyleChanged;
	public event System.EventHandler EditModeChanged;
	public event System.EventHandler ForeColorChanged;
	public event System.EventHandler FontChanged;
	public event System.EventHandler GridColorChanged;
	public event System.EventHandler MultiSelectChanged;
	public event System.EventHandler PaddingChanged;
	public event System.EventHandler ReadOnlyChanged;
	public event System.EventHandler RowHeadersBorderStyleChanged;
	public event System.EventHandler RowHeadersDefaultCellStyleChanged;
	public event System.EventHandler RowHeadersWidthChanged;
	public event System.Windows.Forms.DataGridViewAutoSizeModeEventHandler RowHeadersWidthSizeModeChanged;
	public event System.EventHandler RowsDefaultCellStyleChanged;
	public event System.EventHandler TextChanged;
	public event System.Windows.Forms.DataGridViewAutoSizeColumnModeEventHandler AutoSizeColumnModeChanged;
	public event System.Windows.Forms.QuestionEventHandler CancelRowEdit;
	public event System.Windows.Forms.DataGridViewCellCancelEventHandler CellBeginEdit;
	public event System.Windows.Forms.DataGridViewCellEventHandler CellClick;
	public event System.Windows.Forms.DataGridViewCellEventHandler CellContentClick;
	public event System.Windows.Forms.DataGridViewCellEventHandler CellContentDoubleClick;
	public event System.Windows.Forms.DataGridViewCellEventHandler CellContextMenuStripChanged;
	public event System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler CellContextMenuStripNeeded;
	public event System.Windows.Forms.DataGridViewCellEventHandler CellDoubleClick;
	public event System.Windows.Forms.DataGridViewCellEventHandler CellEndEdit;
	public event System.Windows.Forms.DataGridViewCellEventHandler CellEnter;
	public event System.Windows.Forms.DataGridViewCellEventHandler CellErrorTextChanged;
	public event System.Windows.Forms.DataGridViewCellErrorTextNeededEventHandler CellErrorTextNeeded;
	public event System.Windows.Forms.DataGridViewCellFormattingEventHandler CellFormatting;
	public event System.Windows.Forms.DataGridViewCellEventHandler CellLeave;
	public event System.Windows.Forms.DataGridViewCellMouseEventHandler CellMouseClick;
	public event System.Windows.Forms.DataGridViewCellMouseEventHandler CellMouseDoubleClick;
	public event System.Windows.Forms.DataGridViewCellMouseEventHandler CellMouseDown;
	public event System.Windows.Forms.DataGridViewCellEventHandler CellMouseEnter;
	public event System.Windows.Forms.DataGridViewCellEventHandler CellMouseLeave;
	public event System.Windows.Forms.DataGridViewCellMouseEventHandler CellMouseMove;
	public event System.Windows.Forms.DataGridViewCellMouseEventHandler CellMouseUp;
	public event System.Windows.Forms.DataGridViewCellPaintingEventHandler CellPainting;
	public event System.Windows.Forms.DataGridViewCellParsingEventHandler CellParsing;
	public event System.Windows.Forms.DataGridViewCellStateChangedEventHandler CellStateChanged;
	public event System.Windows.Forms.DataGridViewCellEventHandler CellStyleChanged;
	public event System.Windows.Forms.DataGridViewCellStyleContentChangedEventHandler CellStyleContentChanged;
	public event System.Windows.Forms.DataGridViewCellEventHandler CellToolTipTextChanged;
	public event System.Windows.Forms.DataGridViewCellToolTipTextNeededEventHandler CellToolTipTextNeeded;
	public event System.Windows.Forms.DataGridViewCellEventHandler CellValidated;
	public event System.Windows.Forms.DataGridViewCellValidatingEventHandler CellValidating;
	public event System.Windows.Forms.DataGridViewCellEventHandler CellValueChanged;
	public event System.Windows.Forms.DataGridViewCellValueEventHandler CellValueNeeded;
	public event System.Windows.Forms.DataGridViewCellValueEventHandler CellValuePushed;
	public event System.Windows.Forms.DataGridViewColumnEventHandler ColumnAdded;
	public event System.Windows.Forms.DataGridViewColumnEventHandler ColumnContextMenuStripChanged;
	public event System.Windows.Forms.DataGridViewColumnEventHandler ColumnDataPropertyNameChanged;
	public event System.Windows.Forms.DataGridViewColumnEventHandler ColumnDefaultCellStyleChanged;
	public event System.Windows.Forms.DataGridViewColumnEventHandler ColumnDisplayIndexChanged;
	public event System.Windows.Forms.DataGridViewColumnDividerDoubleClickEventHandler ColumnDividerDoubleClick;
	public event System.Windows.Forms.DataGridViewColumnEventHandler ColumnDividerWidthChanged;
	public event System.Windows.Forms.DataGridViewCellMouseEventHandler ColumnHeaderMouseClick;
	public event System.Windows.Forms.DataGridViewCellMouseEventHandler ColumnHeaderMouseDoubleClick;
	public event System.Windows.Forms.DataGridViewColumnEventHandler ColumnHeaderCellChanged;
	public event System.Windows.Forms.DataGridViewColumnEventHandler ColumnMinimumWidthChanged;
	public event System.Windows.Forms.DataGridViewColumnEventHandler ColumnNameChanged;
	public event System.Windows.Forms.DataGridViewColumnEventHandler ColumnRemoved;
	public event System.Windows.Forms.DataGridViewColumnEventHandler ColumnSortModeChanged;
	public event System.Windows.Forms.DataGridViewColumnStateChangedEventHandler ColumnStateChanged;
	public event System.Windows.Forms.DataGridViewColumnEventHandler ColumnToolTipTextChanged;
	public event System.Windows.Forms.DataGridViewColumnEventHandler ColumnWidthChanged;
	public event System.EventHandler CurrentCellChanged;
	public event System.EventHandler CurrentCellDirtyStateChanged;
	public event System.Windows.Forms.DataGridViewBindingCompleteEventHandler DataBindingComplete;
	public event System.Windows.Forms.DataGridViewDataErrorEventHandler DataError;
	public event System.Windows.Forms.DataGridViewRowEventHandler DefaultValuesNeeded;
	public event System.Windows.Forms.DataGridViewEditingControlShowingEventHandler EditingControlShowing;
	public event System.Windows.Forms.DataGridViewRowEventHandler NewRowNeeded;
	public event System.Windows.Forms.DataGridViewRowEventHandler RowContextMenuStripChanged;
	public event System.Windows.Forms.DataGridViewRowContextMenuStripNeededEventHandler RowContextMenuStripNeeded;
	public event System.Windows.Forms.DataGridViewRowEventHandler RowDefaultCellStyleChanged;
	public event System.Windows.Forms.QuestionEventHandler RowDirtyStateNeeded;
	public event System.Windows.Forms.DataGridViewRowDividerDoubleClickEventHandler RowDividerDoubleClick;
	public event System.Windows.Forms.DataGridViewRowEventHandler RowDividerHeightChanged;
	public event System.Windows.Forms.DataGridViewCellEventHandler RowEnter;
	public event System.Windows.Forms.DataGridViewRowEventHandler RowErrorTextChanged;
	public event System.Windows.Forms.DataGridViewRowErrorTextNeededEventHandler RowErrorTextNeeded;
	public event System.Windows.Forms.DataGridViewCellMouseEventHandler RowHeaderMouseClick;
	public event System.Windows.Forms.DataGridViewCellMouseEventHandler RowHeaderMouseDoubleClick;
	public event System.Windows.Forms.DataGridViewRowEventHandler RowHeaderCellChanged;
	public event System.Windows.Forms.DataGridViewRowEventHandler RowHeightChanged;
	public event System.Windows.Forms.DataGridViewRowHeightInfoNeededEventHandler RowHeightInfoNeeded;
	public event System.Windows.Forms.DataGridViewRowHeightInfoPushedEventHandler RowHeightInfoPushed;
	public event System.Windows.Forms.DataGridViewCellEventHandler RowLeave;
	public event System.Windows.Forms.DataGridViewRowEventHandler RowMinimumHeightChanged;
	public event System.Windows.Forms.DataGridViewRowPostPaintEventHandler RowPostPaint;
	public event System.Windows.Forms.DataGridViewRowPrePaintEventHandler RowPrePaint;
	public event System.Windows.Forms.DataGridViewRowsAddedEventHandler RowsAdded;
	public event System.Windows.Forms.DataGridViewRowsRemovedEventHandler RowsRemoved;
	public event System.Windows.Forms.DataGridViewRowStateChangedEventHandler RowStateChanged;
	public event System.Windows.Forms.DataGridViewRowEventHandler RowUnshared;
	public event System.Windows.Forms.DataGridViewCellEventHandler RowValidated;
	public event System.Windows.Forms.DataGridViewCellCancelEventHandler RowValidating;
	public event System.Windows.Forms.ScrollEventHandler Scroll;
	public event System.EventHandler SelectionChanged;
	public event System.Windows.Forms.DataGridViewSortCompareEventHandler SortCompare;
	public event System.EventHandler Sorted;
	public event System.EventHandler StyleChanged;
	public event System.Windows.Forms.DataGridViewRowEventHandler UserAddedRow;
	public event System.Windows.Forms.DataGridViewRowEventHandler UserDeletedRow;
	public event System.Windows.Forms.DataGridViewRowCancelEventHandler UserDeletingRow;
	public event System.EventHandler AutoSizeChanged;
	public event System.EventHandler BindingContextChanged;
	public event System.EventHandler CausesValidationChanged;
	public event System.EventHandler ClientSizeChanged;
	public event System.EventHandler ContextMenuChanged;
	public event System.EventHandler ContextMenuStripChanged;
	public event System.EventHandler CursorChanged;
	public event System.EventHandler DockChanged;
	public event System.EventHandler EnabledChanged;
	public event System.EventHandler LocationChanged;
	public event System.EventHandler MarginChanged;
	public event System.EventHandler RegionChanged;
	public event System.EventHandler RightToLeftChanged;
	public event System.EventHandler SizeChanged;
	public event System.EventHandler TabIndexChanged;
	public event System.EventHandler TabStopChanged;
	public event System.EventHandler VisibleChanged;
	public event System.EventHandler Click;
	public event System.Windows.Forms.ControlEventHandler ControlAdded;
	public event System.Windows.Forms.ControlEventHandler ControlRemoved;
	public event System.Windows.Forms.DragEventHandler DragDrop;
	public event System.Windows.Forms.DragEventHandler DragEnter;
	public event System.Windows.Forms.DragEventHandler DragOver;
	public event System.EventHandler DragLeave;
	public event System.Windows.Forms.GiveFeedbackEventHandler GiveFeedback;
	public event System.EventHandler HandleCreated;
	public event System.EventHandler HandleDestroyed;
	public event System.Windows.Forms.HelpEventHandler HelpRequested;
	public event System.Windows.Forms.InvalidateEventHandler Invalidated;
	public event System.Windows.Forms.PaintEventHandler Paint;
	public event System.Windows.Forms.QueryContinueDragEventHandler QueryContinueDrag;
	public event System.Windows.Forms.QueryAccessibilityHelpEventHandler QueryAccessibilityHelp;
	public event System.EventHandler DoubleClick;
	public event System.EventHandler Enter;
	public event System.EventHandler GotFocus;
	public event System.Windows.Forms.KeyEventHandler KeyDown;
	public event System.Windows.Forms.KeyPressEventHandler KeyPress;
	public event System.Windows.Forms.KeyEventHandler KeyUp;
	public event System.Windows.Forms.LayoutEventHandler Layout;
	public event System.EventHandler Leave;
	public event System.EventHandler LostFocus;
	public event System.Windows.Forms.MouseEventHandler MouseClick;
	public event System.Windows.Forms.MouseEventHandler MouseDoubleClick;
	public event System.EventHandler MouseCaptureChanged;
	public event System.Windows.Forms.MouseEventHandler MouseDown;
	public event System.EventHandler MouseEnter;
	public event System.EventHandler MouseLeave;
	public event System.EventHandler MouseHover;
	public event System.Windows.Forms.MouseEventHandler MouseMove;
	public event System.Windows.Forms.MouseEventHandler MouseUp;
	public event System.Windows.Forms.MouseEventHandler MouseWheel;
	public event System.EventHandler Move;
	public event System.Windows.Forms.PreviewKeyDownEventHandler PreviewKeyDown;
	public event System.EventHandler Resize;
	public event System.Windows.Forms.UICuesEventHandler ChangeUICues;
	public event System.EventHandler SystemColorsChanged;
	public event System.ComponentModel.CancelEventHandler Validating;
	public event System.EventHandler Validated;
	public event System.EventHandler ParentChanged;
	public event System.EventHandler ImeModeChanged;
	public event System.EventHandler Disposed;
}

