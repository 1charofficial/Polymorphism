using System;


namespace polymorphism

{



public class UserInput 
    {

        public void Converter(string valueOne, int valueTwo)
        {
            int conOne = Convert.ToInt32(valueOne);
            string conTwo = Convert.ToString(valueTwo);

             
            Console.WriteLine($"Converted from a string to an int {conOne}, converting from int to a string {conTwo}");
            
           
        }

        public void Converter(bool bool1, decimal dec1)
        {
            int conBool = Convert.ToInt32(bool1);
            double conDec = Convert.ToDouble(dec1);

            Console.WriteLine($"This bool is converted to an int:{conBool}. And this decimal is converted to a double {conDec}");


        }

        public void Converter(double dOne, float F1)

        {
            int DOneCon = Convert.ToByte(dOne);
            double F1Con = Convert.ToDouble(F1);
            
            Console.WriteLine($"This Double is converted to an int:{DOneCon}. And this float is converted to a double {F1Con}");


        }

        public void Converter(string doorNum, int postcode, string dOb, bool homeOwner)

        {
            int doorNumCon = (int)Convert.ChangeType(doorNum, typeof(int));
            string postCodeCon = (string)Convert.ChangeType(postcode, typeof(string));
            DateTime dObCon = (DateTime)Convert.ChangeType(dOb, typeof(DateTime));

            Console.WriteLine($"Door number: {doorNumCon}. Postcode: {postCodeCon}. D.O.B: {dObCon}. H/O: {homeOwner}");


        }
    

    


    }

}