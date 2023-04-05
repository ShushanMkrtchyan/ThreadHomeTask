using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class FileDownloader
    {
        public  static void Download(FileUrl fl)
        {
            var client = new WebClient();
            client.DownloadFile(fl.Url,fl.Name);
            Console.WriteLine("Successfully downloaded and saved");
        }

    }
}
