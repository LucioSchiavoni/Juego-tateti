using System;

using System.Text;


namespace Tateti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int jugador = 2;
            int ingreso = 0;
            bool ingresoCorrecto = true;




            do
            {
                if (jugador == 2)
                {
                    jugador = 1;
                    turno(jugador, ingreso);
                }
                else if (jugador == 1)
                {
                    jugador = 2;
                    turno(jugador, ingreso);
                }
                CrearTablero();

                #region
                //Metodo para validar ganador

                char[] signoPlayer = { 'X', 'O' };

                foreach (char signo in signoPlayer)
                {
                    if ((casilleros[0, 0] == signo) && (casilleros[0, 1] == signo) && (casilleros[0, 2] == signo)
                        || (casilleros[1, 0] == signo) && (casilleros[1, 1] == signo) && (casilleros[1, 2] == signo)
                        || (casilleros[2, 0] == signo) && (casilleros[2, 1] == signo) && (casilleros[2, 2] == signo)
                        || (casilleros[0, 0] == signo) && (casilleros[1, 1] == signo) && (casilleros[2, 2] == signo)
                        || (casilleros[0, 2] == signo) && (casilleros[1, 2] == signo) && (casilleros[2, 2] == signo)
                        || (casilleros[0, 1] == signo) && (casilleros[1, 1] == signo) && (casilleros[0, 2] == signo)
                        || (casilleros[1, 0] == signo) && (casilleros[1, 1] == signo) && (casilleros[1, 2] == signo)
                        || (casilleros[0, 1] == signo) && (casilleros[1, 1] == signo) && (casilleros[2, 1] == signo)
                        || (casilleros[0, 0] == signo) && (casilleros[1, 0] == signo) && (casilleros[2, 0] == signo)
                        || (casilleros[0, 2] == signo) && (casilleros[1, 1] == signo) && (casilleros[2, 0] == signo))
                    {
                        if (signo == 'X')

                            Console.WriteLine("Felicitaciones a el jugador: 2");


                        else

                            Console.WriteLine("Felicitaciones a el jugador: 1");


                        Console.WriteLine("Presione una letra para reiniciar el juego");
                        Console.Read();
                        ingreso = 0;
                        reiniciar();
                        break;
                     }    

                        else if (contador == 10)
                        {
                            Console.WriteLine("Empate!!");
                            Console.WriteLine("Presione una letra para reiniciar el juego");
                            Console.Read();
                            
                            reiniciar();
                            break;
                        }

                   
                    




                }
                #endregion

                #region
                do
                {
                    Console.WriteLine("Jugador {0} ingrese un numero del casillero", jugador);
                    try
                    {

                        ingreso = Convert.ToInt32(Console.ReadLine());

                    }
                    catch
                    {
                        Console.WriteLine("Ingrese un numero");
                    }


                    if ((ingreso == 1) && (casilleros[0, 0] == '1'))
                        ingresoCorrecto = true;
                    else if ((ingreso == 2) && (casilleros[0, 1] == '2'))
                        ingresoCorrecto = true;
                    else if ((ingreso == 3) && (casilleros[0, 2] == '3'))
                        ingresoCorrecto = true;
                    else if ((ingreso == 4) && (casilleros[1, 0] == '4'))
                        ingresoCorrecto = true;
                    else if ((ingreso == 5) && (casilleros[1, 1] == '5'))
                        ingresoCorrecto = true;
                    else if ((ingreso == 6) && (casilleros[1, 2] == '6'))
                        ingresoCorrecto = true;
                    else if ((ingreso == 7) && (casilleros[2, 0] == '7'))
                        ingresoCorrecto = true;
                    else if ((ingreso == 8) && (casilleros[2, 1] == '8'))
                        ingresoCorrecto = true;
                    else if ((ingreso == 9) && (casilleros[2, 2] == '9'))
                        ingresoCorrecto = true;

                    else
                    {
                        Console.WriteLine("Por favor ingrese un numero valido");
                        ingresoCorrecto = false;
                    }



                } while (!ingresoCorrecto);
                #endregion


                
             
                 }while (true);

               
        }
      

        public static void turno(int jugador, int ingreso)
        {
            char signo = ' ';

            if(jugador == 1)
            {
                signo = 'X';
            }else if(jugador == 2)
            {
                signo = 'O';
            }
            switch (ingreso)
            {
                case 1: casilleros[0, 0] = signo; break;
                case 2: casilleros[0, 1] = signo; break;
                case 3: casilleros[0, 2] = signo; break;
                case 4: casilleros[1, 0] = signo; break;
                case 5: casilleros[1, 1] = signo; break;
                case 6: casilleros[1, 2] = signo; break;
                case 7: casilleros[2, 0] = signo; break;
                case 8: casilleros[2, 1] = signo; break;
                case 9: casilleros[2, 2] = signo; break;
            }

        }

        static char[,] casilleros =
        {
            {'1', '2', '3' },
            {'4', '5', '6' },
            {'7', '8', '9' }
        };

        static char[,] casilleroNuevo =  {
            {'1', '2', '3' },
            {'4', '5', '6' },
            {'7', '8', '9' }
        };

        static int contador = 0;
        public static void CrearTablero()
        {
            Console.Clear();
            Console.WriteLine("     |     |");
            Console.WriteLine("  {0}  |  {1}  |  {2}", casilleros[0,0], casilleros[0,1], casilleros[0,2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |");
            Console.WriteLine("  {0}  |  {1}  |  {2}", casilleros[1,0], casilleros[1,1], casilleros[1,2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |");
            Console.WriteLine("  {0}  |  {1}  |  {2}", casilleros[2,0], casilleros[2,1], casilleros[2,2]);
            Console.WriteLine("     |     |");
            contador++;


        }
        public static void reiniciar()
        {
            casilleros = casilleroNuevo;
            CrearTablero();
            contador = 0;
        }
    }
}
