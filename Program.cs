using System;
using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace WebApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
              .UseKestrel()
              .UseUrls("http://*:5000/")
              .UseStartup<Startup>()
              .Build();
            
            host.Run();
        }
    }
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {            
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync(
                    "<html><body><h1>Hello Lucasnet.org!</h1><p><br><h2 style=color:blue><b>The Time is: " + 
                    DateTime.Now.ToString("hh:mm:ss tt") +
                    "</b></h2></p></body></html>"
                    );
                                                               
            });
        }
    }
}
