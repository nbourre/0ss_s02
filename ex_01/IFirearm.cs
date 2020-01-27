using System;
using System.Collections.Generic;
using System.Text;

namespace ex_01
{
    interface IFirearm
    {
        public string Shoot();
    }

    public class Colt : IFirearm
    {
        public string Shoot()
        {
            throw new NotImplementedException();
        }
    }
}
