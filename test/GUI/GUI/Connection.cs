using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class Connection
    {
        int _method; // 1>>RC, 2>>SerialPort, 3>>Wifi
        
        public Connection()
        {
            this._method = 1; //Default to RC
        }

        public void update(int newMethod)
        {
            _method = newMethod;
        }
    
    }
}
