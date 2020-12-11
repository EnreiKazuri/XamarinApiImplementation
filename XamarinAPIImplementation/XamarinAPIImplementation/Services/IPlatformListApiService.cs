using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamarinAPIImplementation.Models;

namespace XamarinAPIImplementation.Services
{
    public interface IPlatformListApiService
    {
        Task<Result> GetPlatform();
    }
}
