var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.ISS_Enterprise_back_Admin_service>("iss-enterprise-back-admin-service");

builder.Build().Run();
