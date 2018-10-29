using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace BandagedBD.Controls {
    class FlatCheckBox : CheckBox {
        public FlatCheckBox() {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);
            e.Graphics.FillRectangle(new SolidBrush(Properties.Settings.Default.SecondaryBackground), new Rectangle(0, 0, 13, 14));
            if (Checked) {
                e.Graphics.TextRenderingHint = TextRenderingHint.AntiAlias;
                e.Graphics.DrawString("\u2714", this.Font, new SolidBrush(Properties.Settings.Default.Accent), -1, 1);
            }
        }
    }
}
