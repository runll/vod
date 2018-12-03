using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vod
{
    class imagePathList
    {
        
        public List<string> res = new List<string>();
        public imagePathList() {

            this.res = new mySql("select Siimage from singers").res;
        }
    }
}
