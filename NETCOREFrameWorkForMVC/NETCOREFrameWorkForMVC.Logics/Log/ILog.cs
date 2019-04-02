using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NETCOREFrameWorkForMVC.Logics.Log
{
    public interface ILog
    {
        void Info(string message);

        Task InfoAsync(string message);

        void Error(Exception e);

        Task ErrorAsync(Exception e);
    }
}
