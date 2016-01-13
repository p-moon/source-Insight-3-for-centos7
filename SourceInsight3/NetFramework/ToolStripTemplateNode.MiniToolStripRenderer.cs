public class MiniToolStripRenderer : System.Windows.Forms.ToolStripSystemRenderer
{

	// Constructors
	public MiniToolStripRenderer(ToolStripTemplateNode owner) {}

	// Methods
	public void DrawArrow(System.Windows.Forms.ToolStripArrowRenderEventArgs e) {}
	public void DrawToolStripBackground(System.Windows.Forms.ToolStripRenderEventArgs e) {}
	public void DrawGrip(System.Windows.Forms.ToolStripGripRenderEventArgs e) {}
	public void DrawItemBackground(System.Windows.Forms.ToolStripItemRenderEventArgs e) {}
	public void DrawImageMargin(System.Windows.Forms.ToolStripRenderEventArgs e) {}
	public void DrawLabelBackground(System.Windows.Forms.ToolStripItemRenderEventArgs e) {}
	public void DrawButtonBackground(System.Windows.Forms.ToolStripItemRenderEventArgs e) {}
	public void DrawToolStripBorder(System.Windows.Forms.ToolStripRenderEventArgs e) {}
	public void DrawDropDownButtonBackground(System.Windows.Forms.ToolStripItemRenderEventArgs e) {}
	public void DrawOverflowButtonBackground(System.Windows.Forms.ToolStripItemRenderEventArgs e) {}
	public void DrawItemImage(System.Windows.Forms.ToolStripItemImageRenderEventArgs e) {}
	public void DrawItemCheck(System.Windows.Forms.ToolStripItemImageRenderEventArgs e) {}
	public void DrawItemText(System.Windows.Forms.ToolStripItemTextRenderEventArgs e) {}
	public void DrawMenuItemBackground(System.Windows.Forms.ToolStripItemRenderEventArgs e) {}
	public void DrawSplitButton(System.Windows.Forms.ToolStripItemRenderEventArgs e) {}
	public void DrawToolStripStatusLabelBackground(System.Windows.Forms.ToolStripItemRenderEventArgs e) {}
	public void DrawStatusStripSizingGrip(System.Windows.Forms.ToolStripRenderEventArgs e) {}
	public void DrawSeparator(System.Windows.Forms.ToolStripSeparatorRenderEventArgs e) {}
	public void DrawToolStripPanelBackground(System.Windows.Forms.ToolStripPanelRenderEventArgs e) {}
	public void DrawToolStripContentPanelBackground(System.Windows.Forms.ToolStripContentPanelRenderEventArgs e) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int State { get{} set{} }

	// Events
	public event System.Windows.Forms.ToolStripArrowRenderEventHandler RenderArrow;
	public event System.Windows.Forms.ToolStripRenderEventHandler RenderToolStripBackground;
	public event System.Windows.Forms.ToolStripPanelRenderEventHandler RenderToolStripPanelBackground;
	public event System.Windows.Forms.ToolStripContentPanelRenderEventHandler RenderToolStripContentPanelBackground;
	public event System.Windows.Forms.ToolStripRenderEventHandler RenderToolStripBorder;
	public event System.Windows.Forms.ToolStripItemRenderEventHandler RenderButtonBackground;
	public event System.Windows.Forms.ToolStripItemRenderEventHandler RenderDropDownButtonBackground;
	public event System.Windows.Forms.ToolStripItemRenderEventHandler RenderOverflowButtonBackground;
	public event System.Windows.Forms.ToolStripGripRenderEventHandler RenderGrip;
	public event System.Windows.Forms.ToolStripItemRenderEventHandler RenderItemBackground;
	public event System.Windows.Forms.ToolStripItemImageRenderEventHandler RenderItemImage;
	public event System.Windows.Forms.ToolStripItemImageRenderEventHandler RenderItemCheck;
	public event System.Windows.Forms.ToolStripItemTextRenderEventHandler RenderItemText;
	public event System.Windows.Forms.ToolStripRenderEventHandler RenderImageMargin;
	public event System.Windows.Forms.ToolStripItemRenderEventHandler RenderLabelBackground;
	public event System.Windows.Forms.ToolStripItemRenderEventHandler RenderMenuItemBackground;
	public event System.Windows.Forms.ToolStripItemRenderEventHandler RenderToolStripStatusLabelBackground;
	public event System.Windows.Forms.ToolStripRenderEventHandler RenderStatusStripSizingGrip;
	public event System.Windows.Forms.ToolStripItemRenderEventHandler RenderSplitButtonBackground;
	public event System.Windows.Forms.ToolStripSeparatorRenderEventHandler RenderSeparator;
}

