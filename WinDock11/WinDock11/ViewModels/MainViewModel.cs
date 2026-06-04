using System.Collections.ObjectModel;
using WinDock11.Models;

namespace WinDock11.ViewModels;

public class MainViewModel
{
    public ObservableCollection<DockItem> DockItems { get; } = new();
}
