using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class DownloadManager
    {

       public List<FileUrl> urls = new List<FileUrl>
    {
        new FileUrl{Url = "https://www.naturephotographie.com/wp-content/uploads/2019/02/Rays-of-Light-on-the-Summit.jpg", Name = "Rays-of-Light-on-the-Summit.jpg"},
        new FileUrl{Url = "https://th.bing.com/th/id/R.d09a343f43e03a1cdcecea20ef5d6300?rik=MImk4ahnoD58Wg&riu=http%3a%2f%2fcdn.onlyinyourstate.com%2fwp-content%2fuploads%2f2016%2f02%2fGrinnell-Lake-overlook-14510897257.jpg&ehk=7vdGjvQu4vlvIcew5BQojJnz5pz1MenKU6DhYcC6ovI%3d&risl=&pid=ImgRaw&r=0",Name = "Grinnell-Lake-overlook-14510897257.jpg"}
    };

    }
}
