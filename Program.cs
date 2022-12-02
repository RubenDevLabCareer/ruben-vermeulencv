using BlazorPro.BlazorSize;
using CvBlazor;
using CvBlazor.Repositories;
using CvBlazor.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

public class Program
{
    static async Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);
        builder.RootComponents.Add<App>("#app");
        builder.RootComponents.Add<HeadOutlet>("head::after");

        builder.Services
            .AddAutoMapper(typeof(Program))
            .AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) })
            .AddMediaQueryService()
            .AddResizeListener()

            .AddScoped<IMainProfileRepository, MainProfileRepository>()
            .AddScoped<ITimelineNodeRepository, TimelineNodeRepository>()
            .AddScoped<IContactInfoRepository, ContactInfoRepository>()
            .AddScoped<IProjectRepository, ProjectRepository>()

            .AddScoped<IMainProfileService, MainProfileService>()
            .AddScoped<ITimelineNodeService, TimelineNodeService>()
            .AddScoped<IContactInfoService, ContactInfoService>()
            .AddScoped<IProjectService, ProjectService>();

        await builder.Build().RunAsync();
    }
}
