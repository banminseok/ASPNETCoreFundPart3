using System;
using System.Collections.Generic;
using System.Linq;
using TalkApp.Model;
using TalkApp.Models;

namespace TalkApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TalkAppDbContext context = new TalkAppDbContext();
            // DB 없으면 생성.
            context.Database.EnsureCreated(); 

            //Insert
            Talk talk = new Talk()
            {
                Name = "꿀꽈배기",
            };
            context.Talks.Add(talk);
            context.Talks.Add(new Talk { Name = "백두산" });
            context.SaveChanges();

            //Select
            List<Talk> talks = context.Talks.ToList();
            Console.WriteLine($"레코드 개수: {talks.Count}");
            foreach (var t in talks)
            {
                Console.WriteLine($"{t.Id}- {t.Name}");
            }
        }
    }
}
