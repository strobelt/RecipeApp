FROM mcr.microsoft.com/mssql/server:2019-latest
 
ENV ACCEPT_EULA=Y
ENV SA_PASSWORD=R3c1p3@pp

WORKDIR /src
COPY CreateRecipeDb.sql /
RUN /opt/mssql-tools/bin/sqlcmd -S 127.0.0.1 -U sa -P R3c1p3@pp -i /CreateRecipeDb.sql

#WORKDIR /src

#COPY MyProductDB.bak /dbbackups/ 

#RUN (/opt/mssql/bin/sqlservr --accept-eula & ) | grep -q "Service Broker manager has started" &&  /opt/mssql-tools/bin/sqlcmd -S127.0.0.1 -Usa -PTest@12345  -Q"RESTORE DATABASE MyProductDB FROM DISK='/dbbackups/MyProductDB.bak';" 
