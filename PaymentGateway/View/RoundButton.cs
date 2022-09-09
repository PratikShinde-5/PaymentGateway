using System.Drawing.Drawing2D;

namespace PaymentGateway.View
{
    public class RoundButton : Button
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            var graphicsPath = new GraphicsPath();
            graphicsPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            Region = new Region(graphicsPath);
            base.OnPaint(e);
        }
    }
}