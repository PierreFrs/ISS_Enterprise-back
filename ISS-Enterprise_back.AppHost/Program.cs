var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.ISS_Enterprise_back>("iss-enterprise-back");

builder.Build().Run();
