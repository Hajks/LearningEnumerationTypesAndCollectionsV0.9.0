using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningEnumerationTypesAndCollectionsV0._9._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Card cardToCheck = new Card(Types.Clubs, Values.Three);
            bool doesItMatch = Card.DoesCardMatch(cardToCheck, Values.Two); //Using overloaded method.
            MessageBox.Show(doesItMatch.ToString());
        }
    }
}
