using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace AxelMaldonadoS7
{
    public interface DataBase
    {
        SQLiteAsyncConnection GetConnection();
    }
}
