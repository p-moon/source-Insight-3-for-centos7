public class SplitContainer : ContainerControl, System.ComponentModel.IComponent, System.IDisposable, IOleControl, IOleObject, IOleInPlaceObject, IOleInPlaceActiveObject, IOleWindow, IViewObject, IViewObject2, IPersist, IPersistStreamInit, IPersistPropertyBag, IPersistStorage, IQuickActivate, ISupportOleDropSource, IDropTarget, System.ComponentModel.ISynchronizeInvoke, IWin32Window, System.Windows.Forms.Layout.IArrangedElement, IBindableComponent, IContainerControl
{

	// Constructors
	public SplitContainer() {}

	// Methods
	public void OnSplitterMoving(SplitterCancelEventArgs e) {}
	public void OnSplitterMoved(SplitterEventArgs e) {}
	public void PerformAutoScale() {}
	public bool Validate() {}
	public bool Validate(bool checkAutoValidate) {}
	public virtual bool ValidateChildren() {}
	public virtual bool ValidateChildren(ValidationConstraints validationConstraints) {}
	public void ScrollControlIntoView(Control activeControl) {}
	public void SetAutoScrollMargin(int x, int y) {}
	public void ResetImeMode() {}
	public void PerformLayout() {}
	public virtual bool PreProcessMessage(Message& msg) {}
	public virtual void ResetBackColor() {}
	public virtual void ResetCursor() {}
	public virtual void ResetFont() {}
	public virtual void ResetForeColor() {}
	public virtual void ResetRightToLeft() {}
	public virtual void Refresh() {}
	public virtual void ResetText() {}
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
	public bool AutoScroll { get{} set{} }
	public System.Drawing.Point AutoScrollOffset { get{} set{} }
	public System.Drawing.Size AutoScrollMinSize { get{} set{} }
	public System.Drawing.Size AutoScrollMargin { get{} set{} }
	public System.Drawing.Point AutoScrollPosition { get{} set{} }
	public bool AutoSize { get{} set{} }
	public System.Drawing.Image BackgroundImage { get{} set{} }
	public ImageLayout BackgroundImageLayout { get{} set{} }
	public BindingContext BindingContext { get{} set{} }
	public BorderStyle BorderStyle { get{} set{} }
	public ControlCollection Controls { get{} }
	public DockStyle Dock { get{} set{} }
	public FixedPanel FixedPanel { get{} set{} }
	public bool IsSplitterFixed { get{} set{} }
	public Orientation Orientation { get{} set{} }
	public SplitterPanel Panel1 { get{} }
	public Padding Padding { get{} set{} }
	public bool Panel1Collapsed { get{} set{} }
	public bool Panel2Collapsed { get{} set{} }
	public int Panel1MinSize { get{} set{} }
	public SplitterPanel Panel2 { get{} }
	public int Panel2MinSize { get{} set{} }
	public int SplitterDistance { get{} set{} }
	public int SplitterIncrement { get{} set{} }
	public System.Drawing.Rectangle SplitterRectangle { get{} }
	public int SplitterWidth { get{} set{} }
	public bool TabStop { get{} set{} }
	public string Text { get{} set{} }
	public System.Drawing.SizeF AutoScaleDimensions { get{} set{} }
	public AutoScaleMode AutoScaleMode { get{} set{} }
	public AutoValidate AutoValidate { get{} set{} }
	public Control ActiveControl { get{} set{} }
	public System.Drawing.SizeF CurrentAutoScaleDimensions { get{} }
	public Form ParentForm { get{} }
	public System.Drawing.Rectangle DisplayRectangle { get{} }
	public HScrollProperties HorizontalScroll { get{} }
	public VScrollProperties VerticalScroll { get{} }
	public DockPaddingEdges DockPadding { get{} }
	public AccessibleObject AccessibilityObject { get{} }
	public string AccessibleDefaultActionDescription { get{} set{} }
	public string AccessibleDescription { get{} set{} }
	public string AccessibleName { get{} set{} }
	public AccessibleRole AccessibleRole { get{} set{} }
	public bool AllowDrop { get{} set{} }
	public AnchorStyles Anchor { get{} set{} }
	public System.Windows.Forms.Layout.LayoutEngine LayoutEngine { get{} }
	public System.Drawing.Color BackColor { get{} set{} }
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
	public bool Created { get{} }
	public Cursor Cursor { get{} set{} }
	public ControlBindingsCollection DataBindings { get{} }
	public bool IsDisposed { get{} }
	public bool Disposing { get{} }
	public bool Enabled { get{} set{} }
	public bool Focused { get{} }
	public System.Drawing.Font Font { get{} set{} }
	public System.Drawing.Color ForeColor { get{} set{} }
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
	public event System.EventHandler AutoSizeChanged;
	public event System.Windows.Forms.ControlEventHandler ControlAdded;
	public event System.Windows.Forms.ControlEventHandler ControlRemoved;
	public event System.EventHandler PaddingChanged;
	public event System.EventHandler BackgroundImageChanged;
	public event System.EventHandler BackgroundImageLayoutChanged;
	public event System.Windows.Forms.SplitterCancelEventHandler SplitterMoving;
	public event System.Windows.Forms.SplitterEventHandler SplitterMoved;
	public event System.EventHandler TextChanged;
	public event System.EventHandler AutoValidateChanged;
	public event System.Windows.Forms.ScrollEventHandler Scroll;
	public event System.EventHandler BackColorChanged;
	public event System.EventHandler BindingContextChanged;
	public event System.EventHandler CausesValidationChanged;
	public event System.EventHandler ClientSizeChanged;
	public event System.EventHandler ContextMenuChanged;
	public event System.EventHandler ContextMenuStripChanged;
	public event System.EventHandler CursorChanged;
	public event System.EventHandler DockChanged;
	public event System.EventHandler EnabledChanged;
	public event System.EventHandler FontChanged;
	public event System.EventHandler ForeColorChanged;
	public event System.EventHandler LocationChanged;
	public event System.EventHandler MarginChanged;
	public event System.EventHandler RegionChanged;
	public event System.EventHandler RightToLeftChanged;
	public event System.EventHandler SizeChanged;
	public event System.EventHandler TabIndexChanged;
	public event System.EventHandler TabStopChanged;
	public event System.EventHandler VisibleChanged;
	public event System.EventHandler Click;
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
	public event System.EventHandler StyleChanged;
	public event System.EventHandler SystemColorsChanged;
	public event System.ComponentModel.CancelEventHandler Validating;
	public event System.EventHandler Validated;
	public event System.EventHandler ParentChanged;
	public event System.EventHandler ImeModeChanged;
	public event System.EventHandler Disposed;
}

