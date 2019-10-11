using System;
using System.Collections.Generic;
using System.Text;
using TicTacToeRendererLib.Enums;
using TicTacToeRendererLib.Renderer;
using System.Threading;

namespace TicTacToeSubmissionConole
{
    public class TicTacToe
    {
        private TicTacToeConsoleRenderer _boardRenderer;

        public TicTacToe()
        {
            _boardRenderer = new TicTacToeConsoleRenderer(10, 6);
            _boardRenderer.Render();
        }


        public void Run()
        {
            char[] playerx = new char[9];
            char[] playery = new char[9];

            // FOR ILLUSTRATION CHANGE TO YOUR OWN LOGIC TO DO TIC TAC TOE

            for (int index = 0; index < playerx.Length; index++)

            {
                if (index == 0 || index % 2 == 0)
                {

                    Console.SetCursorPosition(2, 18);
                    Console.Write("Player X");


                    Console.SetCursorPosition(2, 20);
                    Console.Write("Please Enter Row: ");
                    var rowx = Console.ReadLine();

                    Console.SetCursorPosition(2, 21);
                    Console.Write("Please Enter Column: ");
                    var columnx = Console.ReadLine();

                    _boardRenderer.AddMove(int.Parse(rowx), int.Parse(columnx), PlayerEnum.X, true);

                    if (playerx[index] == ' ' && playery[index] == ' ')
                    {
                        _boardRenderer.AddMove(int.Parse(rowx), int.Parse(columnx), PlayerEnum.X, true);

                    }

                    if (int.Parse(rowx) == 0 && int.Parse(columnx) == 0)
                    {
                        playerx[0] = '0';
                    }

                    if (int.Parse(rowx) == 0 && int.Parse(columnx) == 1)
                    {
                        playerx[1] = '0';
                    }

                    if (int.Parse(rowx) == 0 && int.Parse(columnx) == 2)
                    {
                        playerx[2] = '0';
                    }

                    if (int.Parse(rowx) == 1 && int.Parse(columnx) == 0)
                    {
                        playerx[3] = '0';
                    }

                    if (int.Parse(rowx) == 1 && int.Parse(columnx) == 1)
                    {
                        playerx[4] = '0';
                    }

                    if (int.Parse(rowx) == 1 && int.Parse(columnx) == 2)
                    {
                        playerx[5] = '0';
                    }

                    if (int.Parse(rowx) == 2 && int.Parse(columnx) == 0)
                    {
                        playerx[6] = '0';
                    }

                    if (int.Parse(rowx) == 2 && int.Parse(columnx) == 1)
                    {
                        playerx[7] = '0';
                    }

                    if (int.Parse(rowx) == 2 && int.Parse(columnx) == 2)
                    {
                        playerx[8] = '0';
                    }
                }

                for (int index1 = 0; index1 < playery.Length; index++)
                {
                    if (index == 0 || index % 2 == 0)
                    {
                        Console.SetCursorPosition(40, 18);
                        Console.Write("Player Y");

                        Console.SetCursorPosition(40, 20);
                        Console.Write("Please enter Row:");
                        var rowy = Console.ReadLine();

                        Console.SetCursorPosition(40, 21);
                        Console.Write("Please Enter Column: ");
                        var columny = Console.ReadLine();

                        _boardRenderer.AddMove(int.Parse(rowy), int.Parse(columny), PlayerEnum.O, true);


                        if (int.Parse(rowy) == 0 && int.Parse(columny) == 0)
                        {
                            playery[0] = '0';
                        }

                        if (int.Parse(rowy) == 0 && int.Parse(columny) == 1)
                        {
                            playery[1] = '0';
                        }

                        if (int.Parse(rowy) == 0 && int.Parse(columny) == 2)
                        {
                            playery[2] = '0';
                        }

                        if (int.Parse(rowy) == 1 && int.Parse(columny) == 0)
                        {
                            playery[3] = '0';
                        }

                        if (int.Parse(rowy) == 1 && int.Parse(columny) == 1)
                        {
                            playery[4] = '0';
                        }

                        if (int.Parse(rowy) == 1 && int.Parse(columny) == 2)
                        {
                            playery[5] = '0';
                        }

                        if (int.Parse(rowy) == 2 && int.Parse(columny) == 0)
                        {
                            playery[6] = '0';
                        }

                        if (int.Parse(rowy) == 2 && int.Parse(columny) == 1)
                        {
                            playery[7] = '0';
                        }

                        if (int.Parse(rowy) == 2 && int.Parse(columny) == 2)
                        {
                            playery[8] = '0';
                        }


                    }


                }
            }
                

                    








                




            
        }
    }
}
