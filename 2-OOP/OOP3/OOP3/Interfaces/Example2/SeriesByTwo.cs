using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3.Interfaces.Example2
{
    internal class SeriesByTwo : ISeries
    {
        #region Propertys
        public int Current { get; set; }
        #endregion

        #region Methods
        public void GetNext()
        {
            Current += 2;
        }

        public void Reset()
        {
            Current = 0;
        } 
        #endregion
    }
}
