﻿using System.Collections.Generic;
using Accelerider.Windows.Infrastructure.Interfaces;
using Microsoft.Practices.Unity;
using System.Threading.Tasks;

namespace Accelerider.Windows.ViewModels
{
    public class NetDiskShareViewModel : LoadingFilesBaseViewModel<ISharedFile>
    {
        public NetDiskShareViewModel(IUnityContainer container) : base(container)
        {
        }

        protected override async Task<IEnumerable<ISharedFile>> GetFilesAsync()
        {
            return await NetDiskUser.GetSharedFilesAsync();
        }

    }
}
