using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            using (UserContext db = new UserContext())
            {

                User user1 = new User { Name = "Tom", Age = 33, Surname="Clancy"};
                User user2 = new User { Name = "Sam", Age = 26, Surname="Jhonson"};

                db.Users.Add(user1);
                db.Users.Add(user2);
                db.SaveChanges();
                Console.WriteLine("Данные успешно сохранены");


                //var query = from b in db.Users
                //            where b.Surname ==""
                //            select b;
                //foreach (User u in db.Users)
                //{
                //    u.Surname = "NoSurname";
                //}

                //db.Users.RemoveRange(db.Users);

                //db.SaveChanges();

                var Users = db.Users;
                
                Console.WriteLine("Список объектов: ");
                foreach(User u in Users)
                { 
                    Console.WriteLine("{0}.{1} - {2} - {3}", u.Id, u.Name, u.Age, u.Surname);
                }
                Console.Read();
            }
        }
    }
}
