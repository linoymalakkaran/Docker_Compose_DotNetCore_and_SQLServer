1) 
Docker MS SQL IMAGE CMD: docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=Pa$$w0rd2019' -e 'MSSQL_PID=Express' -p 1433:1433 -d mcr.microsoft.com/mssql/server:2017-l
atest-ubuntu

2) 
Docker build dotnet application: docker build -t linoymp/colorapi .
Docker run dotnet appllication: docker run -p 8080:80 -t linoymp/colorapi


