using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Subscriber;

//namespace Subscriber
//{

public class DataAccess
{
    public List<Subscriber_> fList = new List<Subscriber_> (5);
    public DataAccess()
    {
        OpenDBFile();
    }
    private void OpenDBFile() { }

}
    
    
//}
