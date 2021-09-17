ARG SA_PASSWORD=R3c1p3@pp

FROM mcr.microsoft.com/mssql/server:2019-latest

ENV ACCEPT_EULA=Y

COPY CreateRecipeDb.sql /

ARG SA_PASSWORD
RUN (/opt/mssql/bin/sqlservr --accept-eula & ) | grep -q "Service Broker manager has started" && /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P $SA_PASSWORD -i /CreateRecipeDb.sql

