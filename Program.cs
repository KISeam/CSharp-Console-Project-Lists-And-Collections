class ListsAndCollections
{
    public static void Main(string[] args)
    {
        List<string> list = new List<string>();
        list.Add("MacBook Pro");
        list.Add("MacBook Air");
        list.Add("iMac");
        list.Add("iMac Pro");
        list.Add("Mac Mini");
        list.Add("Mac Studio");

        foreach (string item in list)
        {
            Console.WriteLine(item);
        }
    }
}
