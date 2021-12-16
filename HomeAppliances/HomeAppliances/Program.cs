using System.Collections.Generic;

namespace HomeAppliances
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> onequiments = new List<int>(){1, 2, 6}; // implements list
            List<int> offequipments = new List<int>() {3};

            ImplementHomeAppliances myhome = new ImplementHomeAppliances();
            myhome.getlistofequipments();

            myhome.switchonoffequipments(onequiments, true);
            myhome.getlistofequipments();

            myhome.switchonoffequipments(offequipments, false);
            myhome.getlistofequipments();

            myhome.gettotalpowerconsumption();

            myhome.getappliance(500);

            myhome.gethierarchyofappliances();
        }
    }
}
