Console chat application using [Azure SignalR](https://docs.microsoft.com/en-us/azure/azure-signalr/signalr-overview).

## Server

Create Azure SignalR service & copy the connection string. Add the connection string in [appsettings.json](server/appsettings.json).

Run the application:

```bash
dotnet run -p server
```

## Client

Open a new terminal and run the application:

```bash
dotnet run -p client
```

The session will look something like this:

```
Enter username: micya
Connecting to chat server...
Connected to chat server
Hi!
micya: Hi!
```