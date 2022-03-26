using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302204068
{
    internal class SayaTubeUser
    {
        int id;
        List<SayaTubeVideo> uploadedVideo;
        string Username;

        public SayaTubeUser(string profile)
        {
            this.Username = profile;
            Random generate = new Random();
            this.id = generate.Next(0, 100000);
            uploadedVideo = new List<SayaTubeVideo>();

        }

        public void GetTotalVideoplayCount()
        {
            int dataplayCount = 0;
            foreach (SayaTubeVideo video in uploadedVideo)
            {
                dataplayCount = dataplayCount + video.GetPlaycount();
            }
        }

        public void addVideo(SayaTubeVideo data)
        {
            uploadedVideo.Add(data);
        }


        public void printAllvideoplayCount()
        {

            for (int i = 0; i < uploadedVideo.Count; i++)
            {
                Console.WriteLine("username:" + Username);
                Console.WriteLine("video:" + (i + 1) + ":" + uploadedVideo[i]);
            }

        }
    }
}

