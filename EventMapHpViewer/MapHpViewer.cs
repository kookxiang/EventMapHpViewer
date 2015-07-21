using System.ComponentModel.Composition;
using EventMapHpViewer.Models;
using EventMapHpViewer.ViewModels;
using Grabacr07.KanColleViewer.Composition;

namespace EventMapHpViewer
{
    [Export(typeof(IPlugin))]
    [Export(typeof(ITool))]
    [ExportMetadata("Guid", "101436F4-9308-4892-A88A-19EFBDF2ED5F")]
    [ExportMetadata("Title", "海域血量查看器")]
    [ExportMetadata("Description", "显示当前海域的血量")]
    [ExportMetadata("Version", "2.3")]
    [ExportMetadata("Author", "@veigr")]
    public class MapHpViewer : IPlugin, ITool
    {
        private readonly ToolViewModel _vm = new ToolViewModel(new MapInfoProxy());

        public void Initialize() {}

        public string Name => "海域血量";

        public object View => new ToolView { DataContext = this._vm };
    }
}
