using System.ComponentModel.Composition;
using EventMapHpViewer.Models;
using EventMapHpViewer.ViewModels;
using Grabacr07.KanColleViewer.Composition;

namespace EventMapHpViewer
{
    [Export(typeof(IToolPlugin))]
    [ExportMetadata("Title", "海域血量查看器")]
    [ExportMetadata("Description", "显示当前海域的血量")]
    [ExportMetadata("Version", "2.2.1")]
    [ExportMetadata("Author", "@veigr")]
    public class MapHpViewer : IToolPlugin
    {
        private readonly ToolViewModel _vm = new ToolViewModel(new MapInfoProxy());

        public object GetToolView()
        {
            return new ToolView {DataContext = this._vm};
        }

        public string ToolName
        {
            get { return "海域血量"; }
        }

        public object GetSettingsView()
        {
            return null;
        }
    }
}
