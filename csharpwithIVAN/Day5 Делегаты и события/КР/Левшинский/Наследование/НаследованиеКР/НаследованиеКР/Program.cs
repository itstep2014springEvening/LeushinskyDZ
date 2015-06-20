using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace НаследованиеКР
{
    class Program
    {
        public class Music
        {
            string AlbumName { get; set; }
            int SongDuration { get; set; }
            public Music(string AlbumName, int songDuration)
            {
                this.AlbumName = AlbumName;
                this.SongDuration = songDuration;
            }
        }
        public class DeathMetalMusic
        {
            public DeathMetalMusic():base(string AlbumName, int songDuration)
            {

            }           
            
        }
        public class DepressiveBlackMusic
        {

        }
        public class BrutalDeathMusic
        {

        }
        static void Main(string[] args)
        {
            DeathMetalMusic ChildrenOfBodom = new DeathMetalMusic("Nechropos", 5);
            for(freespaceindisk)
            {
            disk.write(string AlbumName, int songDuration);
            totalduration+=songDuration;
            }
            

        }
    }
}
