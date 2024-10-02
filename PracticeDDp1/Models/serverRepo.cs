namespace PracticeDDp1.Models;

public class serverRepo
{
    public static List<ServerEntity> servers = new List<ServerEntity>()
    {
       new ServerEntity{ServerId=1,ServerName="A",LocatedCity="dhk"},
            new ServerEntity{ServerId=2,ServerName="B",LocatedCity="dhaka"},
            new ServerEntity{ServerId=3,ServerName="C",LocatedCity="dhaka"},
            new ServerEntity{ServerId=4,ServerName="D",LocatedCity="dhaka"},
            new ServerEntity{ServerId=5,ServerName="E",LocatedCity="ctg"},
            new ServerEntity{ServerId=6,ServerName="F",LocatedCity="ctg"},
            new ServerEntity{ServerId=7,ServerName="G",LocatedCity="ctg"},
            new ServerEntity{ServerId=8,ServerName="H",LocatedCity="ctg"},
            new ServerEntity{ServerId=9,ServerName="I",LocatedCity="raj"},
            new ServerEntity{ServerId=10,ServerName="J",LocatedCity="raj"},
            new ServerEntity{ServerId=11,ServerName="K",LocatedCity="raj"},
            new ServerEntity{ServerId=12,ServerName="L",LocatedCity="raj"},
            new ServerEntity{ServerId=13,ServerName="M",LocatedCity="syl"},
            new ServerEntity{ServerId=14,ServerName="N",LocatedCity="syl"},
            new ServerEntity{ServerId=15,ServerName="O",LocatedCity="syl"}
    };

    public static List<ServerEntity> GetServers() => servers;

    public static void RemoveServer(ServerEntity server) 
        => servers.Remove(server);

    public static List<ServerEntity>GetServerByCity(string city)
    {
      return  servers.Where(s=>s.LocatedCity.Equals(city,StringComparison.OrdinalIgnoreCase)).ToList();
    }
    
    public static ServerEntity? GetServerById(int id)
    {
       var server= servers.FirstOrDefault(s => s.ServerId == id);
        if (server !=null)
        {
           return new ServerEntity
            {
                ServerId = server.ServerId,
                ServerName = server.ServerName,
                LocatedCity = server.LocatedCity,
                IsOnline = server.IsOnline
            };
        }
        return null;
    }
    public static void UpdateServer(int ServerId, ServerEntity server)
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

    public static List<ServerEntity> SearchServer(string ServerFilter)
    {
        return servers.Where(s => s.ServerName.Contains(ServerFilter, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public static void AddServer(ServerEntity entity)
    {
       var serverId= servers.Max(s => s.ServerId);
       entity.ServerId= serverId + 1;
        servers.Add(entity);

    }
}
