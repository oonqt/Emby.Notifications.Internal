using Emby.Notifications.Internal.Configuration;
using MediaBrowser.Controller.Session;
using MediaBrowser.Model.Logging;
using MediaBrowser.Model.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Emby.Notifications.Internal.Api
{
    [Route("/Notification/Internal/Test/{UserID}", "POST", Summary = "Tests Notification")]
    public class TestNotification : IReturnVoid
    {
        [ApiMember(Name = "UserID", Description = "User Id", IsRequired = true, DataType = "string", ParameterType = "path", Verb = "GET")]
        public string UserID { get; set; }
    }

    class ServerApiEndpoints : IService
    {
        private readonly ILogger _logger;
        private readonly ISessionManager _sessionManager;

        public ServerApiEndpoints(ILogManager logManager, ISessionManager sessionManager)
        {
            _logger = logManager.GetLogger(GetType().Name);
            _sessionManager = sessionManager;
        }

        private INotificationOptions GetOptions(String userID)
        {
            return Plugin.Instance.Configuration.Options
                    .FirstOrDefault()
        }
    }
}
