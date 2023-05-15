﻿using System.Linq;
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
                        Name = "iPhone X",
                        Company = "Apple",
                        Price = 600
                    },
                    new Phone
                    {
                        Name = "Samsung Galaxy Edge",
                        Company = "Samsung",
                        Price = 550
                    },
                    new Phone
                    {
                        Name = "Pixel 3",
                        Company = "Google",
                        Price = 500
                    }
                );
            }
            if (!context.Users.Any())
            {
                context.Users.Add(
                    new User
                    {
                        Name = "John",
                        NumberTelephone = "8978768765",
                        Sex = false,
                        Role = "NOT_ADMIN"
                    }
                );
            }
            context.SaveChanges();
        }
    }
}
