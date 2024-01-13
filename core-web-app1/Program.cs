var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// ADD SESSION SERVICES TO THE PROGRAM
builder.Services.AddSession(options =>
{
	options.IdleTimeout = TimeSpan.FromSeconds(20);
	options.Cookie.HttpOnly = true;
	options.Cookie.IsEssential = true;

});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// ADD THIS ALSO FOR SESSION MANAGEMENT
// THIS UseSession IS A BUILT IN MIDDLEWARE TO BE USED
app.UseSession();


// YOU CAN CUSTOMIZE THE DEFAULT CONTROLLER AND WHERE IT LEADS TO THE "ACTION"
app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Customer}/{action=Index}/{id?}");

app.Run();
