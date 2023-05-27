using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

namespace backend.Infrastructure.Services;
public class ExportService : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
        string exportDirectory = Path.Combine(sCurrentDirectory, $@"..\..\..\..\..\lib\ExportFiles");

        while (!stoppingToken.IsCancellationRequested)
        {
            DirectoryInfo di = new DirectoryInfo(exportDirectory);
            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            await Task.Delay(86400000, stoppingToken);
        }


    }
}
