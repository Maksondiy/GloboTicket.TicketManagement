using GloboTicket.TicketManagement.Api;
using Microsoft.AspNetCore.Hosting;

var builder = WebApplication.CreateBuilder(args);

var app = builder
    .ConfigureServices()
    .ConfigurePipeline();
    
await app.ResetDatabaseAsync();

app.Run();
