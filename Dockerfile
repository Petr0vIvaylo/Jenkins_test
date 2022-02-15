FROM mcr.microsoft.com/dotnet/aspnet AS base
WORKDIR /app
#EXPOSE 80

#Stage 2: Build and publish the code

FROM mcr.microsoft.com/dotnet/sdk AS build
WORKDIR /app
COPY AnimalFarm.csproj .
RUN dotnet restore --no-dependencies
COPY . .
RUN dotnet build -c Release

FROM build AS publish
RUN dotnet test AnimalFarm.csproj
RUN dotnet publish -c Release -o /publish

#Stage 3: Build and publish the code

FROM base AS final
WORKDIR /app
COPY --from=publish /publish .
ENTRYPOINT ["dotnet", "AnimalFarm.dll"]
