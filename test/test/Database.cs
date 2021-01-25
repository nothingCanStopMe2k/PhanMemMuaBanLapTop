using SQLite;
using System;
using System.Collections.Generic;
using System.Text;


namespace test
{
    public class Database
    {
        string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

        public bool CreateDatabase()
        {
            try
            {
                string duongdan = System.IO.Path.Combine(folder, "laptop.db");
                var connection = new SQLiteConnection(duongdan);
                connection.CreateTable<Laptop>();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Them_Laptop(Laptop lt)
        {
            try
            {
                string duongdan = System.IO.Path.Combine(folder, "laptop.db");
                var connection = new SQLiteConnection(duongdan);
                connection.Insert(lt);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<Laptop> LayThongTinLaptop()
        {
            try
            {
                string duongdan = System.IO.Path.Combine(folder, "laptop.db");
                var connection = new SQLiteConnection(duongdan);
                return connection.Table<Laptop>().ToList();
            }
            catch
            {
                return null;
            }
        }
        public bool Xoa_Laptop(string MALT)
        {
            try
            {
                string duongdan = System.IO.Path.Combine(folder, "laptop.db");
                var connection = new SQLiteConnection(duongdan);
                connection.Delete<Laptop>(MALT);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
