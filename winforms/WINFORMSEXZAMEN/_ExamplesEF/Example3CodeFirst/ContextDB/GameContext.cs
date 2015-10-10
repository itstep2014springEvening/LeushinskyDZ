﻿using Example1CodeFirst.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Подключение библиотеки Entity Framework
using System.Data.Entity;

namespace Example1CodeFirst.ContextDB
{
    
    public class GameContext: DbContext
    {
        // конструтор для настройки поведения базы данных
        static GameContext()
        {
            // инициализация базы данными 
           
        }

        public GameContext()
            : base("name=GameConnectionString")
        { 
        
        }
      
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}
