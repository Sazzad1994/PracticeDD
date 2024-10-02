namespace NewBlazor01.Models;

public class serverRepo
{
    public static List<Server> servers = new List<Server>()
    {
       new Server{ServerId=1,ServerName="Server1",LocatedCity="dhaka"},
            new Server{ServerId=2,ServerName="Server2",LocatedCity="dhaka"},
            new Server{ServerId=3,ServerName="Server3",LocatedCity="dhaka"},
            new Server{ServerId=4,ServerName="Server4",LocatedCity="dhaka"},
            new Server{ServerId=5,ServerName="Server5",LocatedCity="ctg"},
            new Server{ServerId=6,ServerName="Server6",LocatedCity="ctg"},
            new Server{ServerId=7,ServerName="Server7",LocatedCity="ctg"},
            new Server{ServerId=8,ServerName="Server8",LocatedCity="ctg"},
            new Server{ServerId=9,ServerName="Server9",LocatedCity="raj"},
            new Server{ServerId=10,ServerName="Server10",LocatedCity="raj"},
            new Server{ServerId=11,ServerName="Server11",LocatedCity="raj"},
            new Server{ServerId=12,ServerName="Server12",LocatedCity="raj"},
            new Server{ServerId=13,ServerName="Server13",LocatedCity="syl"},
            new Server{ServerId=14,ServerName="Server14",LocatedCity="syl"},
            new Server{ServerId=15,ServerName="Server15",LocatedCity="syl"}
    };

    public static List<Server> GetServers() => servers;

    public static void AddServer(Server entity)
    {
        var serverId = servers.Max(s => s.ServerId);
        entity.ServerId = serverId + 1;
        servers.Add(entity);

    }
    public static void RemoveServer(Server server) 
        => servers.Remove(server);

    public static List<Server>GetServerByCity(string city)
    {
      return  servers.Where(s=>s.LocatedCity.Equals(city,StringComparison.OrdinalIgnoreCase)).ToList();
    }
    
    public static Server? GetServerById(int id)
    {
       var server= servers.FirstOrDefault(s => s.ServerId == id);
        if (server !=null)
        {
           return new Server
            {
                ServerId = server.ServerId,
                ServerName = server.ServerName,
                LocatedCity = server.LocatedCity,
                IsOnline = server.IsOnline
            };
        }
        return null;
    }
    public static void UpdateServer(int ServerId, Server server)
    {
        if (ServerId != server.ServerId) return;
          var ServerToUpdate= servers.FirstOrDefault(s => s.ServerId == ServerId);
        if (ServerToUpdate != null)
        {
            ServerToUpdate.IsOnline = server.IsOnline;
            ServerToUpdate.ServerName=server.ServerName;
            ServerToUpdate.LocatedCity = ServerToUpdate.LocatedCity;
        }
    }
   
    public static void DeleteServer(int ServerId)
    {
        var serverToDelete = servers.FirstOrDefault(s => s.ServerId == ServerId);

        if(serverToDelete != null)
        {
            servers.Remove(serverToDelete);
        }    
    }

    public static List<Server> SearchServer(string ServerFilter)
    {
        return servers.Where(s => s.ServerName.Contains(ServerFilter, StringComparison.OrdinalIgnoreCase)).ToList();
    }

 
}
