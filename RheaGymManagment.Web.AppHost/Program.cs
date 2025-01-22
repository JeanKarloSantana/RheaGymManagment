var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.RheaGymManagment_Api>("rheagymmanagment-api");

builder.Build().Run();
