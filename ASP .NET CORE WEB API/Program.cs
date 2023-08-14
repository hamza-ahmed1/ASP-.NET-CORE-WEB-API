var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

#region Intro to ASP.NET CORE WEB APi
/*
 * API stands for application programming interface 
 * HTTP protocols utilize that api
 * by considering web api concept our application will able to run different platform like,desktop,web,mobile etc
 * web api is set of end points url that allow different application to communicate with each other
 * we can build web api using different technologies like python,.net core,jave
 * In .net microsoft has created a framework for creating web api called asp.net core web api
 * 
 * RESTFUL  ARCHITECHTURE 
 * Representational state transfer :
 * it uses get,post,put,delete method to deal with URL uniform resources locators
 * In rest architechture rest server provides the resources and rest client access that
 * here each resources identified by global id / url's resources could be any info
 * info represent by json ,,,
 */
#endregion
