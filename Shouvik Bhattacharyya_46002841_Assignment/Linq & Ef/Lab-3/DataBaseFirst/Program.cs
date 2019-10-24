using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            MusicStoreEntities storeEntities = new MusicStoreEntities();
            var album = storeEntities.Albums;

            Album newAlbum = new Album
            {
               
                Name = "Latest hits",
                Genre = "Music hits",
                Year = 2019,
                Price = 115

            };
            storeEntities.Albums.Add(newAlbum);
            storeEntities.SaveChanges();

            Console.WriteLine("Data added Successfully");

            foreach (var item in album)
            {
                Console.WriteLine("{0}\t{1}\t{2}",item.AlbumID,item.Name,item.Price);
            }
            Console.ReadKey();
        }
    }
}
