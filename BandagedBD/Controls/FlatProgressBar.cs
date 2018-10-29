using System.Drawing;
using System.Windows.Forms;

namespace BandagedBD.Controls {
    public class FlatProgressBar : ProgressBar {
        public FlatProgressBar() {
            SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaintBackground(PaintEventArgs pevent) {
            // None... Helps control the flicker.
            // No seriously, it works.
        }

        protected override void OnPaint(PaintEventArgs e) {
            using (Image offscreenImage = new Bitmap(Width, Height)) {
                using (Graphics offscreen = Graphics.FromImage(offscreenImage)) {
                    Rectangle rect = new Rectangle(0, 0, Width, Height);
                    offscreen.FillRectangle(new SolidBrush(BackColor), rect);
                    rect.Width = (int) (rect.Width * ((double) (Value - Minimum) / (Maximum - Minimum)));
                    if (rect.Width > 0) offscreen.FillRectangle(new SolidBrush(ForeColor), 0, 0, rect.Width, rect.Height);
                    e.Graphics.DrawImage(offscreenImage, 0, 0);
                    offscreenImage.Dispose();
                }
            }
        }
    }
}
