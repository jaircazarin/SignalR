﻿using System;
using System.Threading.Tasks;
using System.Web;
using SignalR.Hubs;


namespace SignalR.Samples.Hubs.Auth
{
    public class NoAuthHub : Hub
    {
        public override Task Disconnect()
        {
            return Clients.All.left(Context.ConnectionId, DateTime.Now.ToString());
        }

        public override Task Connect()
        {
            return Clients.All.joined(Context.ConnectionId, DateTime.Now.ToString(), AuthInfo());
        }

        public override Task Reconnect()
        {
            return Clients.All.rejoined(Context.ConnectionId, DateTime.Now.ToString());
        }

        public void InvokedFromClient()
        {
            Clients.All.invoked(Context.ConnectionId, DateTime.Now.ToString());
        }

        protected object AuthInfo()
        {
            var user = Context.User;
            return new
            {
                IsAuthenticated = user.Identity.IsAuthenticated,
                IsAdmin = user.IsInRole("Admin"),
                UserName = HttpUtility.HtmlEncode(user.Identity.Name)
            };
        }
    }
}