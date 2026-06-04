namespace WinDock11.Models;

public class DockItem
{
	public string Name { get; set; }

	public string Path { get; set; }

	public string Icon { get; set; }

	public bool IsRunning { get; set; }

	public bool IsPinned { get; set; }
}
