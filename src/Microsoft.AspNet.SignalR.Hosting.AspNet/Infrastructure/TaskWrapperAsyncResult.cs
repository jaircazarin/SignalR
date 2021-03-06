﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.md in the project root for license information.

using System;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNet.SignalR
{
    internal sealed class TaskWrapperAsyncResult : IAsyncResult
    {
        internal TaskWrapperAsyncResult(Task task, object asyncState)
        {
            Task = task;
            AsyncState = asyncState;
        }

        public object AsyncState
        {
            get;
            private set;
        }

        public WaitHandle AsyncWaitHandle
        {
            get { return ((IAsyncResult)Task).AsyncWaitHandle; }
        }

        public bool CompletedSynchronously
        {
            get { return ((IAsyncResult)Task).CompletedSynchronously; }
        }

        public bool IsCompleted
        {
            get { return ((IAsyncResult)Task).IsCompleted; }
        }

        public Task Task
        {
            get;
            private set;
        }
    }
}
