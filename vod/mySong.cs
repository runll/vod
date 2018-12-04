using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vod
{
    public class mySong
    {
        public string songPath ;
        public string songName;
        public string singerName;

        public mySong(){
    }
        public mySong(string songName,string singerName) {
            this.songName = songName;
            this.singerName = singerName;
            singerName = "";
        }

    }
}
