namespace _10.LadyBugs
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            short sizeOfField = short.Parse(Console.ReadLine());

            int[] initIndexes = Console.ReadLine()  // Array of the ladybug indexes of the next array
                                .Split(" ")
                                .Select(int.Parse)
                                .ToArray();

            int[] ladybugArray = new int[sizeOfField];  // Creating the lady bug array

            for (int i = 0; i < initIndexes.Length; i++)    // Filling the ladybug array with 1s on their indexes
            {


                if (initIndexes[i] >= 0 &&          // Checking if the current index is in bounds of the ladyBug array
                    initIndexes[i] < sizeOfField)   // to avoid out of bounds exceptions
                {
                    ladybugArray[initIndexes[i]] = 1;
                }
            }

            string command = Console.ReadLine();    // Getting the input commands -> [ladybugIndex] [left/right] [jumpPlaces] / end

            while (command != "end")
            {
                string[] commandArray = command.Split();    // Splitting the command string into a string array of 3 instructions

                int whichBug = int.Parse(commandArray[0]);  // Parsing the first command index to get the index of the bug as a number

                if (whichBug >= 0 && whichBug < sizeOfField)    // Checking the index of the bug is in bounds to avoid exceptions, but
                {
                    int jumpPlaces = int.Parse(commandArray[2]);    // Parsing the last index of the command array to get the jump length

                    if (ladybugArray[whichBug] == 1)    // Checking if there's a bug in the index we are trying to move
                    {
                        if (commandArray[1] == "left")  // Checking the middle command
                        {
                            int jumpCount = 1;  // Initializing the number of jumps - in case landing index is occupied

                            int currLanding = whichBug - jumpPlaces * jumpCount;        // Initializing the current landing index

                            while (currLanding >= 0 && ladybugArray[currLanding] == 1)  // Checking if we are inside the array and if the landing index is occupied
                            {
                                if (jumpPlaces == 0) break; // Breaking the loop if we jump 0 spaces to avoid perma-loop

                                jumpCount++;    // Increasing our jump multiplier if landing index is occupied

                                currLanding = whichBug - jumpPlaces * jumpCount;    // Setting the new land index
                            }



                            if (currLanding >= 0)   // Checking if we are still in bounds, otherwise we dont need to change the landing value
                            {
                                ladybugArray[currLanding] = 1;
                            }

                            if (jumpPlaces != 0)    // Checking if we jumped 0 spaces to avoid nulling our current value
                            {
                                ladybugArray[whichBug] = 0;
                            }
                        }

                        // Same logic like in "left" but reversed
                        else if (commandArray[1] == "right")
                        {
                            int jumpCount = 1;
                            int currLanding = whichBug + jumpPlaces * jumpCount;

                            while (currLanding < sizeOfField && ladybugArray[currLanding] == 1)
                            {
                                if (jumpPlaces == 0) break;

                                jumpCount++;
                                currLanding = whichBug + jumpPlaces * jumpCount;
                            }

                            if (currLanding < sizeOfField)
                            {
                                ladybugArray[currLanding] = 1;
                            }

                            if (jumpPlaces != 0)
                            {
                                ladybugArray[whichBug] = 0;
                            }
                        }
                    }
                }

                // Entering the new command in the end of the current cycle
                command = Console.ReadLine();

            }

            // Writting the ladybug array split by spaces
            Console.WriteLine(string.Join(" ", ladybugArray));

        }
    }
}
