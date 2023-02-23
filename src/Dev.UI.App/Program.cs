namespace Dev.UI.App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Tudo inicia a partir do builder
            var builder = WebApplication.CreateBuilder(args);

            // Adicionando o MVC ao container
            builder.Services.AddControllersWithViews();

            // Realizando o buid das configurações que resultará na App
            var app = builder.Build();

            // Ativando a pagina de erros caso seja ambiente de desenvolvimento
            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            // Adicionando Rota padrão
            app.MapControllerRoute(
                name: "areas",
                pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");



            // Colocando a App para rodar
            app.Run();
        }
    }
}