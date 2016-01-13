public class ToolStripSystemRenderer : ToolStripRenderer
{

	// Constructors
	public ToolStripSystemRenderer() {}

	// Methods
	public void DrawArrow(ToolStripArrowRenderEventArgs e) {}
	public void DrawToolStripBackground(ToolStripRenderEventArgs e) {}
	public void DrawGrip(ToolStripGripRenderEventArgs e) {}
	public void DrawItemBackground(ToolStripItemRenderEventArgs e) {}
	public void DrawImageMargin(ToolStripRenderEventArgs e) {}
	public void DrawLabelBackground(ToolStripItemRenderEventArgs e) {}
	public void DrawButtonBackground(ToolStripItemRenderEventArgs e) {}
	public void DrawToolStripBorder(ToolStripRenderEventArgs e) {}
	public void DrawDropDownButtonBackground(ToolStripItemRenderEventArgs e) {}
	public void DrawOverflowButtonBackground(ToolStripItemRenderEventArgs e) {}
	public void DrawItemImage(ToolStripItemImageRenderEventArgs e) {}
	public void DrawItemCheck(ToolStripItemImageRenderEventArgs e) {}
	public void DrawItemText(ToolStripItemTextRenderEventArgs e) {}
	public void DrawMenuItemBackground(ToolStripItemRenderEventArgs e) {}
	public void DrawSplitButton(ToolStripItemRenderEventArgs e) {}
	public void DrawToolStripStatusLabelBackground(ToolStripItemRenderEventArgs e) {}
	public void DrawStatusStripSizingGrip(ToolStripRenderEventArgs e) {}
	public void DrawSeparator(ToolStripSeparatorRenderEventArgs e) {}
	public void DrawToolStripPanelBackground(ToolStripPanelRenderEventArgs e) {}
	public void DrawToolStripContentPanelBackground(ToolStripContentPanelRenderEventArgs e) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

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

