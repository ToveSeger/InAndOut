using InAndOut.Controllers;
using InAndOut.Data;
using InAndOut.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();

            using (ApplicationDBContext context = new ApplicationDBContext())
            {
                Item skateBoard = new Item()
                {
                    ItemName="Skateboard",
                    Borrower = "Tove",
                    Lender= "Per"
                };
                context.Items.Add(skateBoard);
                context.SaveChanges();
            }

        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });



    }
}
