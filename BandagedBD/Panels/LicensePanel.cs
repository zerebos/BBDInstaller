using System.Windows.Forms;

namespace BandagedBD.Panels {

    public partial class LicensePanel : UserControl, IPanel {

        private FormMain Window;
        public void SetWindow(FormMain formMain) => Window = formMain;

        public string Title => "License Agreement";
        public UserControl Control => this;

        public PanelTypes PreviousPanel => PanelTypes.NONE;
        public PanelTypes NextPanel => PanelTypes.Action;

        public LicensePanel() {
            InitializeComponent();
            richTextBox1.Text += Properties.Resources.License;
        }

        public void OnShow() {
            Window.btnBack.HideDisable();
            Window.btnNext.ShowEnable("Agree");
            Window.btnCancel.ShowEnable("Decline");
        }
    }
}
