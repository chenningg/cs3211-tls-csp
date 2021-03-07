using System;
using System.Collections.Generic;
using System.Text;
//the namespace must be PAT.Lib, the class and method names can be arbitrary
namespace PAT.Lib
{
    public class RandomNumber
    {
	       public static int randomNumber()
        {
        		Random rd = new Random();
        		
        		int rand_num = rd.Next(100,300);
		        return rand_num;
        }
    }
}
