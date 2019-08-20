using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalRDemo
{
    public class ServerHub : Hub
    {
        /// <summary>
        /// 供客户端调用的服务器端代码
        /// </summary>
        /// <param name="message">客户端传来的消息</param>
        public void Send(string message)
        {
            // 向所有客户端发送消息
            Clients.All.sendMessage(message);
        }
    }
}