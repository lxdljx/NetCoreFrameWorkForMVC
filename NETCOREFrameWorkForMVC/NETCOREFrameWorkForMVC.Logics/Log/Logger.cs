using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NETCOREFrameWorkForMVC.Logics.Log
{
    public class Logger : ILog
    {
        public void Error(Exception e)
        {
            Console.WriteLine($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffffff")}发生异常，消息为：{e.GetBaseException().Message},\r\n 堆栈信息为：{e.StackTrace}");
        }

        public Task ErrorAsync(Exception e)
        {
            return Task.Run(() => {
                Console.WriteLine($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffffff")}发生异常，消息为：{e.GetBaseException().Message},\r\n 堆栈信息为：{e.StackTrace}");
            });
        }

        public void Info(string message)
        {
            Console.WriteLine($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffffff")}系统消息：{message}");
        }

        public Task InfoAsync(string message)
        {
            return Task.Run(() => { Console.WriteLine($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffffff")}系统消息：{message}"); });
        }
    }
}
