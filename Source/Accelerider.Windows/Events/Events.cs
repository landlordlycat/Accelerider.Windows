﻿using System.Collections.Generic;
using Accelerider.Windows.Infrastructure;
using Accelerider.Windows.Infrastructure.Interfaces;

namespace Accelerider.Windows.Events
{
    public class TaskCreatedEvent : EventBase<IReadOnlyCollection<TaskCreatedEventArgs>> { }

    public class DownloadTaskCreatedEvent : TaskCreatedEvent { }

    public class UploadTaskCreatedEvent : TaskCreatedEvent { }

    public class TaskCreatedEventArgs
    {
        public TaskCreatedEventArgs(string ownerName, ITransferTaskToken token)
        {
            OwnerName = ownerName;
            Token = token;
        }

        public string OwnerName { get; }
        public ITransferTaskToken Token { get; }
    }


    public class DownloadTaskTranferedEvent : EventBase<IDiskFile> { }

    public  class DownloadTaskCheckedEvent : EventBase<object> { }

    public class UploadTaskCompletedEvent : EventBase<IDiskFile> { }

    public class CurrentNetDiskUserChangedEvent : EventBase<INetDiskUser> { }


    public class IsLoadingFilesChangedEvent : EventBase<bool> { }

    public class IsLoadingMainWindowEvent : EventBase<bool> { }
}
