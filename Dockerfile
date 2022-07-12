FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY . ./src
RUN dotnet restore ./src/DoctorManagement.sln
RUN dotnet build ./src/DoctorManagement.sln
RUN dotnet publish ./src/DoctorManagement.API/DoctorManagement.API.csproj -c Release -o outdir

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS final
WORKDIR /app
COPY --from=build /src/outdir .
ENV ASPNETCORE_ENVIRONMENT = "Staging"
ENTRYPOINT ["dotnet", "DoctorManagement.API.dll"]