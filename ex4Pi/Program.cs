using System;

namespace ex4Pi
{
    class Program
    {
        static void Main(string[] args)
        {
           for(int num=1; num <=100; num++){
               System.Console.WriteLine(((num%4!=0) ? num.ToString() : "PI"));
               
            //    if((num % 4)==0){
            //        System.Console.WriteLine(" PI");
            //        System.Threading.Thread.Sleep(60);
            //    }else{
            //        System.Console.WriteLine(num);
            //         System.Threading.Thread.Sleep(60);
            //    }
           } //fim do for
        }
    }
}
