using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploBitmaskNETCore
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region from class to int/bin value
            EditDataMode dataMode = EditDataMode.Read | EditDataMode.Create | EditDataMode.Delete;
            Console.WriteLine("Checking flags:");
            if (IsFlagSet(dataMode, EditDataMode.Create))
            {
                Console.WriteLine("  Create flag is set.");
            }

            if (IsFlagSet(dataMode, EditDataMode.Read))
            {
                Console.WriteLine("  Read flag is set.");
            }

            if (IsFlagSet(dataMode, EditDataMode.Update))
            {
                Console.WriteLine("  Update flag is set.");
            }

            if (IsFlagSet(dataMode, EditDataMode.Delete))
            {
                Console.WriteLine("  Delete flag is set.");
            }

            Console.WriteLine("EditDataMode to string: {0}", dataMode.ToString());
            Console.WriteLine("From EditDataMode to int: {0}", (int)dataMode);
            Console.WriteLine("From EditDataMode to string (bin): {0}", Convert.ToString((int)dataMode, 2));
            Console.WriteLine("====");
            #endregion

            #region from bin/int value to class
            string input = "0011";
            Console.WriteLine("Input: {0}", input);
            int convertedInput2Bin = Convert.ToInt32(input, 2);

            Console.WriteLine("Converted input from string to int: {0}", convertedInput2Bin);
            EditDataMode inputDataMode = (EditDataMode)convertedInput2Bin;
            Console.WriteLine("EditDataMode to string: {0}", inputDataMode.ToString());

            #endregion

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        static bool IsFlagSet(EditDataMode bitmask, EditDataMode flag)
        {
            return (bitmask & flag) != 0;
        }
    }

    [Flags]
    public enum EditDataMode
    {
        Create = 1,
        Read = 2,
        Update = 4,
        Delete = 8
    }
}
