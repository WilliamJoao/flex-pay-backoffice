var builder = DistributedApplication.CreateBuilder(args);

var postgres =
    builder.AddPostgres("mainpostgres").WithPgAdmin();

var postgresDB
    = postgres.AddDatabase("postgres");

var cache
    = builder.AddRedis("cache").WithRedisCommander();

builder.AddProject<Projects.Flex_Pay_Backoffice_WebApi>("flexpay-backoffice-webapi")
    .WithReference(cache);
builder.AddProject<Projects.Flex_Pay_Backoffice_Worker>("flexpay-backoffice-worker")
    .WithReference(cache);

builder.Build().Run();