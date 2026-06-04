using System.Collections.ObjectModel;
using WinDock11.Models;

namespace WinDock11.ViewModels;

public class MainViewModel
{
    public ObservableCollection<DockItem> DockItems { get; } = new();

    public MainViewModel()
    {
        DockItems.Add(new DockItem
        {
            Name = "Chrome",
            Path = @"C:\Program Files\Google\Chrome\Application\chrome.exe",
            IsPinned = true
        });

        DockItems.Add(new DockItem
        {
            Name = "Explorer",
            Path = "explorer.exe",
            IsPinned = true
        });

        DockItems.Add(new DockItem
        {
            Name = "Notepad",
            Path = "notepad.exe",
            IsPinned = true
        });
    }
}
