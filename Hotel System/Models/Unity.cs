﻿using System;
using System.Collections.Generic;
using System.Configuration;

namespace Hotel_System.Models
{
     static class Unity
    {
        public static string ConnectionString => 
            ConfigurationManager.ConnectionStrings["Local"].ConnectionString;

        //#region Important String used in Table Configurations

        //#endregion
    }
}
