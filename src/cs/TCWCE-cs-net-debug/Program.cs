namespace TCWCE_cs_net_debug
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string AllLines = "1:\n{\nkey1=1\nkey2=2\n}\n2:\n{\nkey1=3\nkey2=4\n}\n3:\n{\nkey1=5\nkey2=6\n}";
            TCWCE.For_String.Headers header = TCWCE.IO.ReadToHeaders(System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory,"new.txt"));
            //TCWCE.IO.ReWriteToFileAsync(System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "114514.txt"), header, null, () => { System.Console.WriteLine("我是傻逼"); });
            //new(AllLines);
            Console.WriteLine(header.EscapsedSerializedString);
            Console.ReadKey(true);

        }
    }
}