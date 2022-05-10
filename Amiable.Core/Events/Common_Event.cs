using Amiable.Core.Events;
using Amiable.Core.Service;
using Amiable.SDK.DefaultComponent;
using System;
using System.IO;
using System.Windows.Forms;

namespace Amiable.Core
{
    public static class CommonEvents
    {
        public static int XX_Event(string robotQQ, int eventType, int extraType, string from, string fromQQ, string targetQQ, string content, string index, string msgid, string udpmsg, string unix, long p)
        {

            try
            {
                switch (eventType)
                {
                    case (int)DefaultEventConverter.CommonEventType.Friend://私聊消息
                        return MessageEvents.Event_PrivateMessage(DateTime.Now.Ticks, long.Parse(robotQQ), "friend", int.Parse(msgid), long.Parse(fromQQ), content, 0, null);
                    case (int)DefaultEventConverter.CommonEventType.Group://群聊消息
                        return MessageEvents.Event_GroupMessage(DateTime.Now.Ticks, long.Parse(robotQQ), "normal", int.Parse(msgid), long.Parse(from), long.Parse(fromQQ), content, 0, null);
                    case (int)DefaultEventConverter.CommonEventType.OnlineTmp:  //在线临时会话
                        return MessageEvents.Event_TempMessage(DateTime.Now.Ticks, long.Parse(robotQQ), "temp", int.Parse(msgid), long.Parse(fromQQ), content, 0, null);
                    case (int)DefaultEventConverter.CommonEventType.BanRemoveGroup:  //被移出群
                        return AdminGroupEvents.Event_BanRemoveGroup(DateTime.Now.Ticks, long.Parse(robotQQ), "normal", int.Parse(msgid), long.Parse(from), long.Parse(fromQQ),long.Parse(targetQQ), content, 0, null);
                    case (int)DefaultEventConverter.CommonEventType.BeRemovedFriend:  //被删除好友
                        return RequestEvents.Event_BeRemovedFriend(DateTime.Now.Ticks, long.Parse(robotQQ), "addreply", int.Parse(msgid), long.Parse(fromQQ), content, 0, null);
                    case (int)DefaultEventConverter.CommonEventType.DropLine://QQ掉线
                        return AppEvents.Event_DropLine(DateTime.Now.Ticks, long.Parse(robotQQ), "friend", int.Parse(msgid), long.Parse(fromQQ), content, 0, null);
                    case (int)DefaultEventConverter.CommonEventType.ForceOffline: //强制离线
                        return AppEvents.Event_ForceOffline(DateTime.Now.Ticks, long.Parse(robotQQ), "friend", int.Parse(msgid), long.Parse(fromQQ), content, 0, null);
                    case (int)DefaultEventConverter.CommonEventType.GroupNameChange:  //群名称变动
                        return AdminGroupEvents.Event_GroupNameChange(DateTime.Now.Ticks, long.Parse(robotQQ), "normal", int.Parse(msgid), long.Parse(from), long.Parse(fromQQ), long.Parse(targetQQ), content, 0, null);
                    case (int)DefaultEventConverter.CommonEventType.GroupNickChange://群昵称
                        return AdminGroupEvents.Event_GroupNickChange(DateTime.Now.Ticks, long.Parse(robotQQ), "normal", int.Parse(msgid), long.Parse(from), long.Parse(fromQQ), long.Parse(targetQQ), content, 0, null);
                    case (int)DefaultEventConverter.CommonEventType.GroupTmp://群私聊
                        return MessageEvents.Event_GroupTempMessage(DateTime.Now.Ticks, long.Parse(robotQQ), "normal", int.Parse(msgid), long.Parse(from), long.Parse(fromQQ), content, 0, null);
                    case (int)DefaultEventConverter.CommonEventType.InvitationedGroup://已被邀请进群
                        return AdminGroupEvents.Event_InvitationedGroup(DateTime.Now.Ticks, long.Parse(robotQQ), "normal", int.Parse(msgid), long.Parse(from), long.Parse(fromQQ), long.Parse(targetQQ), content, 0, null);
                    case (int)DefaultEventConverter.CommonEventType.InvitationGroup://邀请加群
                        return AdminGroupEvents.Event_InvitationGroup(DateTime.Now.Ticks, long.Parse(robotQQ), "normal", int.Parse(msgid), long.Parse(from), long.Parse(fromQQ), long.Parse(targetQQ), content, 0, null);
                    case (int)DefaultEventConverter.CommonEventType.ManualOffline://手动离线
                        return AppEvents.Event_ManualOffline(DateTime.Now.Ticks, long.Parse(robotQQ), "friend", int.Parse(msgid), long.Parse(fromQQ), content, 0, null);
                    case (int)DefaultEventConverter.CommonEventType.QQLogin:  //QQ登录完成
                        return AppEvents.Event_QQLogin(DateTime.Now.Ticks, long.Parse(robotQQ), "friend", int.Parse(msgid), long.Parse(fromQQ), content, 0, null);
                    case (int)DefaultEventConverter.CommonEventType.RemoveGroup://退出群
                        return AdminGroupEvents.Event_RemoveGroup(DateTime.Now.Ticks, long.Parse(robotQQ), "normal", int.Parse(msgid), long.Parse(from), long.Parse(fromQQ), long.Parse(targetQQ), content, 0, null);
                    case (int)DefaultEventConverter.CommonEventType.SomeoneWantAddFriend://被请求添加好友
                        return RequestEvents.Event_SomeoneWantAddFriend(DateTime.Now.Ticks, long.Parse(robotQQ), "addreply", int.Parse(msgid), long.Parse(fromQQ), content, 0, null);
                    case (int)DefaultEventConverter.CommonEventType.WantAddGroup://申请加群
                        return AdminGroupEvents.Event_WantAddGroup(DateTime.Now.Ticks, long.Parse(robotQQ), "normal", int.Parse(msgid), long.Parse(from), long.Parse(fromQQ), long.Parse(targetQQ), content, 0, null);
                    case (int)DefaultEventConverter.CommonEventType.PluginEnable:  //插件被启用
                        PluginEvents.Event_PluginEnable(EventCore.GetAmiableEventArgs(DateTime.Now.Ticks, 0, SDK.Enum.EventType.META_EVENT));
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                AmiableService.App.Log($"[XXEvent错误]\n来源:{ex.Source}\n问题:{ex.Message}\nStack{ex.StackTrace}");
            }
            return 0;
        }
    }
}
