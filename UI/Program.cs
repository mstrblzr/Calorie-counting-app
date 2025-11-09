using System;
using Models;
using DataAccess;
using BL;


namespace PresentationLayer;

internal class Program
{
    static void Main(string[] args)
    {
        
        
        LaddaModeller laddamodeller = new LaddaModeller();
        Thread.Sleep(1000);
        Console.WriteLine(laddamodeller.SkrivUtDag());



        //for(int i = 0; i< måltidsrepo.GetAll().Count; i++)
        //{
        //    if(i == måltidsrepo.GetById(i).Id)
        //    {
        //        Console.WriteLine(måltidsrepo.GetById(i).Namn + " : " + måltidsrepo.GetById(i).GetMat());
        //    }
        //}
    }
    
}
