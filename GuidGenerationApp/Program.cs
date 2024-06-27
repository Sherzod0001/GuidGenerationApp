using System;

namespace GuidGenerationApp
{
    class Program
    {
       static void Main(string[] args)
       {
            string yesOrNo = "";
            do 
            {
                string StringGenerationGuid = Guid.NewGuid().ToString();

                Console.WriteLine($"New Guid: {StringGenerationGuid}");
                TextCopy.ClipboardService.SetText(StringGenerationGuid);
                Console.WriteLine("Copied....\n");
                
                Console.WriteLine("Do you want to continue? (yes / no)");
                yesOrNo = Console.ReadLine();
                Console.WriteLine();
            } while (yesOrNo.ToLower() == "yes" | yesOrNo.ToLower() == "y");
            

       }
    }
}
