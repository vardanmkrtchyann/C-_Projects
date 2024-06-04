using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class EBook : Book
    {
        public string DownloadLink { get; set; }
        public EBook(string title, string author, string ISBN, string downloadLink) : base(title, author, ISBN)
        {
            DownloadLink = downloadLink;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Download link: {DownloadLink}");
        }
    }
}
