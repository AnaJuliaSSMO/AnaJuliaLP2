using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_ConversorDeMedidas
{
    class Program
    {
        static void Main(string[] args)
        {
            int resp1;
            string resp2, resp3,resp4;
            double kg, g, lb, ton;
            double cm, m, km, pes, pol;
            double cel, fh, kel;

            do
            {
                    Console.WriteLine("O que deseja converter?\n1 - Massa\n2 - Temperatura\n3 - Comprimento");
                    resp1 = int.Parse(Console.ReadLine());

                    //CASO QUEIRA MASSA
                    if (resp1 == 1)
                    {
                        Console.WriteLine("\nInsira a unidade inicial(Kg,G,Lb,Ton)[INSERIR AS LETRAS EM MAIÚSCULO]:");
                        resp2 = Console.ReadLine();

                        Console.WriteLine("\nInsira a unidade para a qual deseja converter(Kg,G,Lb,Ton) [INSERIR AS LETRAS EM MAIÚSCULO]:");
                        resp3 = Console.ReadLine();

                        if (resp2 == "KG")
                        {
                            Console.WriteLine("\nQuanto há?");
                            kg = double.Parse(Console.ReadLine());

                            if (resp3 == "G")
                            {
                                //Conversor.KgparaG(kg); OBG PH POR ME DIZER Q É INÚTIL ESCREVER ISSO :')
                                Console.WriteLine(Conversor.KgparaG(kg));
                            }

                            else if (resp3 == "LB")
                            {
                                // Conversor.KgparaG(kg);
                                Console.WriteLine(Conversor.KgparaLB(kg));
                            }

                            else if (resp3 == "TON")
                            {
                                // Conversor.KgparaTON(kg);
                                Console.WriteLine(Conversor.KgparaTON(kg));
                            }
                        }

                        else if (resp2 == "G")
                        {
                            Console.WriteLine("\nQuanto há?");
                            g = double.Parse(Console.ReadLine());

                            if (resp3 == "KG")
                            {
                                // Conversor.GparaKG(g);
                                Console.WriteLine(Conversor.GparaKG(g));
                            }

                            else if (resp3 == "LB")
                            {
                                // Conversor.GparaLB(g);
                                Console.WriteLine(Conversor.GparaLB(g));
                            }

                            else if (resp3 == "TON")
                            {
                                // Conversor.GparaTON(g);
                                Console.WriteLine(Conversor.GparaTON(g));
                            }
                        }

                        else if (resp2 == "LB")
                        {
                            Console.WriteLine("\nQuanto há?");
                            lb = double.Parse(Console.ReadLine());

                            if (resp3 == "KG")
                            {
                                // Conversor.LBparaKG(lb);
                                Console.WriteLine(Conversor.LBparaKG(lb));
                            }

                            else if (resp3 == "G")
                            {
                                // Conversor.LBparaG(lb);
                                Console.WriteLine(Conversor.LBparaG(lb));
                            }

                            else if (resp3 == "TON")
                            {
                                //Conversor.LBparaTON(lb);
                                Console.WriteLine(Conversor.LBparaTON(lb));
                            }
                        }

                        else if (resp2 == "TON")
                        {
                            Console.WriteLine("\nQuanto há?");
                            ton = double.Parse(Console.ReadLine());

                            if (resp3 == "KG")
                            {
                                // Conversor.TONparaKG(ton);
                                Console.WriteLine(Conversor.TONparaKG(ton));
                            }

                            else if (resp3 == "G")
                            {
                                //  Conversor.TONparaG(ton);
                                Console.WriteLine(Conversor.TONparaG(ton));
                            }

                            else if (resp3 == "LB")
                            {
                                // Conversor.TONparaLB(ton);
                                Console.WriteLine(Conversor.TONparaLB(ton));
                            }
                        }
                    }  //FINAL MASSA


                    //CASO ESCOLHER TEMPERATURA
                    if (resp1 == 2)
                    {
                        Console.WriteLine("\nInsira a unidade inicial(Cel, Fah, Kel)[INSERIR AS LETRAS EM MAIÚSCULO]:");
                        resp2 = Console.ReadLine();

                        Console.WriteLine("\nInsira a unidade para a qual deseja converter(Cel, Fah, Kel) [INSERIR AS LETRAS EM MAIÚSCULO]:");
                        resp3 = Console.ReadLine();

                        if (resp2 == "CEL")
                        {
                            Console.WriteLine("\nQuantos graus?");
                            cel = double.Parse(Console.ReadLine());

                            if (resp3 == "FAH")
                            {
                                Console.WriteLine(Conversor.CparaF(cel));
                            }

                            else if (resp3 == "KEL")
                            {
                                Console.WriteLine(Conversor.CparaK(cel));
                            }
                        }

                        else if (resp2 == "FAH")
                        {
                            Console.WriteLine("\nQuantos graus?");
                            fh = double.Parse(Console.ReadLine());

                            if (resp3 == "CEL")
                            {
                                Console.WriteLine(Conversor.FparaC(fh));
                            }

                            else if (resp3 == "KEL")
                            {
                                Console.WriteLine(Conversor.FparaK(fh));
                            }
                        }

                        else if (resp2 == "KEL")
                        {
                            Console.WriteLine("\nQuantos graus?");
                            kel = double.Parse(Console.ReadLine());

                            if (resp3 == "CEL")
                            {
                                Console.WriteLine(Conversor.KparaC(kel));
                            }

                            else if (resp3 == "FAH")
                            {
                                Console.WriteLine(Conversor.KparaF(kel));
                            }
                        }
                    }
                    //CASO ESCOLHER COMPRIMENTO
                    if (resp1 == 3)
                    {
                        Console.WriteLine("\nInsira a unidade inicial(Cm, M, Km, Pol,Pés)[INSERIR AS LETRAS EM MAIÚSCULO]:");
                        resp2 = Console.ReadLine();

                        Console.WriteLine("\nInsira a unidade para a qual deseja converter(Cm, M, Km, Pol,Pés) [INSERIR AS LETRAS EM MAIÚSCULO]:");
                        resp3 = Console.ReadLine();

                        if (resp2 == "CM")
                        {
                            Console.WriteLine("\nQuanto há?");
                            cm = double.Parse(Console.ReadLine());

                            if (resp3 == "M")
                            {
                                //Conversor.CMparaM(cm);
                                Console.WriteLine(Conversor.CMparaM(cm));
                            }

                            else if (resp3 == "KM")
                            {
                                //  Conversor.CMparaKM(cm);
                                Console.WriteLine(Conversor.CMparaM(cm));
                            }

                            else if (resp3 == "POL")
                            {
                                //  Conversor.CMparaPOL(cm);
                                Console.WriteLine(Conversor.CMparaPOL(cm));
                            }

                            else if (resp3 == "PÉS")
                            {
                                //Conversor.CMparaPES(cm); 
                                Console.WriteLine(Conversor.CMparaPES(cm));
                            }
                        }

                        else if (resp2 == "M")
                        {
                            Console.WriteLine("\nQuanto há?");
                            m = double.Parse(Console.ReadLine());

                            if (resp3 == "CM")
                            {
                                Console.WriteLine(Conversor.MparaCM(m));
                            }

                            else if (resp3 == "KM")
                            {
                                Console.WriteLine(Conversor.MparaKM(m));
                            }

                            else if (resp3 == "POL")
                            {
                                Console.WriteLine(Conversor.MparaPOL(m));
                            }

                            else if (resp3 == "PÉS")
                            {
                                Console.WriteLine(Conversor.MparaPES(m));
                            }
                        }

                        else if (resp2 == "KM")
                        {
                            Console.WriteLine("\nQuanto há?");
                            km = double.Parse(Console.ReadLine());

                            if (resp3 == "CM")
                            {
                                Console.WriteLine(Conversor.KMparaCM(km));
                            }

                            else if (resp3 == "M")
                            {
                                Console.WriteLine(Conversor.KMparaM(km));
                            }

                            else if (resp3 == "POL")
                            {
                                Console.WriteLine(Conversor.KMparaPOL(km));
                            }

                            else if (resp3 == "PÉS")
                            {
                                Console.WriteLine(Conversor.KMparaPES(km));
                            }
                        }

                        else if (resp2 == "POL")
                        {
                            Console.WriteLine("\nQuanto há?");
                            pol = double.Parse(Console.ReadLine());

                            if (resp3 == "CM")
                            {
                                Console.WriteLine(Conversor.POLparaCM(pol));
                            }

                            else if (resp3 == "M")
                            {
                                Console.WriteLine(Conversor.POLparaM(pol));
                            }

                            else if (resp3 == "KM")
                            {
                                Console.WriteLine(Conversor.POLparaKM(pol));
                            }

                            else if (resp3 == "PÉS")
                            {
                                Console.WriteLine(Conversor.POLparaPES(pol));
                            }
                        }

                        else if (resp2 == "PES")
                        {
                            Console.WriteLine("\nQuanto há?");
                            pes = double.Parse(Console.ReadLine());

                            if (resp3 == "CM")
                            {
                                Console.WriteLine(Conversor.PESparaCM(pes));
                            }

                            else if (resp3 == "M")
                            {
                                Console.WriteLine(Conversor.PESparaM(pes));
                            }

                            else if (resp3 == "KM")
                            {
                                Console.WriteLine(Conversor.PESparaKM(pes));
                            }

                            else if (resp3 == "POL")
                            {
                                Console.WriteLine(Conversor.PESparaPOL(pes));
                            }
                        }
                    }

                    Console.WriteLine("Deseja converter novamente? S / N");
                    resp4 = Console.ReadLine();
                }
                while (resp4 == "S");    
            }
         }
    }