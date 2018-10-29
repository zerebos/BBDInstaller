using System.Windows.Forms;

namespace BandagedBD.Panels {
    public interface IPanel {
        void OnShow();
        void SetWindow(FormMain window);
        string Title { get; }
        UserControl Control { get; }
        PanelTypes PreviousPanel { get; }
        PanelTypes NextPanel { get; }
    }
}
