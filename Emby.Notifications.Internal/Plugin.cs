using Emby.Notifications.Internal.Configuration;
using MediaBrowser.Common.Configuration;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Model.Drawing;
using MediaBrowser.Model.Plugins;
using MediaBrowser.Model.Serialization;
using System;
using System.Collections.Generic;
using System.IO;

namespace Emby.Notifications.Internal
{
    public class Plugin : BasePlugin<PluginConfiguration>, IHasWebPages, IHasThumbImage
    {
        public Plugin(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer) : base(applicationPaths, xmlSerializer)
        {
            Instance = this;
        }

        public IEnumerable<PluginPageInfo> GetPages()
        {
            return new[]
            {
                new PluginPageInfo
                {
                    Name = Name,
                    EmbeddedResourcePath = GetType().Namespace + ".Configuration.config.html"
                }
            };
        }

        private Guid _id = new Guid("CFE91E5B-6229-42BB-9DFC-87A4ADA933DF");

        public override string Name => "Internal Notifications";
        public override string Description => "Sends notifications to any active session that supports instant messaging";
        public override Guid Id => _id;

        public Stream GetThumbImage()
        {
            Type type = GetType();
            return type.Assembly.GetManifestResourceStream(type.Name + ".thumb.jpg");
        }

        public ImageFormat ThumbImageFormat => ImageFormat.Jpg; 

        public static Plugin Instance { get; set; }
    }
}
