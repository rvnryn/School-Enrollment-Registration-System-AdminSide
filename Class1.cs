using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

public class RoundedPanel : Panel
{
    private int _cornerRadius = 10;

    public int CornerRadius
    {
        get { return _cornerRadius; }
        set
        {
            _cornerRadius = value;
            Invalidate(); // Update the panel when the CornerRadius property changes.
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        GraphicsPath path = new GraphicsPath();
        path.AddRoundedRectangle(new Rectangle(0, 0, Width, Height), _cornerRadius);

        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        Region = new Region(path);

        // Fill the panel with the background color.
        e.Graphics.FillPath(new SolidBrush(BackColor), path);

        // Draw the panel's border.
        if (BorderStyle == BorderStyle.FixedSingle)
        {
            e.Graphics.DrawPath(new Pen(ForeColor), path);
        }
    }
}

// Create a static class to hold the extension method
public static class GraphicsPathExtensions
{
    public static void AddRoundedRectangle(this GraphicsPath path, Rectangle rect, int radius)
    {
        // Prevent potential overflow with Math.Max to ensure valid dimensions
        int x = rect.X;
        int y = rect.Y;
        int width = Math.Max(0, rect.Width);
        int height = Math.Max(0, rect.Height);

        path.AddArc(x, y, radius, radius, 180, 90);
        path.AddLine(x + radius, y, x + width - radius, y);
        path.AddArc(x + width - radius, y, radius, radius, 270, 90);
        path.AddLine(x + width, y + radius, x + width, y + height - radius);
        path.AddArc(x + width - radius, y + height - radius, radius, radius, 0, 90);
        path.AddLine(x + width - radius, y + height, x + radius, y + height);
        path.AddArc(x, y + height - radius, radius, radius, 90, 90);
        path.AddLine(x, y + height - radius, x, y + radius);
        path.CloseFigure();
    }
}