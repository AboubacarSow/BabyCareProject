using BabyCareProject.Infrastructure.Extensions;
using BabyCareProject.Infrastructure.Utilities;
using BabyCareProject.Repositories.Settings;
using Microsoft.Extensions.Options;
using System.Reflection;
using FluentValidation;
using FluentValidation.AspNetCore;

namespace BabyCareProject;
public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.Configure<DataBaseSettings>(builder.Configuration.GetSection(nameof(DataBaseSettings)));
        builder.Services.AddSingleton<IDataBaseSettings>(provider =>
        {
            return provider.GetRequiredService<IOptions<DataBaseSettings>>().Value;
        });
        //AddFluentValidationAutoValidation
        builder.Services.AddFluentValidationAutoValidation()
            .AddFluentValidationClientsideAdapters()
            .AddValidatorsFromAssemblyContaining<AssemblyReference>();
        // Add services to the container.
        builder.Services.AddControllersWithViews();
        builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
        builder.Services.ConfigureServices();
        builder.Services.Configure<EmailSettings>(builder.Configuration.GetSection("EmailSettings"));
        builder.Services.AddTransient<EmailService>();



        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();
        app.MapControllerRoute(
          name: "areas",
          pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
        );
        
        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Client}/{action=Index}/{id?}");

        app.Run();
    }
}
