﻿using System.Data.Entity;

namespace AmigosDeLaWeb.Models
{
    public class DataContext : DbContext
 
    {
        public DataContext():base("DefaultConnection")
        {

        }
    }
}