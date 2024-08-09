using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProxyDesignPattern.GlobalInterface;

namespace ProxyDesignPattern.Model
{
    public class SharedFolder : ISharedFolder
    {
        public void ReadWriteOperation()
        {
            Console.WriteLine("Original Folder");
            Console.WriteLine("Performed Read Write Operation");
        }

    }
}
