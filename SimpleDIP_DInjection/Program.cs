using SimpleDIP_DInjection.BLL;
using SimpleDIP_DInjection.DAL;

namespace program
{
    class program
    {
        static void Main(string[] args)
        {
            var businesslayer = new BusinessLayer(new DataAccess());
            Console.WriteLine (businesslayer.RunSelectedApp(2)); 
        }
    }
}
