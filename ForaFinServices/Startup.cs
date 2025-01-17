using ForaFinServices.Bootstrap.Registries;
using System.Reflection;


namespace ForaFinServices
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddOptions();
            services.AddConfigSections(Configuration);
            services.AddLocalServices();
            services.AddHandlers(); 
            services.AddMemoryCache(options =>
            {
                options.TrackStatistics = true;
            });

            services.AddCacheRefreshBehavior();
            
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                       builder => builder
                       .AllowAnyMethod()
                       .AllowAnyHeader()
                       .WithOrigins("http://localhost:5206", "https://localhost:5207")
                      );
            });

            services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();

            services.AddSwaggerGen();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //Configure the HTTP request pipeline.
            if(env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            //app.UseHttpsRedirection();

            app.UseCors(builder => builder
               .AllowAnyHeader()
               .AllowAnyMethod()
               .AllowAnyOrigin()
            );


            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
