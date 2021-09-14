using Microsoft.Extensions.Hosting;
using SerwerAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SerwerAPI.Helpers
{
    public class OldRecordsDeleter : IHostedService
    {
        private DataUtils _dataUtils = new DataUtils();
        private Timer _timer;

        public Task StartAsync(CancellationToken stoppingToken)
        {
            _timer = new Timer(DoWork, null, TimeSpan.Zero,
                TimeSpan.FromMinutes(2));

            return Task.CompletedTask;
        }

        private void DoWork(object state)
        {
            Console.WriteLine("xdd");
            _dataUtils.checkOldRecord();
        }

        public Task StopAsync(CancellationToken stoppingToken)
        {
            _timer?.Change(Timeout.Infinite, 0);

            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}
