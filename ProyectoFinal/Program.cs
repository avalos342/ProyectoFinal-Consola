using System;

namespace ProyectoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            numeracionArabiga obj = new numeracionArabiga("Cada dígito tiene un valor absoluto y un valor relativo según su posición. El valor de cada posición es una potencia del número que es la base del sistema.", 7000, "arabigo y romano", 123456789, "un conjunto de símbolos y reglas de generación que permiten construir todos los números válidos.", 670);
            Console.WriteLine("las caracteristicas son : " + obj.Caracteristicas);
            Console.WriteLine("el año de origen es (a.C) : " + obj.AñoOrigen);
            Console.WriteLine("las tipos de sistema de numeracion que veremos son : " + obj.TipodeSistema);
            Console.WriteLine("los numeros arabigos se representan como (ejemplos) : " + obj.Simbolo);
            Console.WriteLine("la definicion de numeracion arabiga es : " + obj.Definicion);
            Console.WriteLine("El año de creacion es (a.C) : " + obj.AñodeCreacion);
            Console.ReadKey();

            double n1 = 0, n2 = 0, s = 0, r = 0, m = 0, d = 0;
            Console.Write("escribe el primer numero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("escribe el segundo numero: ");
            n2 = int.Parse(Console.ReadLine());
            s = n1 + n2;
            r = n1 - n2;
            m = n1 * n2;
            d = n1 / n2;
            Console.WriteLine("la suma de {0} + {1} = {2}", n1, n2, s);
            Console.WriteLine("la resta de {0} - {1} = {2}", n1, n2, r);
            Console.WriteLine("la multiplicacion de {0} * {1} = {2}", n1, n2, m);
            Console.WriteLine("la division de {0} / {1} = {2}", n1, n2, d);
            Console.ReadKey();

            int op1 = 0, op2 = 0;
            string rOp1 = "", rOp2 = "";

            Console.Write("Escribe un primer numero < 4000 y > 0: ");
            op1 = int.Parse(Console.ReadLine());
            rOp1 = ConvertirEnteroARomano(op1);

            Console.Write("Escribe un segundo numero < 4000 y > 0: ");
            op2 = int.Parse(Console.ReadLine());
            rOp2 = ConvertirEnteroARomano(op2);

            string sRom = ConvertirEnteroARomano(op1 + op2);
            string rRom = ConvertirEnteroARomano(op1 - op2);
            string mRom = ConvertirEnteroARomano(op1 * op2);
            string dRom = ConvertirEnteroARomano(op1 / op2);

            Console.WriteLine("la suma de {0} + {1} = {2}", rOp1, rOp2, sRom);
            Console.WriteLine("la resta de {0} - {1} = {2}", rOp1, rOp2, rRom);
            Console.WriteLine("la multiplicacion de {0} * {1} = {2}", rOp1, rOp2, mRom);
            Console.WriteLine("la division de {0} / {1} = {2}", rOp1, rOp2, dRom);
            Console.ReadKey();


            static string ConvertirEnteroARomano(int numeroEntero)
            {
                string numeroRomano = "";
                while (true)
                {
                    if (numeroEntero < 4000 && numeroEntero > 999)
                    {
                        switch (numeroEntero / 1000)
                        {
                            case 1: numeroRomano += "M"; break;
                            case 2: numeroRomano += "MM"; break;
                            case 3: numeroRomano += "MMM"; break;
                        }
                        numeroEntero -= 1000 * (numeroEntero / 1000);
                    }
                    else if (numeroEntero < 1000 && numeroEntero > 99)
                    {
                        switch (numeroEntero / 100)
                        {
                            case 1: numeroRomano += "C"; break;
                            case 2: numeroRomano += "CC"; break;
                            case 3: numeroRomano += "CCC"; break;
                            case 4: numeroRomano += "CD"; break;
                            case 5: numeroRomano += "D"; break;
                            case 6: numeroRomano += "DC"; break;
                            case 7: numeroRomano += "DCC"; break;
                            case 8: numeroRomano += "DCCC"; break;
                            case 9: numeroRomano += "CM"; break;
                        }
                        numeroEntero -= 100 * (numeroEntero / 100);
                    }
                    else if (numeroEntero < 100 && numeroEntero > 9)
                    {
                        switch (numeroEntero / 10)
                        {
                            case 1: numeroRomano += "X"; break;
                            case 2: numeroRomano += "XX"; break;
                            case 3: numeroRomano += "XXX"; break;
                            case 4: numeroRomano += "XL"; break;
                            case 5: numeroRomano += "L"; break;
                            case 6: numeroRomano += "LX"; break;
                            case 7: numeroRomano += "LXX"; break;
                            case 8: numeroRomano += "LXXX"; break;
                            case 9: numeroRomano += "XC"; break;
                        }
                        numeroEntero -= 10 * (numeroEntero / 10);
                    }
                    else if (numeroEntero < 10 && numeroEntero > 0)
                    {
                        switch (numeroEntero)
                        {
                            case 1: numeroRomano += "I"; break;
                            case 2: numeroRomano += "II"; break;
                            case 3: numeroRomano += "III"; break;
                            case 4: numeroRomano += "IV"; break;
                            case 5: numeroRomano += "V"; break;
                            case 6: numeroRomano += "VI"; break;
                            case 7: numeroRomano += "VII"; break;
                            case 8: numeroRomano += "VIII"; break;
                            case 9: numeroRomano += "IX"; break;
                        }
                        numeroEntero -= numeroEntero;
                    }
                    else
                    {
                        numeroRomano = "El numero no esta en el rango";

                        break;
                    }
                    if (numeroEntero == 0)
                        break;
                }
                return numeroRomano;
            }
        }
    }
    }
