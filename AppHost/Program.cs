var builder = DistributedApplication.CreateBuilder(args);
builder.AddProject<Projects.WebApi>("flexpay-backoffice-webapi");
builder.Build().Run();