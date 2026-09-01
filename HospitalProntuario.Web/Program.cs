using HospitalProntuario.Domain.Domain;
using HospitalProntuario.Domain.Domain.Repositories.Interface;
using HospitalProntuario.Domain.Domain.Service.Interface;
using HospitalProntuario.Domain.Interfaces;
using HospitalProntuario.Infra.Context;
using HospitalProntuario.Infra.Repositories;
using HospitalProntuario.Infra.Repositories.Interface;
using HospitalProntuario.Infra.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


builder.Services.AddScoped<IAgendamentoRepository, AgendamentoRepository>();
builder.Services.AddScoped<ICirurgiaReposity, CirurgiaReposity>();
builder.Services.AddScoped<IInternacaoRepository, InternacaoRepository>();
builder.Services.AddScoped<IMedicoRepository, MedicoRepository>();
builder.Services.AddScoped<IPacienteRepository, PacienteRepository>();
builder.Services.AddScoped<IPagamentoRepository, PagamentoRepository>();
builder.Services.AddScoped<IPlanoSaudeRepository, PlanoSaudeRepository>();

builder.Services.AddScoped<IPlanoSaudeService, PlanoSaudeService>();
builder.Services.AddScoped<ICirurgiaService, CirurgiaService>();
builder.Services.AddScoped<IAgendamentoService, AgendamentoService>();
builder.Services.AddScoped<IInternacaoService, InternacaoService>();
builder.Services.AddScoped<IMedicoService, MedicoService>();
builder.Services.AddScoped<IPagamentoSerrvice, PagamentoSerrvice>();
builder.Services.AddScoped<IPacienteService, PacienteService>();

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
