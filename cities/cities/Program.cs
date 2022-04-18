using System;
using System.Collections.Generic;

namespace cities
{
    internal class Program { 
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");



            int[] population = new int[26]
            {
                8897109, 12828837, 9461105, 6371773, 5965343,
                5946800, 5582170, 5564635, 5268860, 4552402, 
                4335391, 4296250, 4224851, 4192887, 3439809, 
                3279833, 3095313, 2812896, 2783243, 2710489, 
                2543482, 2356285, 2226009, 2149127, 2142508, 134411
            };

           
        //Array.Sort(population);

        //Console.WriteLine(population[0]);


        void PopulationCheck(int sumOfPopulation, int cIndex, int sIndex)
            {
                int currentIndex = cIndex;
                int subIndex = sIndex;
                
                if (currentIndex < population.Length-1)
                {

                    if (subIndex < population.Length - 1)
                    {

                        if (sumOfPopulation == 100000000)
                        {
                            Console.WriteLine("Answer Exists--------------------");
                        }


                        if (sumOfPopulation < 100000000)
                        {

                            currentIndex++;
                            sumOfPopulation += population[currentIndex];
                            Console.WriteLine(sumOfPopulation);
                            PopulationCheck(sumOfPopulation, currentIndex, subIndex);
                        }

                    }
                    //Add PopulationCheck3
                        
                    
                }
                PopulationCheck2(sumOfPopulation, currentIndex, subIndex);



            }
            //subIndex
            void PopulationCheck2(int sumOfPopulation, int cIndex, int sIndex)
            {
                int subIndex = sIndex;
                    sumOfPopulation -= population[cIndex];
                    int currentIndex = ++cIndex;
                    PopulationCheck(sumOfPopulation, currentIndex,sIndex);
                //Console.WriteLine("INDEX INCREASED");
                

            }


            int sumOfPopulation = 0;
            int subIndex = 1;

            for(int i0 = 0; i0 < 3; i0++)
            {
                sumOfPopulation = population[i0];
                //Console.WriteLine($"Root index is{i0}");

                PopulationCheck(sumOfPopulation, i0, subIndex);




                //if (sumOfPopulation < 100000000) {
                //    int i1 = ++i0;
                //    sumOfPopulation+=population[i1];
                //    Console.WriteLine(sumOfPopulation);

                //    if(sumOfPopulation < 100000000){
                //        int i2 = ++i0;
                //        sumOfPopulation += population[i2];
                //        Console.WriteLine(sumOfPopulation);
                //        --i0;
                //    }
                //    --i0;

                //        }
            }

            //IDictionary<int, int> cityPopulation = new Dictionary<int, int>();

           

            //foreach(int i in population)
            //{
            //    cityPopulation.Add(i, population[i]);
          
                
            //}



        }

    }
}
