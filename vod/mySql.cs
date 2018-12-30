using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vod
{
    class mySql
    {
        public List<string> res = new List<string>();

       
        public mySql() {
        }

        public mySql(string select, string tableName){
            
            MySqlConnection con = new MySqlConnection("server=localhost;User Id=root;password=123456;Database=vod");
            con.Open();
            //to do :
            //连接查询 由singers表中找出singerName(Siname)对应的Sino,再在songs表中找出Sino对应的Soname和Sopath
            //返回数据为  Soname + singerName + Sopath（隐式）

            MySqlCommand mysqlcmd_Query = new MySqlCommand("select "+select+"from "+tableName, con);
            MySqlDataReader dataReader = mysqlcmd_Query.ExecuteReader();
            int count = dataReader.FieldCount;
            dataReader.Read();
            while (dataReader.Read())
            {
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    if (!dataReader.IsDBNull(i))
                    {

                        //Console.WriteLine(dataReader.GetString(i).ToString());
                        res.Add(dataReader.GetString(i).ToString());
                    }
                    else
                    {
                        Console.WriteLine("查询结果的当前当的第{0}列为空", i);
                    }

                }
            }
            if (!dataReader.IsClosed)
            {
                dataReader.Close();
            }
            con.Close();
        }
        public mySql(string select,string tableName,string where) {
            MySqlConnection con = new MySqlConnection("server=localhost;User Id=root;password=123456;Database=vod");
            con.Open();
            //to do :
            //连接查询 由singers表中找出singerName(Siname)对应的Sino,再在songs表中找出Sino对应的Soname和Sopath
            //返回数据为  Soname + singerName + Sopath（隐式）

            MySqlCommand mysqlcmd_Query = new MySqlCommand("select " + select + "from " + tableName+"where "+where, con);
            MySqlDataReader dataReader = mysqlcmd_Query.ExecuteReader();
            int count = dataReader.FieldCount;
            dataReader.Read();
            while (dataReader.Read())
            {
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    if (!dataReader.IsDBNull(i))
                    {

                        //Console.WriteLine(dataReader.GetString(i).ToString());
                        res.Add(dataReader.GetString(i).ToString());
                    }
                    else
                    {
                        Console.WriteLine("查询结果的当前当的第{0}列为空", i);
                    }

                }
            }
            if (!dataReader.IsClosed)
            {
                dataReader.Close();
            }
            con.Close();
        }
    
    public mySql(string s)
    {
        MySqlConnection con = new MySqlConnection("server=localhost;User Id=root;password=123456;Database=vod");
        con.Open();
        //to do :
        //连接查询 由singers表中找出singerName(Siname)对应的Sino,再在songs表中找出Sino对应的Soname和Sopath
        //返回数据为  Soname + singerName + Sopath（隐式）

        MySqlCommand mysqlcmd_Query = new MySqlCommand(s, con);
        MySqlDataReader dataReader = mysqlcmd_Query.ExecuteReader();
            
        int count = dataReader.FieldCount;
        //dataReader.Read();
        while (dataReader.Read())
        {
            for (int i = 0; i < dataReader.FieldCount; i++)
            {
                if (!dataReader.IsDBNull(i))
                {

                    //Console.WriteLine(dataReader.GetString(i).ToString());
                    res.Add(dataReader.GetString(i).ToString());
                }
                else
                {
                    Console.WriteLine("查询结果的当前当的第{0}列为空", i);
                }

            }
        }
        if (!dataReader.IsClosed)
        {
            dataReader.Close();
        }
        con.Close();
    
    }
}
}
