﻿using Microsoft.AspNet.SignalR.FunctionalTests.Core.Hubs;
using Microsoft.AspNet.SignalR.Hubs;
using Xunit;

namespace Microsoft.AspNet.SignalR.FunctionalTests.Core
{
    public class HubTypeExtensions
    {
        [Fact]
        public void GetHubNameWithAttributeGetsAttribute()
        {
            var hubName = typeof(CoreTestHubWithAttribute).GetHubName();

            Assert.Equal(hubName, "HubWithAttribute");
        }

        [Fact]
        public void GetHubNameNoAttributeGetsClassName()
        {
            var hubName = typeof(CoreTestHub).GetHubName();

            Assert.Equal(hubName, "CoreTestHub");
        }

        [Fact]
        public void GetHubNameThatIsNotHubReturnsNull()
        {
            var hubName = typeof(NotAHub).GetHubName();

            Assert.Null(hubName);
        }

        [Fact]
        public void GetHubAttributeNameWithAttributeGetsAttribute()
        {
            var hubName = typeof(CoreTestHubWithAttribute).GetHubAttributeName();

            Assert.Equal(hubName, "HubWithAttribute");
        }

        [Fact]
        public void GetHubAttributeNameNoAttributeReturnsNull()
        {
            var hubName = typeof(CoreTestHub).GetHubAttributeName();

            Assert.Null(hubName);
        }

        [Fact]
        public void GetHubAttributeNameThatIsNotHubReturnsNull()
        {
            var hubName = typeof(NotAHub).GetHubAttributeName();

            Assert.Null(hubName);
        }
    }
}
