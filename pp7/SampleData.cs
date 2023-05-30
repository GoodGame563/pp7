using System.Linq;
using WebApplication2rrr.Models;

namespace WebApplication2rrr
{
    public class SampleData
    {
        public static void Initialize(MobileContext context, IWebHostEnvironment env)
        {
            if (!context.Phones.Any())
            {
                context.Phones.AddRange(
                    new Phone
                    {
                        Name = "Смартфон Apple iPhone 14 256Gb, A2884, сияющая звезда",
                        Company = "Apple",
                        Price = 92290,
                        Url = "https://static.eldorado.ru/photos/mv/Big/400038702bb.jpg/resize/400x300/"
                    },
                    new Phone
                    {
                        Name = "Смартфон realme C33",
                        Company = "Realme",
                        Price = 8550,
                        Url = "https://avatars.mds.yandex.net/get-mpic/5313128/img_id5566970020051312336.png/orig"
                    },
                    new Phone
                    {
                        Name = "Cмартфон Xiaomi POCO X5 5G 6/128 ГБ RU",
                        Company = "Xiaomi",
                        Price = 19290,
                        Url = "https://avatars.mds.yandex.net/get-mpic/331398/img_id5306221544950390629.png/orig"
                    }
                );
                context.SaveChanges();
            }
            /*
            if (!context.Users.Any())
            {
                context.Users.Add(new User
                {
                    Name = "Artem",
                    NumberTelephone = "8800553535",
                    Role = "not an admin",
                    Sex = false
                }) ;
                context.SaveChanges();
            }
            */
        }
    }
}
