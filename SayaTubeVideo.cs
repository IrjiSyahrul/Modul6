using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302220088
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Random random = new Random();
            id = random.Next(10000,99999);
            this.playCount = 0;
            this.title = title;
        }

        public void IncreasePlaycount(int a)
        {
           playCount += a;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID: {0}", id);
            Console.WriteLine("Title: {0}", title);
            Console.WriteLine("Playcount: {0}", playCount);
        }

        public int getPlaycount(){
            return playCount;
        }

        public string getTitle() { 
         return title;
        }
    }
}
