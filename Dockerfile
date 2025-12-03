# STAGE 1 — Build (Otimizado)
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY *.sln .
COPY *.csproj .
RUN dotnet restore "pratododia-project.csproj"

COPY . .
RUN dotnet publish "pratododia-project.csproj" -c Release -o /app/publish

# STAGE 2 — App (Final)
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
EXPOSE 8080
ENTRYPOINT ["dotnet", "pratododia-project.dll"]

# STAGE 3 — Migrator (Reaproveita o BUILD e adiciona ferramentas)
FROM build AS migrator
WORKDIR /src
RUN dotnet tool install --global dotnet-ef --version 8.0.3
ENV PATH="$PATH:/root/.dotnet/tools"
