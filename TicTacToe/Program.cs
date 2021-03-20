using System;

namespace TicTacToe
{
    class Program
    {

        private static char[,] pieces;
        private static int currPlayer;
        private static bool victory;

        static void Main(string[] args)
        {
            TicTacToe();
        }

        private static void TicTacToe()
        {
            pieces = new char[,]
            {
                { '1','2','3'},
                { '4','5','6'},
                { '7','8','9'}
            };
            currPlayer = 2;
            victory = false;

            Board(pieces);

            while (!victory)
            {
                currPlayer = currPlayer == 1 ? 2 : 1;
                Console.WriteLine($"Player {currPlayer}, choose your square:");

                int[] answer = EnterAnswer();
                pieces[answer[0], answer[1]] = currPlayer == 1 ? 'X' : 'O';

                Board(pieces);

                CheckVictory(answer);
            }

            Console.WriteLine($"CONGRATS!, PLAYER {currPlayer} IS THE WINNER!");

            Console.WriteLine("Press R to restart");
            string input = Console.ReadLine().Trim().ToLower();
            if (input == "r")
            {
                TicTacToe();
            }
        }

        private static void Board(char[,] pieces)
        {
            Console.Clear();
            Console.WriteLine("     |     |     ");
            Console.WriteLine($"  {pieces[0,0]}  |  {pieces[0, 1]}  |  {pieces[0, 2]}  ");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine($"  {pieces[1,0]}  |  {pieces[1, 1]}  |  {pieces[1, 2]}  ");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine($"  {pieces[2, 0]}  |  {pieces[2, 1]}  |  {pieces[2, 2]}  ");
            Console.WriteLine("     |     |     ");
        }

        private static int[] EnterAnswer()
        {
            string input = Console.ReadLine();
            int[] answer;

            if (!int.TryParse(input, out int inputToInt) || inputToInt > 9 || inputToInt < 1)
            {
                Console.WriteLine("Oops, input is not valid. Try again");
                return answer = EnterAnswer();
            }

            switch (inputToInt)
            {
                case 1:
                    {
                        answer = new int[] { 0, 0 };

                        break;
                    }
                case 2:
                    {
                        answer = new int[] { 0, 1 };
                        break;
                    }
                case 3:
                    {
                        answer = new int[] { 0, 2 };
                        break;
                    }
                case 4:
                    {
                        answer = new int[] { 1, 0 };
                        break;
                    }
                case 5:
                    {
                        answer = new int[] { 1, 1 };
                        break;
                    }
                case 6:
                    {
                        answer = new int[] { 1, 2 };
                        break;
                    }
                case 7:
                    {
                        answer = new int[] { 2, 0 };
                        break;
                    }
                case 8:
                    {
                        answer = new int[] { 2, 1 };
                        break;
                    }
                case 9:
                    {
                        answer = new int[] { 2, 2 };
                        break;
                    }
                default:
                    {
                        answer = new int[] { 0, 0 };
                        break;
                    }
            }

            if (pieces[answer[0], answer[1]] == 'X' || pieces[answer[0], answer[1]] == 'O')
            {

                Console.WriteLine("Sorry, that spot is already taken! Try again");
                return answer = EnterAnswer();

            } else
            {
                return answer;
            }
        }

        private static void CheckVictory(int[] node)
        {
            char playerMark = currPlayer == 1 ? 'X' : 'O';

            switch (node[0])
            {
                case 0:
                case 2:
                    {
                        switch (node[1])
                        {
                            case 0:
                            case 2:
                                {
                                    victory = CheckVertical(node, playerMark) || CheckHorizontal(node, playerMark) || CheckDiagonal(node, playerMark);
                                    break;
                                }
                            case 1:
                                {
                                    victory = CheckVertical(node, playerMark) || CheckHorizontal(node, playerMark);
                                    break;
                                }
                        }

                        break;
                    }

                case 1:
                    {
                        switch (node[1])
                        {
                            case 0:
                            case 2:
                                {
                                    victory = CheckVertical(node, playerMark) || CheckHorizontal(node, playerMark);
                                    break;
                                }
                            case 1:
                                {
                                    victory = CheckVertical(node, playerMark) || CheckHorizontal(node, playerMark) || CheckDiagonal(node, playerMark);
                                    break;
                                }
                        }
                        break;
                    }
            }
        }

        private static bool CheckVertical(int[] node, char playerMark)
        {
            return pieces[0, node[1]] == playerMark && pieces[1, node[1]] == playerMark && pieces[2, node[1]] == playerMark;
        }

        private static bool CheckHorizontal(int[] node, char playerMark)
        {
            return pieces[node[0], 0] == playerMark && pieces[node[0], 1] == playerMark && pieces[node[0], 2] == playerMark;
        }

        private static bool CheckDiagonal(int[] node, char playerMark)
        {
            bool diagonal1 = pieces[0, 0] == playerMark && pieces[1, 1] == playerMark && pieces[2, 2] == playerMark;
            bool diagonal2 = pieces[0, 2] == playerMark && pieces[1, 1] == playerMark && pieces[2, 0] == playerMark;

            return diagonal1 || diagonal2;
        }
    }
}
