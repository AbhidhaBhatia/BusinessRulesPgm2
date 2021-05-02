using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngineAB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the payment option: \n 1. PhysicalProduct \n 2. Book \n 3. Membership Activation \n 4. Membership Upgrade \n 5. Video");
            int replyOfUser = Convert.ToInt16(Console.ReadLine());
            switch (replyOfUser)
            {
                case 1:
                    Console.WriteLine("Physical Product");
                    PhysicalProduct p1 = new PhysicalProduct();
                    p1.GeneratePackingSlip("Shipping", "");
                    p1.GenerateCommission("Agent C", "900");
                    break;
                case 2:
                    Console.WriteLine("Book");
                    Book b1 = new Book();
                    b1.GeneratePackingSlip("Royalty", "");
                    b1.GenerateCommission("Agent M", "200");
                    break;
                case 3:
                    Console.WriteLine("Membership Activation");
                    Membership m1 = new Membership();
                    m1.Activate(220, "Premium");
                    break;
                case 4:
                    Console.WriteLine("Membership upgrade");
                    Membership m2 = new Membership();
                    m2.Upgrade(225, "Normal");
                    break;
                case 5:
                    Console.WriteLine("Video");
                    Video v1 = new Video();
                    v1.GeneratePackingSlip("Shipping", "First Aid Video");
                    break;
                default:
                    Console.WriteLine("Enter Proper value");
                    break;


            }
        }
    }
}
