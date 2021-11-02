using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SiteTeste.Data;


namespace SiteTeste
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //repita a linha do sqlConnection trocando "DefaultConnection" pelo "SeuNomeConnecton" l� de appsettings.json. Isso vai fazer a conex�o do c�digo com o seu servidor e o banco de dados
            //na sua m�quina, comente todos os outros sqlConnection (o atalho � ctrl K C) e deixe somente o seu n�o comentado pra poder fazer a conex�o. Se n�o fizer isso, vai dar erro por n�o encontrar as outras conex�es

            //string sqlConnection = Configuration.GetconnectionString("DefaultConnection");
            //string sqlConnection = Configuration.GetConnectionString("DaniellaConnection");
            //string sqlConnection = Configuration.GetConnectionString("PatrickConnection");
            string sqlConnection = Configuration.GetConnectionString("BarbaraConnection");
            //string sqlConnection = Configuration.GetConnectionString("LucianoConnection");
            //string sqlConnection = Configuration.GetConnectionString("ThiagoConnection");

            services.AddDbContextPool<AppDbContext>(options => options.UseSqlServer(sqlConnection));

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
