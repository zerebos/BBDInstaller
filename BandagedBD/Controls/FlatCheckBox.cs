using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace BandagedBD.Controls {
    class FlatCheckBox : CheckBox {

        [Description("Background color for the CheckBox"), Category("Flatpak")]
        public Color BoxBackColor { get; set; } = Color.FromArgb(60, 60, 60);

        [Description("Foreground color for the CheckBox"), Category("Flatpak")]
        public Color BoxForeColor { get; set; } = Properties.Settings.Default.Accent;

        public FlatCheckBox() {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);
            e.Graphics.FillRectangle(new SolidBrush(BoxBackColor), new Rectangle(0, 0, 13, 14));
            if (Checked) {
                e.Graphics.TextRenderingHint = TextRenderingHint.AntiAlias;
                e.Graphics.DrawString("\u2714", this.Font, new SolidBrush(BoxForeColor), -1, 1);
            }
        }
    }
}
