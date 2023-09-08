﻿namespace _05.Coins
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine());

            double convert = change * 100;
            int cents = (int)convert;
            int coins = 0;

            int reminder = cents % 200;
            coins += cents / 200;
            cents = reminder;


            reminder = cents % 100;
            coins += cents / 100;
            cents = reminder;


            reminder = cents % 50;
            coins += cents / 50;
            cents = reminder;


            reminder = cents % 20;
            coins += cents / 20;
            cents = reminder;


            reminder = cents % 10;
            coins += cents / 10;
            cents = reminder;


            reminder = cents % 5;
            coins += cents / 5;
            cents = reminder;


            reminder = cents % 2;
            coins += cents / 2;
            cents = reminder;


            reminder = cents % 1;
            coins += cents / 1;
            cents = reminder;

            Console.WriteLine(coins);
        }
    }
}
