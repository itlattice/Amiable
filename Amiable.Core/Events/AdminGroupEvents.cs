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
    /// <summary>
    /// 群管理类事件
    /// </summary>
   public class AdminGroupEvents
    {
        
        public static int Event_BanRemoveGroup(long time, long self_id, string sub_type, int msg_id, long group_id, long user_id,long targetQQ, string message, int font, object sender_info)
        {
            AmiableAdminGroupEventArgs eventArgs = new AmiableAdminGroupEventArgs
            {
                EventType = EventType.GROUPADMIN,
                AdminType = AdminGroupEventType.BanRemoveGroup,
                GroupId= group_id,
                Timestamp = time,
                Robot = self_id,
                BeUserId=targetQQ,
                RawMessage = message,
                MessageId = msg_id,
                UserId = user_id,
            };
            return Event_BanRemoveGroup(eventArgs);
        }

        /// <summary>
        /// 以Onebot标准参数触发私聊事件
        /// </summary>
        /// <param name="eventArgs"></param>
        /// <returns></returns>
        public static int Event_BanRemoveGroup(AmiableAdminGroupEventArgs eventArgs)
        {
            AmiableEventType amiableEventType = AmiableEventType.BanRemoveGroup;

            EventCore.InvokeEvents(amiableEventType, eventArgs);
            return (int)eventArgs.HandleResult;
        }

        public static int Event_WantAddGroup(long time, long self_id, string sub_type, int msg_id, long group_id, long user_id, long targetQQ, string message, int font, object sender_info)
        {
            AmiableAdminGroupEventArgs eventArgs = new AmiableAdminGroupEventArgs
            {
                EventType = EventType.GROUPADMIN,
                AdminType = AdminGroupEventType.WantAddGroup,
                GroupId = group_id,
                Timestamp = time,
                Robot = self_id,
                BeUserId = targetQQ,
                RawMessage = message,
                MessageId = msg_id,
                UserId = user_id,
            };
            return Event_WantAddGroup(eventArgs);
        }

        /// <summary>
        /// 以Onebot标准参数触发私聊事件
        /// </summary>
        /// <param name="eventArgs"></param>
        /// <returns></returns>
        public static int Event_WantAddGroup(AmiableAdminGroupEventArgs eventArgs)
        {
            AmiableEventType amiableEventType = AmiableEventType.WantAddGroup;

            EventCore.InvokeEvents(amiableEventType, eventArgs);
            return (int)eventArgs.HandleResult;
        }

        public static int Event_InvitationGroup(long time, long self_id, string sub_type, int msg_id, long group_id, long user_id, long targetQQ, string message, int font, object sender_info)
        {
            AmiableAdminGroupEventArgs eventArgs = new AmiableAdminGroupEventArgs
            {
                EventType = EventType.GROUPADMIN,
                AdminType = AdminGroupEventType.InvitationGroup,
                GroupId = group_id,
                Timestamp = time,
                Robot = self_id,
                BeUserId = targetQQ,
                RawMessage = message,
                MessageId = msg_id,
                UserId = user_id,
            };
            return Event_InvitationGroup(eventArgs);
        }

        public static int Event_InvitationGroup(AmiableAdminGroupEventArgs eventArgs)
        {
            AmiableEventType amiableEventType = AmiableEventType.InvitationGroup;

            EventCore.InvokeEvents(amiableEventType, eventArgs);
            return (int)eventArgs.HandleResult;
        }

        public static int Event_RemoveGroup(long time, long self_id, string sub_type, int msg_id, long group_id, long user_id, long targetQQ, string message, int font, object sender_info)
        {
            AmiableAdminGroupEventArgs eventArgs = new AmiableAdminGroupEventArgs
            {
                EventType = EventType.GROUPADMIN,
                AdminType = AdminGroupEventType.RemoveGroup,
                GroupId = group_id,
                Timestamp = time,
                Robot = self_id,
                BeUserId = targetQQ,
                RawMessage = message,
                MessageId = msg_id,
                UserId = user_id,
            };
            return Event_RemoveGroup(eventArgs);
        }

        public static int Event_RemoveGroup(AmiableAdminGroupEventArgs eventArgs)
        {
            AmiableEventType amiableEventType = AmiableEventType.RemoveGroup;

            EventCore.InvokeEvents(amiableEventType, eventArgs);
            return (int)eventArgs.HandleResult;
        }

        public static int Event_InvitationedGroup(long time, long self_id, string sub_type, int msg_id, long group_id, long user_id, long targetQQ, string message, int font, object sender_info)
        {
            AmiableAdminGroupEventArgs eventArgs = new AmiableAdminGroupEventArgs
            {
                EventType = EventType.GROUPADMIN,
                AdminType = AdminGroupEventType.InvitationedGroup,
                GroupId = group_id,
                Timestamp = time,
                Robot = self_id,
                BeUserId = targetQQ,
                RawMessage = message,
                MessageId = msg_id,
                UserId = user_id,
            };
            return Event_InvitationedGroup(eventArgs);
        }

        public static int Event_InvitationedGroup(AmiableAdminGroupEventArgs eventArgs)
        {
            AmiableEventType amiableEventType = AmiableEventType.InvitationedGroup;
            EventCore.InvokeEvents(amiableEventType, eventArgs);
            return (int)eventArgs.HandleResult;
        }

        public static int Event_Dissolution(long time, long self_id, string sub_type, int msg_id, long group_id, long user_id, long targetQQ, string message, int font, object sender_info)
        {
            AmiableAdminGroupEventArgs eventArgs = new AmiableAdminGroupEventArgs
            {
                EventType = EventType.GROUPADMIN,
                AdminType = AdminGroupEventType.Dissolution,
                GroupId = group_id,
                Timestamp = time,
                Robot = self_id,
                BeUserId = targetQQ,
                RawMessage = message,
                MessageId = msg_id,
                UserId = user_id,
            };
            return Event_Dissolution(eventArgs);
        }

        public static int Event_Dissolution(AmiableAdminGroupEventArgs eventArgs)
        {
            AmiableEventType amiableEventType = AmiableEventType.Dissolution;
            EventCore.InvokeEvents(amiableEventType, eventArgs);
            return (int)eventArgs.HandleResult;
        }

        public static int Event_GroupNameChange(long time, long self_id, string sub_type, int msg_id, long group_id, long user_id, long targetQQ, string message, int font, object sender_info)
        {
            AmiableAdminGroupEventArgs eventArgs = new AmiableAdminGroupEventArgs
            {
                EventType = EventType.GROUPADMIN,
                AdminType = AdminGroupEventType.GroupNameChange,
                GroupId = group_id,
                Timestamp = time,
                Robot = self_id,
                BeUserId = targetQQ,
                RawMessage = message,
                MessageId = msg_id,
                UserId = user_id,
            };
            return Event_GroupNameChange(eventArgs);
        }

        public static int Event_GroupNameChange(AmiableAdminGroupEventArgs eventArgs)
        {
            AmiableEventType amiableEventType = AmiableEventType.GroupNameChange;
            EventCore.InvokeEvents(amiableEventType, eventArgs);
            return (int)eventArgs.HandleResult;
        }

        public static int Event_GroupNickChange(long time, long self_id, string sub_type, int msg_id, long group_id, long user_id, long targetQQ, string message, int font, object sender_info)
        {
            AmiableAdminGroupEventArgs eventArgs = new AmiableAdminGroupEventArgs
            {
                EventType = EventType.GROUPADMIN,
                AdminType = AdminGroupEventType.GroupNickChange,
                GroupId = group_id,
                Timestamp = time,
                Robot = self_id,
                BeUserId = targetQQ,
                RawMessage = message,
                MessageId = msg_id,
                UserId = user_id,
            };
            return Event_GroupNickChange(eventArgs);
        }

        public static int Event_GroupNickChange(AmiableAdminGroupEventArgs eventArgs)
        {
            AmiableEventType amiableEventType = AmiableEventType.GroupNickChange;
            EventCore.InvokeEvents(amiableEventType, eventArgs);
            return (int)eventArgs.HandleResult;
        }
    }
}
