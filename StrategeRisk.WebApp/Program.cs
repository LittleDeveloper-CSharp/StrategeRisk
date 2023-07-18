using Microsoft.EntityFrameworkCore;
using StrategeRisk.Application.Services;
using StrategeRisk.DataAccess;
using StrategeRisk.DataAccess.Seeders;
using StrategeRisk.Domain.Infrastucture;
using StrategeRisk.Domain.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddMvc();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Configure<RouteOptions>(opts=> opts.LowercaseUrls= true);

builder.Services.AddDbContext<ApplicationDbContext>(
    options => options.UseInMemoryDatabase("StratageRisk"));

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

builder.Services.AddScoped<IEmployeePositionService, EmployeePositionService>();
builder.Services.AddScoped<ICompanyService, CompanyService>();
builder.Services.AddScoped<IHistoryService, HistoryService>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<INoteService, NoteService>();

var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    DbSeeder.Seed(scope).GetAwaiter().GetResult();
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapSwagger();
app.UseSwaggerUI();

app.MapControllerRoute(
    "default", 
    "{controller=Home}/{action=Index}/{id?}");
app.Run();
