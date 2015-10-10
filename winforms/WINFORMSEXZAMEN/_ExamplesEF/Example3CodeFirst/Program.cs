using Example1CodeFirst.ContextDB;
using Example1CodeFirst.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1CodeFirst
{
    class Program
    {   // Демонстрация Code First с миграцией данных
        // Суть миграции данных: при изменении структуры данных (добавлении нового поля, связанной таблицы т.д.) 
        // необходимо создать новую базу данных, 
        // однако при этом необходимо сохранить имеющиеся данные в БД

        //Команды для миграции 
        // Вводим команды в окне: "Консоль деспетчера пакетов"
            //Install-Package EntityFramework               
            //Enable-Migrations -ProjectName "Example3CodeFirst"      
        //Add-Migration SampleMigrations -ProjectName "Example3CodeFirstMigrations"
            //Enable-Migrations –EnableAutomaticMigrations  
            //Update-Database                               
            //Update-Database –Verbose                      

        static void Main(string[] args)
        {
            // Создание базы данных
            GameContext db = new GameContext();
            // Добавление данных в таблицу Players 
            Player pl1 = new Player() { Age = 33, Name = "Inna", Position = "Forvard" };
        
            db.Players.Add(pl1);
          
            // Добавление данных в таблицу Teams 
            Team team = new Team();
            team.Name = "Barsa";
            team.Players = new List<Player>();
            team.Players.Add(pl1);
          
            db.Teams.Add(team);

            // Сохранение результатов 
            db.SaveChanges();   

            // Вывод значений, содержащихся в базе данных!
            foreach (var item in db.Teams)
            {
                Console.WriteLine(item.Name);
                foreach (var pl in item.Players)
                {
                    Console.WriteLine(pl.Name + " " + pl.Position);
                }
            }

            Console.ReadKey();
        }


    }
}