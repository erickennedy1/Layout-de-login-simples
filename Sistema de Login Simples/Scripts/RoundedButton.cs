using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedButton : Button
{
    private int borderRadius = 20; 

    public int BorderRadius
    {
        get => borderRadius;
        set
        {
            borderRadius = value;
            this.Invalidate();
        }
    }

    protected override void OnPaint(PaintEventArgs pevent)
    {
        base.OnPaint(pevent);

        GraphicsPath path = new GraphicsPath();
        path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
        path.AddArc(this.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
        path.AddArc(this.Width - borderRadius, this.Height - borderRadius, borderRadius, borderRadius, 0, 90);
        path.AddArc(0, this.Height - borderRadius, borderRadius, borderRadius, 90, 90);
        path.CloseAllFigures();

        this.Region = new Region(path);
    }
}
