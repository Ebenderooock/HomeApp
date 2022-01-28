using HomeApp.Enums.Application;
using HomeApp.Helpers.Themes;
using MudBlazor;

namespace HomeApp.Helpers
{
    public static class ThemeHelper
    {
        public static MudTheme GetTheme(Theme theme)
        {
            if(theme == Theme.Default) return new DefaultTheme();
            else if(theme == Theme.Dark) return new DarkTheme();

            return new DefaultTheme();
        }
    }
}
