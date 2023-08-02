using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class SqlManager
    {
        public void Add(ISqlServer sqlServer)
        {
           
        }
    }
 
    public interface ISqlServer
    {
        void Add();
        void Update();
        void Delete();
    }
    public class MsSqlServerManager : ISqlServer
    {
        public void Add()
        {
            Console.WriteLine("MsSql Added");
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
    public class MySqlServerManager : ISqlServer
    {
        public void Add()
        {
            Console.WriteLine("MySql Added");
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }

    public class SqlOracleManager : ISqlServer
    {
        void ISqlServer.Add()
        {
            throw new NotImplementedException();
        }

        void ISqlServer.Delete()
        {
            throw new NotImplementedException();
        }

        void ISqlServer.Update()
        {
            throw new NotImplementedException();
        }
    }
}
