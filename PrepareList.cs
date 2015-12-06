using System.IO;

namespace ManojList
{
    class PrepareList
	  {     
        static void Main()
		    {
  			// delete and re-create it later
  			string FinalFile = Directory.GetFiles(Directory.GetCurrentDirectory(), "ManojList.ini")[0];		
  			File.Delete(FinalFile);
							
  			// Ensure to insert enter after last line of each file
  			string[] Files = Directory.GetFiles(Directory.GetCurrentDirectory(), "*List.ini");
  			
        foreach (var file in Files)			
        {
  				  File.AppendAllText(FinalFile,File.ReadAllText(file));			
		    }
		    }
	  }
}
