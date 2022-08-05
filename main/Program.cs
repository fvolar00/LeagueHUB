using System;
using System.Collections.Generic;
using System.Windows;
using System.Text;
using System.Threading.Tasks;
using LeagueHUB_infrastructure;
using static System.Net.Mime.MediaTypeNames;

class Program
{
    static LeagueContext context;

    static void Main(string[] args)
    {


        PopulateDatabase();

    }


    static void PopulateDatabase()
    {

        context = new LeagueContext();

        //context.Database.EnsureDeleted();
        context.Database.EnsureCreated();
    }

}