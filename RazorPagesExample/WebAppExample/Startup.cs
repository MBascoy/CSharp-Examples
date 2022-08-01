namespace WebAppExample
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
        }

        public void Configure( IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseHsts();
            }
            app.UseRouting();
            app.UseHttpsRedirection();

            app.UseDefaultFiles(); //Permite asociar archivos por defecto (como index.html o default.html) al endpoint "/"
            app.UseStaticFiles(); //Permite servir archivos estáticos

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapGet("/hola", () => "Hello World");
            });
        }
    }
}
