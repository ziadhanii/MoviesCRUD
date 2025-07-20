namespace Movies;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
                               ?? throw new InvalidOperationException("No connection string was found");

        builder.Services.AddDbContext<MoviesDbContext>(options =>
            options.UseSqlServer(connectionString));

        builder.Services.AddMvc().AddNToastNotifyToastr(new ToastrOptions()
        {
            ProgressBar = true,
            PositionClass = ToastPositions.TopRight,
            PreventDuplicates = true,
            CloseButton = true
        });

        builder.Services.AddScoped<IMoviesService, MoviesService>();

        builder.Services.AddScoped<IGenresService, GenresService>();

        builder.Services.AddControllersWithViews();

        var app = builder.Build();

        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
        }

        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthentication();

        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Movies}/{action=Index}/{id?}");

        app.Run();
    }
}