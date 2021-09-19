FROM mcr.microsoft.com/dotnet/sdk:5.0-alpine AS build-env

WORKDIR /app

COPY src/models ./models
COPY src/database ./database
RUN dotnet publish --runtime alpine-x64 --self-contained true /p:PublishTrimmed=true -c Release -o out database

FROM alpine
WORKDIR /app
COPY --from=build-env /app/out .
RUN apk add --no-cache icu-libs
ENTRYPOINT ["./RecipeDatabase"]
