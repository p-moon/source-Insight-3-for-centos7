public class TransparentToolStrip : System.Windows.Forms.ToolStrip, System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods.IOleControl, System.Windows.Forms.UnsafeNativeMethods.IOleObject, System.Windows.Forms.UnsafeNativeMethods.IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods.IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods.IOleWindow, System.Windows.Forms.UnsafeNativeMethods.IViewObject, System.Windows.Forms.UnsafeNativeMethods.IViewObject2, System.Windows.Forms.UnsafeNativeMethods.IPersist, System.Windows.Forms.UnsafeNativeMethods.IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods.IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods.IPersistStorage, System.Windows.Forms.UnsafeNativeMethods.IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.ISupportToolStripPanel
{

	// Constructors
	public TransparentToolStrip(ToolStripTemplateNode owner) {}

	// Methods
	public virtual System.Drawing.Size GetPreferredSize(System.Drawing.Size proposedSize) {}
	public void SetAutoScrollMargin(int x, int y) {}
	public virtual string ToString() {}
	public virtual System.Windows.Forms.ToolStripItem GetNextItem(System.Windows.Forms.ToolStripItem start, System.Windows.Forms.ArrowDirection direction) {}
	public System.Windows.Forms.Control GetChildAtPoint(System.Drawing.Point point) {}
	public System.Windows.Forms.Control GetChildAtPoint(System.Drawing.Point pt, System.Windows.Forms.GetChildAtPointSkip skipValue) {}
	public System.Windows.Forms.ToolStripItem GetItemAt(int x, int y) {}
	public System.Windows.Forms.ToolStripItem GetItemAt(System.Drawing.Point point) {}
	public void ResetMinimumSize() {}
	public void ScrollControlIntoView(System.Windows.Forms.Control activeControl) {}
	public void SetAutoScrollMargin(int x, int y) {}
	public void ResetImeMode() {}
	public void PerformLayout() {}
	public virtual bool PreProcessMessage(System.Windows.Forms.Message& msg) {}
	public virtual void ResetBackColor() {}
	public virtual void ResetCursor() {}
	public virtual void ResetFont() {}
	public virtual void ResetForeColor() {}
	public virtual void ResetRightToLeft() {}
	public virtual void Refresh() {}
	public virtual void ResetText() {}
	public void ResumeLayout() {}
	public void ResumeLayout(bool performLayout) {}
	public void SetBounds(int x, int y, int width, int height, System.Windows.Forms.BoundsSpecified specified) {}
	public void SuspendLayout() {}
	public void PerformLayout(System.Windows.Forms.Control affectedControl, string affectedProperty) {}
	public System.Drawing.Point PointToClient(System.Drawing.Point p) {}
	public System.Drawing.Point PointToScreen(System.Drawing.Point p) {}
	public System.Windows.Forms.PreProcessControlState PreProcessControlMessage(System.Windows.Forms.Message& msg) {}
	public System.Drawing.Rectangle RectangleToClient(System.Drawing.Rectangle r) {}
	public System.Drawing.Rectangle RectangleToScreen(System.Drawing.Rectangle r) {}
	public void Scale(float ratio) {}
	public void Scale(float dx, float dy) {}
	public void Scale(System.Drawing.SizeF factor) {}
	public void Select() {}
	public bool SelectNextControl(System.Windows.Forms.Control ctl, bool forward, bool tabStopOnly, bool nested, bool wrap) {}
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
	public bool Contains(System.Windows.Forms.Control ctl) {}
	public System.Drawing.Graphics CreateGraphics() {}
	public System.Windows.Forms.DragDropEffects DoDragDrop(object data, System.Windows.Forms.DragDropEffects allowedEffects) {}
	public void DrawToBitmap(System.Drawing.Bitmap bitmap, System.Drawing.Rectangle targetBounds) {}
	public System.Windows.Forms.Form FindForm() {}
	public bool Focus() {}
	public System.Windows.Forms.Control GetChildAtPoint(System.Drawing.Point pt, System.Windows.Forms.GetChildAtPointSkip skipValue) {}
	public System.Windows.Forms.Control GetChildAtPoint(System.Drawing.Point pt) {}
	public System.Windows.Forms.IContainerControl GetContainerControl() {}
	public System.Windows.Forms.Control GetNextControl(System.Windows.Forms.Control ctl, bool forward) {}
	public void Hide() {}
	public void Invalidate(System.Drawing.Region region) {}
	public void Invalidate(System.Drawing.Region region, bool invalidateChildren) {}
	public void Invalidate(bool invalidateChildren) {}
	public void Invalidate(System.Drawing.Rectangle rc) {}
	public void Invalidate(System.Drawing.Rectangle rc, bool invalidateChildren) {}
	public object Invoke(System.Delegate method) {}
	public void ResetBindings() {}
	public virtual void Dispose() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ToolStripTemplateNode TemplateNode { get{} }
	public bool AutoSize { get{} set{} }
	public bool AutoScroll { get{} set{} }
	public System.Drawing.Size AutoScrollMargin { get{} set{} }
	public System.Drawing.Size AutoScrollMinSize { get{} set{} }
	public System.Drawing.Point AutoScrollPosition { get{} set{} }
	public bool AllowDrop { get{} set{} }
	public bool AllowItemReorder { get{} set{} }
	public bool AllowMerge { get{} set{} }
	public System.Windows.Forms.AnchorStyles Anchor { get{} set{} }
	public System.Drawing.Color BackColor { get{} set{} }
	public System.Windows.Forms.BindingContext BindingContext { get{} set{} }
	public bool CanOverflow { get{} set{} }
	public bool CausesValidation { get{} set{} }
	public System.Windows.Forms.Control.ControlCollection Controls { get{} }
	public System.Windows.Forms.Cursor Cursor { get{} set{} }
	public System.Drawing.Font Font { get{} set{} }
	public System.Windows.Forms.ToolStripDropDownDirection DefaultDropDownDirection { get{} set{} }
	public System.Windows.Forms.DockStyle Dock { get{} set{} }
	public System.Drawing.Rectangle DisplayRectangle { get{} }
	public System.Drawing.Color ForeColor { get{} set{} }
	public System.Windows.Forms.ToolStripGripStyle GripStyle { get{} set{} }
	public System.Windows.Forms.ToolStripGripDisplayStyle GripDisplayStyle { get{} }
	public System.Windows.Forms.Padding GripMargin { get{} set{} }
	public System.Drawing.Rectangle GripRectangle { get{} }
	public bool HasChildren { get{} }
	public System.Windows.Forms.HScrollProperties HorizontalScroll { get{} }
	public System.Drawing.Size ImageScalingSize { get{} set{} }
	public System.Windows.Forms.ImageList ImageList { get{} set{} }
	public bool IsCurrentlyDragging { get{} }
	public System.Windows.Forms.ToolStripItemCollection Items { get{} }
	public bool IsDropDown { get{} }
	public System.Windows.Forms.LayoutSettings LayoutSettings { get{} set{} }
	public System.Windows.Forms.ToolStripLayoutStyle LayoutStyle { get{} set{} }
	public System.Windows.Forms.Layout.LayoutEngine LayoutEngine { get{} }
	public System.Windows.Forms.ToolStripOverflowButton OverflowButton { get{} }
	public System.Windows.Forms.Orientation Orientation { get{} }
	public bool Stretch { get{} set{} }
	public System.Windows.Forms.ToolStripRenderer Renderer { get{} set{} }
	public System.Windows.Forms.ToolStripRenderMode RenderMode { get{} set{} }
	public bool ShowItemToolTips { get{} set{} }
	public bool TabStop { get{} set{} }
	public System.Windows.Forms.ToolStripTextDirection TextDirection { get{} set{} }
	public System.Windows.Forms.VScrollProperties VerticalScroll { get{} }
	public System.Windows.Forms.ScrollableControl.DockPaddingEdges DockPadding { get{} }
	public System.Windows.Forms.AccessibleObject AccessibilityObject { get{} }
	public string AccessibleDefaultActionDescription { get{} set{} }
	public string AccessibleDescription { get{} set{} }
	public string AccessibleName { get{} set{} }
	public System.Windows.Forms.AccessibleRole AccessibleRole { get{} set{} }
	public System.Drawing.Point AutoScrollOffset { get{} set{} }
	public System.Drawing.Image BackgroundImage { get{} set{} }
	public System.Windows.Forms.ImageLayout BackgroundImageLayout { get{} set{} }
	public int Bottom { get{} }
	public System.Drawing.Rectangle Bounds { get{} set{} }
	public bool CanFocus { get{} }
	public bool CanSelect { get{} }
	public bool Capture { get{} set{} }
	public System.Drawing.Rectangle ClientRectangle { get{} }
	public System.Drawing.Size ClientSize { get{} set{} }
	public string CompanyName { get{} }
	public bool ContainsFocus { get{} }
	public System.Windows.Forms.ContextMenu ContextMenu { get{} set{} }
	public System.Windows.Forms.ContextMenuStrip ContextMenuStrip { get{} set{} }
	public bool Created { get{} }
	public System.Windows.Forms.ControlBindingsCollection DataBindings { get{} }
	public bool IsDisposed { get{} }
	public bool Disposing { get{} }
	public bool Enabled { get{} set{} }
	public bool Focused { get{} }
	public System.IntPtr Handle { get{} }
	public int Height { get{} set{} }
	public bool IsHandleCreated { get{} }
	public bool InvokeRequired { get{} }
	public bool IsAccessible { get{} set{} }
	public bool IsMirrored { get{} }
	public int Left { get{} set{} }
	public System.Drawing.Point Location { get{} set{} }
	public System.Windows.Forms.Padding Margin { get{} set{} }
	public System.Drawing.Size MaximumSize { get{} set{} }
	public System.Drawing.Size MinimumSize { get{} set{} }
	public string Name { get{} set{} }
	public System.Windows.Forms.Control Parent { get{} set{} }
	public string ProductName { get{} }
	public string ProductVersion { get{} }
	public bool RecreatingHandle { get{} }
	public System.Drawing.Region Region { get{} set{} }
	public int Right { get{} }
	public System.Windows.Forms.RightToLeft RightToLeft { get{} set{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.Drawing.Size Size { get{} set{} }
	public int TabIndex { get{} set{} }
	public object Tag { get{} set{} }
	public string Text { get{} set{} }
	public int Top { get{} set{} }
	public System.Windows.Forms.Control TopLevelControl { get{} }
	public bool UseWaitCursor { get{} set{} }
	public bool Visible { get{} set{} }
	public int Width { get{} set{} }
	public System.Windows.Forms.IWindowTarget WindowTarget { get{} set{} }
	public System.Drawing.Size PreferredSize { get{} }
	public System.Windows.Forms.Padding Padding { get{} set{} }
	public System.Windows.Forms.ImeMode ImeMode { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.EventHandler AutoSizeChanged;
	public event System.EventHandler BeginDrag;
	public event System.EventHandler CausesValidationChanged;
	public event System.Windows.Forms.ControlEventHandler ControlAdded;
	public event System.EventHandler CursorChanged;
	public event System.Windows.Forms.ControlEventHandler ControlRemoved;
	public event System.EventHandler EndDrag;
	public event System.EventHandler ForeColorChanged;
	public event System.Windows.Forms.ToolStripItemEventHandler ItemAdded;
	public event System.Windows.Forms.ToolStripItemClickedEventHandler ItemClicked;
	public event System.Windows.Forms.ToolStripItemEventHandler ItemRemoved;
	public event System.EventHandler LayoutCompleted;
	public event System.EventHandler LayoutStyleChanged;
	public event System.Windows.Forms.PaintEventHandler PaintGrip;
	public event System.EventHandler RendererChanged;
	public event System.Windows.Forms.ScrollEventHandler Scroll;
	public event System.EventHandler BackColorChanged;
	public event System.EventHandler BackgroundImageChanged;
	public event System.EventHandler BackgroundImageLayoutChanged;
	public event System.EventHandler BindingContextChanged;
	public event System.EventHandler ClientSizeChanged;
	public event System.EventHandler ContextMenuChanged;
	public event System.EventHandler ContextMenuStripChanged;
	public event System.EventHandler DockChanged;
	public event System.EventHandler EnabledChanged;
	public event System.EventHandler FontChanged;
	public event System.EventHandler LocationChanged;
	public event System.EventHandler MarginChanged;
	public event System.EventHandler RegionChanged;
	public event System.EventHandler RightToLeftChanged;
	public event System.EventHandler SizeChanged;
	public event System.EventHandler TabIndexChanged;
	public event System.EventHandler TabStopChanged;
	public event System.EventHandler TextChanged;
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
	public event System.EventHandler PaddingChanged;
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

