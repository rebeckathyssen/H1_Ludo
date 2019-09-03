using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF1_OOP_Opgave1
{
    class Die
    {        
        string[] arr = new string[] { "1er", "2er", "4er", "6er", "stjerne", "globus" };

        public Die()
        {
                        
        }

        public string ThrowDie()
        {
            Random rnd = new Random();
            string[] ShuffledArray = arr.OrderBy(x => rnd.Next()).ToArray();
            string dieResult = ShuffledArray[0];
            return dieResult;
        }
    }
}
