using CaoCaoGarden.Data;
using Microsoft.AspNetCore.Hosting.StaticWebAssets;
using MudBlazor.Services;


using CaoCao.CoreBusiness.Services;
using CaoCao.CoreBusiness.Services.Interfaces;
//using CaoCao.DataStore.HardCoded;
using CaoCao.DataStore.SQL.Dapper;
using CaoCao.DataStore.SQL.Dapper.Helpers;
using CaoCao.ShoppingCart.LocalStorage;
using CaoCao.StateStore.DI;
using CaoCao.UseCases.AdminPortal.OrderDetailScreen;
using CaoCao.UseCases.AdminPortal.OrderDetailScreen.interfaces;
using CaoCao.UseCases.AdminPortal.OutstandingOrdersScreen;
using CaoCao.UseCases.AdminPortal.ProcessedOrdersScreen;
using CaoCao.UseCases.OrderConfirmationScreen;
using CaoCao.UseCases.PluginInterfaces.DataStore;
using CaoCao.UseCases.PluginInterfaces.StateStore;
using CaoCao.UseCases.PluginInterfaces.UI;
using CaoCao.UseCases.SearchProductScreen;
using CaoCao.UseCases.ShoppingCartScreen;
using CaoCao.UseCases.ShoppingCartScreen.Interfaces;
using CaoCao.UseCases.ViewProductScreen;
using CaoCao.UseCases.ViewProductScreen.Interfaces;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);


//Add services for Auth
builder.Services.AddControllers();
builder.Services.AddAuthentication("CaoCao.CookieAuth")
    .AddCookie("CaoCao.CookieAuth", config =>
    {
        config.Cookie.Name = "CaoCao.CookieAuth";
        config.LoginPath = "/authenticate";
    });

StaticWebAssetsLoader.UseStaticWebAssets(builder.Environment, builder.Configuration);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddMudServices();


builder.Services.AddScoped<IShoppingCart, ShoppingCart>();
builder.Services.AddScoped<IShoppingCartStateStore, ShoppingCartStateStore>();

builder.Services.AddTransient<IDataAccess>(sp => new DataAccess(builder.Configuration.GetConnectionString("Default")));

builder.Services.AddTransient<IProductRepository, ProductRepository>();
builder.Services.AddTransient<IOrderRepository, OrderRepository>();

builder.Services.AddTransient<IOrderService, OrderService>();
builder.Services.AddTransient<IViewProductUseCase, ViewProductUseCase>();
builder.Services.AddTransient<ISearchProductUseCase, SearchProductUseCase>();
builder.Services.AddTransient<IAddProductToCartUseCase, AddProductToCartUseCase>();
builder.Services.AddTransient<IViewShoppingCartUseCase, ViewShoppingCartUseCase>();
builder.Services.AddTransient<IDeleteProductUseCase, DeleteProductUseCase>();
builder.Services.AddTransient<IUpdateQuantityUseCase, UpdateQuantityUseCase>();
builder.Services.AddTransient<IPlaceOrderUseCase, PlaceOrderUseCase>();
builder.Services.AddTransient<IViewOrderConfirmationUseCase, ViewOrderConfirmationUseCase>();


builder.Services.AddTransient<IViewOutstandingOrdersUseCase, ViewOutstandingOrdersUseCase>();
builder.Services.AddTransient<IViewOrderDetailUseCase, ViewOrderDetailUseCase>();
builder.Services.AddTransient<IProcessOrderUseCase, ProcessOrderUseCase>();
builder.Services.AddTransient<IViewProcessedOrdersUseCase, ViewProcessedOrdersUseCase>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();


app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();