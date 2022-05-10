using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amiable.SDK.Enum
{
    public enum AmiableEventType
    {
        /// <summary>
        /// 无法被解析(暂不支持的事件)
        /// </summary>
        Error,

        /// <summary>
        /// 私聊事件
        /// </summary>
        Private,
        /// <summary>
        /// 在线临时会话
        /// </summary>
        OnlineTmp,

        /// <summary>
        /// 群消息事件
        /// </summary>
        Group,

        /// <summary>
        /// 增加好友请求
        /// </summary>
        AddFriend,
        /// <summary>
        /// 单向添加好友事件
        /// </summary>
        AddFriendOne,
        /// <summary>
        /// 好友验证对话消息
        /// </summary>
        AddFriendReply,
        /// <summary>
        /// 被移出群
        /// </summary>
        BanRemoveGroup,
        /// <summary>
        /// 删除好友
        /// </summary>
        BeRemovedFriend,
        /// <summary>
        /// 群被解散
        /// </summary>
        Dissolution,
        /// <summary>
        /// QQ掉线
        /// </summary>
        DropLine,
        /// <summary>
        /// 强制离线
        /// </summary>
        ForceOffline,
        /// <summary>
        /// 群名称变动
        /// </summary>
        GroupNameChange,
        /// <summary>
        /// 群昵称被改动
        /// </summary>
        GroupNickChange,
        /// <summary>
        /// 群私聊消息
        /// </summary>
        GroupTempMessage,
        /// <summary>
        /// 好友请求事件
        /// </summary>
        SomeoneWantAddFriend,
        /// <summary>
        /// 群添加请求
        /// </summary>
        WantAddGroup,
        /// <summary>
        /// 已被邀请进群
        /// </summary>
        InvitationedGroup,
        /// <summary>
        /// 邀请进群
        /// </summary>
        InvitationGroup,
        /// <summary>
        /// 手动离线
        /// </summary>
        ManualOffline,
        /// <summary>
        /// QQ登录
        /// </summary>
        QQLogin,
        /// <summary>
        /// 退出群
        /// </summary>
        RemoveGroup,
        /// <summary>
        /// 框架重启
        /// </summary>
        Restart,

        /// <summary>
        /// 添加群请求
        /// </summary>
        AddGroup,

        /// <summary>
        /// 插件被启用
        /// </summary>
        PluginEnable,

        /// <summary>
        /// 插件被载入
        /// </summary>
        PluginLoaded,

        /// <summary>
        /// 唤起菜单事件
        /// </summary>
        PluginMenu,
        /// <summary>
        /// 插件被禁用
        /// </summary>
        PluginDisabled,

        /// <summary>
        /// Amiable被初始化完成
        /// </summary>
        AmiableLoaded
    }
}