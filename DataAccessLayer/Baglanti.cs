﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    internal class Baglanti
    {
        public static SqlConnection bgl = new SqlConnection("Data Source=DESKTOP-KK1AS77\\SQLEXPRESS;Initial Catalog=DbPersonel;Integrated Security=True");
    }
}
