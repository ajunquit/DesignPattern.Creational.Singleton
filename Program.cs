using System;

namespace design_pattern_singleton
{
    class Setup
    {
        static void Main(string[] args)
        {
            // get connection for the first time.
            ConnectionDatabase connectionSample1 = ConnectionDatabase.GetConnectionDatabase();
            Console.WriteLine(connectionSample1.GetConnectionString());

            // get connection for the second time.
            ConnectionDatabase connectionSample2 = ConnectionDatabase.GetConnectionDatabase();
            Console.WriteLine(connectionSample2.GetConnectionString());

            Console.ReadLine();
        }
    }
}
