namespace Test
{
    //bad
    public void SendEmailToListOfClients(string[] clients)
    {
        foreach (var client in clients)
        {
            var clientRecord = db.Find(client);
            if (clientRecord.IsActive())
            {
                Email(client);
            }
        }
    }

    //good
    public void SendEmailToListOfClients(string[] clients)
    {
        var activeClients = GetActiveClients(clients);
        // Do some logic
    }

    public List<Client> GetActiveClients(string[] clients)
    {
        return db.Find(clients).Where(s => s.Status == "Active");
    }

    public class MenuConfig
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public string ButtonText { get; set; }
        public bool Cancellable { get; set; }
    }

    public class Ioc
    {
        public static T Get<T>()
        {
            return default(T);
        }
    }

    public interface IOptions<TDbConnectionOption>
    {
    }

    public class DbConnectionOption
    {
    }

    public class Test
    {
        //bad
        public void CreateFile(string name, bool temp = false)
        {
            if (temp)
            {
                Create("./temp/" + name);
            }
            else
            {
                Create(name);
            }
        }

        //good
        public void CreateFile(string name)
        {
            Create(name);
        }

        public void CreateTempFile(string name)
        {
            Create("./temp/" + name);
        }
    }

    public enum PlaneType
    {
        A380,
        Cessna,
        F18
    }
}




