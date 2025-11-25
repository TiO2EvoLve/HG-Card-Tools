using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components.Routing;

namespace Web.Layout;

public partial class MainLayout
{
    private bool UseTabSet { get; set; } = true;

    private string Theme { get; set; } = "";

    private bool IsOpen { get; set; }

    private bool IsFixedHeader { get; set; } = true;

    private bool IsFixedTabHeader { get; set; } = true;

    private bool IsFixedFooter { get; set; } = true;

    private bool IsFullSide { get; set; } = true;

    private bool ShowFooter { get; set; } = true;

    private bool ShowTabInHeader { get; set; } = true;

    private List<MenuItem>? Menus { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    protected override void OnInitialized()
    {
        base.OnInitialized();

        Menus = GetIconSideMenuItems();
    }

    private static List<MenuItem> GetIconSideMenuItems()
    {
        var menus = new List<MenuItem>
        {
            new() { Text = "Index", Icon = "fa-solid fa-fw fa-flag", Url = "/", Match = NavLinkMatch.All },
        };

        return menus;
    }

    private Task OnSideChanged(bool v)
    {
        IsFullSide = v;
        StateHasChanged();
        return Task.CompletedTask;
    }
}
