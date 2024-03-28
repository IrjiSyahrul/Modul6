using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302220088
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        private string Username;

        public SayaTubeUser(string Username)
        {
            this.Username = Username;
            Random random = new Random();
            id = random.Next(10000,99999);
            uploadedVideos = new List<SayaTubeVideo>();

        }

        public int GetTotalVideoPlaycount()
        {
            int jumlah = 0;
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                jumlah += uploadedVideos[i].getPlaycount();
            }
            return jumlah;
        }

        public void PrintAllVideoPlayCount()
        {
            Console.WriteLine("User: " + Username);
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine("Video " + (i + 1) + " judul : " + uploadedVideos[i].getTitle());
            }
        }

        public void addVideo(SayaTubeVideo video)
        {
            uploadedVideos.Add(video);
        }

        public string GetUsername() {
            return Username;
        }
    }
}
