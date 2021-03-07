using System;
using System.Collections.Generic;
using System.Text;
//the namespace must be PAT.Lib, the class and method names can be arbitrary
namespace PAT.Lib
{
    public class RandomNumber
    {
	    public static int randomNumber(int lowerBound, int upperBound)
        {
            Random rd = new Random();
            
            int randNum = rd.Next(lowerBound, upperBound);
            return randNum;
        }
    }
}
