namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args) {

            var items = Enumerable.Range(1, 3);
            var x=items.Select(
                i => {
                    Console.WriteLine("a");
                    i++;
                    return i ;
                });
            foreach (var item in x)
                Console.WriteLine(item);

        }
        //{ICollection<string> collection = new List<string>();
        //    int a = 777;
        //    object b = (object)a;
        //    a = 555;
        //    Console.WriteLine(b);
        //    //a++;
        //    int c = (int)b;

        //    Console.WriteLine(@$"a{a},b{b},c{c}");
        //    object m_lock=new object();
        //    while (true)
        //    {
        //        lock (m_lock)
        //        {
        //            Console.WriteLine(m_lock);
        //        }
            //}
        
       // }
    }
}
