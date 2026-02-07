# See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

# This stage is used when running from VS in fast mode (Default for Debug configuration)
FROM mcr.microsoft.com/dotnet/runtime:9.0 AS base
USER $APP_UID
WORKDIR /app


# This stage is used to build the service project
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["services/administration/NuGet.Config", "services/administration/"]
COPY ["services/identity/NuGet.Config", "services/identity/"]
COPY ["services/projects/NuGet.Config", "services/projects/"]
COPY ["services/saas/NuGet.Config", "services/saas/"]
COPY ["shared/ResourceryWorkflow.DbMigrator/ResourceryWorkflow.DbMigrator.csproj", "shared/ResourceryWorkflow.DbMigrator/"]
COPY ["services/administration/src/ResourceryWorkflow.Administration.Application.Contracts/ResourceryWorkflow.Administration.Application.Contracts.csproj", "services/administration/src/ResourceryWorkflow.Administration.Application.Contracts/"]
COPY ["services/administration/src/ResourceryWorkflow.Administration.Domain.Shared/ResourceryWorkflow.Administration.Domain.Shared.csproj", "services/administration/src/ResourceryWorkflow.Administration.Domain.Shared/"]
COPY ["services/administration/src/ResourceryWorkflow.Administration.EntityFrameworkCore/ResourceryWorkflow.Administration.EntityFrameworkCore.csproj", "services/administration/src/ResourceryWorkflow.Administration.EntityFrameworkCore/"]
COPY ["shared/ResourceryWorkflow.Shared/ResourceryWorkflow.Shared.csproj", "shared/ResourceryWorkflow.Shared/"]
COPY ["services/administration/src/ResourceryWorkflow.Administration.Domain/ResourceryWorkflow.Administration.Domain.csproj", "services/administration/src/ResourceryWorkflow.Administration.Domain/"]
COPY ["services/identity/src/ResourceryWorkflow.IdentityService.Application.Contracts/ResourceryWorkflow.IdentityService.Application.Contracts.csproj", "services/identity/src/ResourceryWorkflow.IdentityService.Application.Contracts/"]
COPY ["services/identity/src/ResourceryWorkflow.IdentityService.Domain.Shared/ResourceryWorkflow.IdentityService.Domain.Shared.csproj", "services/identity/src/ResourceryWorkflow.IdentityService.Domain.Shared/"]
COPY ["services/identity/src/ResourceryWorkflow.IdentityService.EntityFrameworkCore/ResourceryWorkflow.IdentityService.EntityFrameworkCore.csproj", "services/identity/src/ResourceryWorkflow.IdentityService.EntityFrameworkCore/"]
COPY ["services/identity/src/ResourceryWorkflow.IdentityService.Domain/ResourceryWorkflow.IdentityService.Domain.csproj", "services/identity/src/ResourceryWorkflow.IdentityService.Domain/"]
COPY ["services/projects/src/ResourceryWorkflow.Projects.Application.Contracts/ResourceryWorkflow.Projects.Application.Contracts.csproj", "services/projects/src/ResourceryWorkflow.Projects.Application.Contracts/"]
COPY ["services/projects/src/ResourceryWorkflow.Projects.Domain.Shared/ResourceryWorkflow.Projects.Domain.Shared.csproj", "services/projects/src/ResourceryWorkflow.Projects.Domain.Shared/"]
COPY ["services/projects/src/ResourceryWorkflow.Projects.EntityFrameworkCore/ResourceryWorkflow.Projects.EntityFrameworkCore.csproj", "services/projects/src/ResourceryWorkflow.Projects.EntityFrameworkCore/"]
COPY ["services/projects/src/ResourceryWorkflow.Projects.Domain/ResourceryWorkflow.Projects.Domain.csproj", "services/projects/src/ResourceryWorkflow.Projects.Domain/"]
COPY ["services/saas/src/ResourceryWorkflow.SaaS.Application.Contracts/ResourceryWorkflow.SaaS.Application.Contracts.csproj", "services/saas/src/ResourceryWorkflow.SaaS.Application.Contracts/"]
COPY ["services/saas/src/ResourceryWorkflow.SaaS.Domain.Shared/ResourceryWorkflow.SaaS.Domain.Shared.csproj", "services/saas/src/ResourceryWorkflow.SaaS.Domain.Shared/"]
COPY ["services/saas/src/ResourceryWorkflow.SaaS.EntityFrameworkCore/ResourceryWorkflow.SaaS.EntityFrameworkCore.csproj", "services/saas/src/ResourceryWorkflow.SaaS.EntityFrameworkCore/"]
COPY ["services/saas/src/ResourceryWorkflow.SaaS.Domain/ResourceryWorkflow.SaaS.Domain.csproj", "services/saas/src/ResourceryWorkflow.SaaS.Domain/"]
COPY ["shared/ResourceryWorkflow.Microservice.Shared/ResourceryWorkflow.Microservice.Shared.csproj", "shared/ResourceryWorkflow.Microservice.Shared/"]
COPY ["shared/ResourceryWorkflow.Hosting.Shared/ResourceryWorkflow.Hosting.Shared.csproj", "shared/ResourceryWorkflow.Hosting.Shared/"]
COPY ["shared/ResourceryWorkflow.ServiceDefaults/ResourceryWorkflow.ServiceDefaults.csproj", "shared/ResourceryWorkflow.ServiceDefaults/"]
RUN dotnet restore "./shared/ResourceryWorkflow.DbMigrator/ResourceryWorkflow.DbMigrator.csproj"
COPY . .
WORKDIR "/src/shared/ResourceryWorkflow.DbMigrator"
RUN dotnet build "./ResourceryWorkflow.DbMigrator.csproj" -c $BUILD_CONFIGURATION -o /app/build

# This stage is used to publish the service project to be copied to the final stage
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./ResourceryWorkflow.DbMigrator.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# This stage is used in production or when running from VS in regular mode (Default when not using the Debug configuration)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ResourceryWorkflow.DbMigrator.dll"]