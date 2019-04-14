namespace Test
{
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




