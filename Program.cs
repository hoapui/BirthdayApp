var builder = WebApplication.CreateBuilder(args);

// Thêm các dịch vụ cần thiết cho MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Cấu hình pipeline HTTP request
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Thêm fallback cho các route không tìm thấy
app.MapFallbackToController("Index", "Home");

app.Run();
