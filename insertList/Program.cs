using System;


namespace forArr
{
    class forLoop
    {
        public static void Main(string[] args)
        {
            
           
            List<string> listItem = new List<string>(); 
             var enteredData = 0;

            for(int i = 0; ; i++)
            {
                Console.WriteLine("Enter element in list:");
                var itemInput = Console.ReadLine();
                
                if(itemInput.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                else 
                {
                     listItem.Add(itemInput);
                    enteredData++;

                    
                }
            }
            for(int i = 0; i < enteredData; i++)
            {
                Console.WriteLine("item {0} is {1}", i + 1, listItem[i]);
            }

        }
    }
}