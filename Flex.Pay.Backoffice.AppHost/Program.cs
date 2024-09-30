var builder = DistributedApplication.CreateBuilder(args);
builder.AddProject<Projects.Flex_Pay_Backoffice_WebApi>("flexpay-backoffice-webapi");
builder.Build().Run();