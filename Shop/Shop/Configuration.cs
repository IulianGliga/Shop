﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model
{
    public static class Configuration
    {
        public static string ConnectionString
        {
            get
            {
                return "Data Source=.;Initial Catalog=Shop;Integrated Security=True;";
            }
        }
    }
}
