// See https://aka.ms/new-console-template for more information
using System;
using System.Data;
using System.Diagnostics.CodeAnalysis;
//Я пытался использовать методы, однако они влияют на переменные только внутри их самих, так что я их закоментировал и просто скопировал код
namespace tictaktoe
{
    class Program
    {
        static void change(bool player)
        {
            if (player == true)
            {
                player = false;

            }
            else
            {
                player = true;
            }
        }
        static void now (string[,] ttt)
        {
            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write(ttt[i, j]);
                }
                Console.Write("\n");
            }
        }
        static void turn(bool player)
        {
            if (player == true)
            {
                Console.WriteLine("Ход игрока X");
            }
            else
            {
                Console.WriteLine("Ход игрока O");
            }
        }
        static void cell(string[,] ttt, bool player)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Напишите номер клетки по оси x: ");
                var x = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.WriteLine("Напишите номер клетки по оси y: ");
                var y = Convert.ToInt32(Console.ReadLine()) - 1;
                if (ttt[y, x] == "[ ]")
                {
                    if (player == true)
                    {
                        ttt[y, x] = "[X]";
                        break;
                    }
                    else
                    {
                        ttt[y, x] = "[O]";
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка. Эта клетка уже занята, попробуйте ввести другие кординаты");
                }
            }
        }
        static void check(string[,] ttt,bool win)
        {
            if (ttt[2, 0] == ttt[1, 1] && ttt[0, 2] == ttt[1, 1] && ttt[1, 1] != "[ ]")
            {
                win = true;
            }
            else if (ttt[0, 0] == ttt[1, 1] && ttt[2, 2] == ttt[1, 1] && ttt[1, 1] != "[ ]")
            {
                win = true;
            }
            else
            {
                for (int g = 0; g < 3; g++)
                {
                    if (ttt[g, 0] == ttt[g, 1] && ttt[g, 1] == ttt[g, 2] && ttt[g, 1] != "[ ]")
                    {
                        win = true;
                    }
                    else if (ttt[0, g] == ttt[1, g] && ttt[1, g] == ttt[2, g] && ttt[1, g] != "[ ]")
                    {
                        win = true;
                    }
                }
            }
        }
        static void fin(bool player)
        {
            if (player == true)
            {
                Console.WriteLine("Победил игрок Х");
            }
            else
            {
                Console.WriteLine("Победил игрок О");
            }
        }
        static void Main()
        {
            string[,] ttt = new string[3, 3] { { "[ ]", "[ ]", "[ ]" }, { "[ ]", "[ ]", "[ ]" }, { "[ ]", "[ ]", "[ ]" } };
            bool player = false;//O
            bool win = false;
            for (int i = 0; i < 9; i++)
            {
                //change(player);
                if (player == true)
                {
                    player = false;
                }
                else
                {
                    player = true;
                }
                Console.WriteLine("Текущее положение игры");
                //now(ttt);
                for (int z = 0; z < 3; z++)
                {
                    for(int j = 0; j < 3; j++)
                    {
                        Console.Write(ttt[z, j]);
                    }
                Console.Write("\n");
                }
                //turn(player);
                if (player == true)
                {
                    Console.WriteLine("Ход игрока X");
                }
                else
                {
                    Console.WriteLine("Ход игрока O");
                }
                //cell(ttt,player);
                for (int k = 0; k < 3; i--)
                {
                    Console.WriteLine("Напишите номер клетки по оси x: ");
                    var x = Convert.ToInt32(Console.ReadLine()) - 1;
                    Console.WriteLine("Напишите номер клетки по оси y: ");
                    var y = Convert.ToInt32(Console.ReadLine()) - 1;
                    if (ttt[y, x] == "[ ]")
                    {
                        if (player == true)
                        {
                            ttt[y, x] = "[X]";
                            break;
                        }
                        else
                        {
                            ttt[y, x] = "[O]";
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ошибка. Эта клетка уже занята, попробуйте ввести другие кординаты");
                    }
                }
                //check(ttt, win);
                if (ttt[2, 0] == ttt[1,1] && ttt[0, 2] == ttt[1,1] && ttt[1, 1] != "[ ]")
                {
                    win = true;
                }
                else if (ttt[0, 0] == ttt[1,1] && ttt[2, 2] == ttt[1,1] && ttt[1,1]!="[ ]")
                {
                    win = true;
                }
                else
                {
                    for (int g = 0; g < 3; g++)
                    {
                        if (ttt[g, 0] == ttt[g,1] && ttt[g, 1] == ttt[g,2] && ttt[g, 1]!="[ ]")
                        {
                            win = true;
                        }
                        else if (ttt[0, g] == ttt[1, g] && ttt[1, g] == ttt[2, g] && ttt[1, g] != "[ ]")
                        {
                            win = true;
                        }
                    }
                }
                //wingame
                if (win == true)
                {
                    fin(player);
                    break;
                }
            }
            if (win == false)
            {
                Console.WriteLine("Ничья");
            }
            //now(ttt);
        }
    }
}
