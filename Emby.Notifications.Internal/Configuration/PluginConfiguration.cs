using MediaBrowser.Model.Plugins;
using System;

namespace Emby.Notifications.Internal.Configuration
{
    public class PluginConfiguration : BasePluginConfiguration
    {
        public INotificationOptions[] Options { get; set; }

        public PluginConfiguration()
        {
            Options = new INotificationOptions[] { };
        }
    }

    public class INotificationOptions
    {
        public Boolean Enabled { get; set; }
        public String MediaBrowserUserId { get; set; }
    }
}
