using ConsoleApp7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

DownloadManager dm = new DownloadManager();

foreach(var item in dm.urls)
{
    FileDownloader fd = new FileDownloader();

      Thread thread = new Thread(()=> FileDownloader.Download(item));
      thread.Start();

    Console.WriteLine($"{item.Name} will be downloaded shortly");
}


