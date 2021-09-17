FROM mcr.microsoft.com/dotnet/sdk:5.0-alpine AS base

RUN dotnet tool install --global dotnet-ef

RUN dotnet ef
