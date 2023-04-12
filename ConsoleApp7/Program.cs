using ConsoleApp7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

DownloadManager dm = new DownloadManager();
Thread[] threads = new Thread[dm.urls.Count];

   foreach(var item in dm.urls)

{
    int i = 0;
    threads[i] = new Thread(()=> FileDownloader.Download(item));

    threads[i].Start();
    i++;

    Console.WriteLine($"{item.Name} will be downloaded shortly");
}

   


