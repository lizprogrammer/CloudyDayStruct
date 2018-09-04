using System;
﻿using System.Collections;

namespace CloudyDayStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        // Initialize:   
        Cloud cloud1 = new Cloud();
        Town town1 = new Town(10, 10);

        // Display results:
        Console.Write("Cloud 1: ");
        Console.WriteLine("location = {0}, size = {1}", cloud1.location, cloud1.size);

        Console.Write("Town 1: ");
        Console.WriteLine("location = {0}, poplulation = {1}", town1.location, town1.population);
        
        if(isSunny(cloud1, town1))
            Console.WriteLine("This town is sunny!");

        // Keep the console window open in debug mode.
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
            
        }
        
        static bool isSunny(Cloud myCloud, Town myTown)
        {
            Console.WriteLine("Hey");
            
            if(myCloud.location == myTown.location)
                return false;
            else
                return true;
        }
    }  
    
    public struct Cloud
    {
        public int location, size;

        public Cloud(int p1, int p2)
    
        {
            location = p1;
            size = p2;
        }
    }
        
    public struct Town
    {
        public int location, population;

        public Town(int p1, int p2)
        {
            location = p1;
            population = p2;
        }
    }
    


}
