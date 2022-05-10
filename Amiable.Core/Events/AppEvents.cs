using Amiable.Core.Service;
using Amiable.SDK.Enum;
using Amiable.SDK.EventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amiable.Core.Events
{
    public static class AppEvents
    {
        /// <summary>
        /// QQ掉线
        /// </summary>
        /// <returns></returns>
        public static int Event_DropLine(long time, long self_id, string sub_type, int msg_id, long user_id, string message, int font, object sender_info)
        {
            AmiableAppEventArgs eventArgs = new AmiableAppEventArgs
            {
                EventType = EventType.APPPLUGIN,
                AppType = AppEventType.DropLine,
                UserId = user_id,
                RawMessage=message
            };
            return Event_DropLine(eventArgs);

        }

        public static int Event_DropLine(AmiableAppEventArgs eventArgs)
        {
            AmiableEventType amiableEventType = AmiableEventType.DropLine;
            EventCore.InvokeEvents(amiableEventType, eventArgs);
            return (int)eventArgs.HandleResult;
        }

        public static int Event_ForceOffline(long time, long self_id, string sub_type, int msg_id, long user_id, string message, int font, object sender_info)
        {
            AmiableAppEventArgs eventArgs = new AmiableAppEventArgs
            {
                EventType = EventType.APPPLUGIN,
                AppType = AppEventType.ForceOffline,
                UserId = user_id,
                RawMessage = message
            };
            return Event_ForceOffline(eventArgs);
        }

        public static int Event_ForceOffline(AmiableAppEventArgs e)
        {
            AmiableEventType amiableEventType = AmiableEventType.ForceOffline;
            EventCore.InvokeEvents(amiableEventType, e);
            return (int)e.HandleResult;
        }

        public static int Event_QQLogin(long time, long self_id, string sub_type, int msg_id, long user_id, string message, int font, object sender_info)
        {
            AmiableAppEventArgs eventArgs = new AmiableAppEventArgs
            {
                EventType = EventType.APPPLUGIN,
                AppType = AppEventType.QQLogin,
                UserId = user_id,
                RawMessage = message
            };
            return Event_QQLogin(eventArgs);
        }

        public static int Event_QQLogin(AmiableAppEventArgs e)
        {
            AmiableEventType amiableEventType = AmiableEventType.QQLogin;
            EventCore.InvokeEvents(amiableEventType, e);
            return (int)e.HandleResult;
        }

        public static int Event_ManualOffline(long time, long self_id, string sub_type, int msg_id, long user_id, string message, int font, object sender_info)
        {
            AmiableAppEventArgs eventArgs = new AmiableAppEventArgs
            {
                EventType = EventType.APPPLUGIN,
                AppType = AppEventType.ManualOffline,
                UserId = user_id,
                RawMessage = message
            };
            return Event_ManualOffline(eventArgs);
        }

        public static int Event_ManualOffline(AmiableAppEventArgs e)
        {
            AmiableEventType amiableEventType = AmiableEventType.ManualOffline;
            EventCore.InvokeEvents(amiableEventType, e);
            return (int)e.HandleResult;
        }

    }
}
