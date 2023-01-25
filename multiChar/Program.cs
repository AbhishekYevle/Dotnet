using System;

namespace logic
{
    class multiChar
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter String:");
            string Word = Console.ReadLine();
            char[] wordArr = Word.ToCharArray();
            bool result = false;
            int count = 0;
            
            for(int i = 0; (i < wordArr.Length) && (result==false); i++ )
            {
                for(int j = i+1; j < wordArr.Length; j++,count++)
                {
                    
                    if(wordArr[i]==wordArr[j])
                    {
                        result=true;
                        break;
                    }
            
                }    
            }
            Console.WriteLine(count);
            if(count==0)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
                
        }
    }


}