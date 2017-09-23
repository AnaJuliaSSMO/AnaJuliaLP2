using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_ConversorDeMedidas
{
    class Conversor
    {
        //medidas de massa
        public static double salvekg, finalkg;
        public static double salveg, finalg;
        public static double salvelb, finallb;
        public static double salveton, finalton;

        //medidas de comprimento
        public static double salvecm, finalcm;
        public static double salvem, finalm;
        public static double salvekm, finalkm;
        public static double salvepes, finalpes;
        public static double salvepol, finalpol;

        //medidas de temperatura
        public static double salvecel, finalcel;
        public static double salvekel, finalkel;
        public static double salvefh, finalfh;

        //PESOS

        //KG PARA _______________ MDS QUANTA COISA SCRR

        public static string KgparaG(double kg) 
        {
            salvekg = kg;
            finalkg = kg * 1000;
            return String.Format("\nVocê tinha {0}Kg e agora tem {1}G\n", salvekg, finalkg);
        }

        public static string KgparaLB(double kg) 
        {
            salvekg = kg;
            finalkg = kg * 2.20;
            return String.Format("\nVocê tinha {0}Kg e agora tem aproximadamente {1}Lb\n", salvekg, finalkg);
        }

        public static string KgparaTON(double kg)
        {
            salvekg = kg;
            finalkg = kg * 0.001;
            return String.Format("\nVocê tinha {0}Kg e agora tem {1}Ton\n", salvekg, finalkg);
        }

        //G PARA _________________
        public static string GparaKG(double g)
        {
            salveg = g;
            finalg = g * 1000;
            return String.Format("\nVocê tinha {0}g e agora tem {1}kg\n", salveg, finalg);
        }

        public static string GparaLB(double g)
        {
            salveg = g;
            finalg = g * 0.0022;
            return String.Format("\nVocê tinha {0}g e agora tem aproximadamente {1}Lb\n", salveg, finalg);
        }

        public static string GparaTON(double g)
        {
            salveg = g;
            finalg = g * 0.000001;
            return String.Format("\nVocê tinha {0}g e agora tem {1}Ton\n", salveg, finalg);
        }

        //LB PARA _______________________
        public static string LBparaKG(double lb)
        {
            salvelb = lb;
            finallb = lb * 0.453;
            return String.Format("\nVocê tinha {0}Lb e agora tem {1}Kg\n", salvelb, finallb);
        }

        public static string LBparaG(double lb)
        {
            salvelb = lb;
            finallb = lb * 453.5;
            return String.Format("\nVocê tinha {0}Lb e agora tem {1}G\n", salvelb, finallb);
        }

        public static string LBparaTON(double lb)
        {
            salvelb = lb;
            finallb = lb * 0.000453;
            return String.Format("\nVocê tinha {0}Lb e agora tem {1}Ton\n", salvelb, finallb);
        }

        //TON PARA ____________________
        public static string TONparaKG(double ton)
        {
            salveton = ton;
            finalton = ton / 0.453;
            return String.Format("\nVocê tinha {0}Ton e agora tem {1}Kg\n", salveton, finalton);
        }

        public static string TONparaG(double ton)
        {
            salveton = ton;
            finalton = ton / 453.5;
            return String.Format("\nVocê tinha {0}Ton e agora tem {1}G\n", salveton, finalton);
        }

        public static string TONparaLB(double ton)
        {
            salveton = ton;
            finalton = ton / 0.000453;
            return String.Format("\nVocê tinha {0}Ton e agora tem {1}Lb\n", salveton, finalton);
        }

        //MEDIDAS DE COMPRIMENTO

        //CM PARA _______________________
        public static string CMparaM(double cm)
        {
            salvecm = cm;
            finalcm = cm / 0.01;
            return String.Format("\nVocê tinha {0}Cm e agora tem {1}M\n", salvecm, finalcm);
        }

        public static string CMparaKM(double cm)
        {
            salvecm = cm;
            finalcm = cm / 0.00001;
            return String.Format("\nVocê tinha {0}Cm e agora tem {1}Km\n", salvecm, finalcm);
        }

        public static string CMparaPOL(double cm)
        {
            salvecm = cm;
            finalcm = cm / 0.3937;
            return String.Format("\nVocê tinha {0}Cm e agora tem {1}Polegadas\n", salvecm, finalcm);
        }

        public static string CMparaPES(double cm)
        {
            salvecm = cm;
            finalcm = cm / 0.0328;
            return String.Format("\nVocê tinha {0}Cm e agora tem {1}Pés\n", salvecm, finalcm);
        }

        //M PARA ________________________
        public static string MparaCM(double m)
        {
            salvem = m;
            finalm = m * 100;
            return String.Format("\nVocê tinha {0}M e agora tem {1}Cm\n", salvem, finalm);
        }

        public static string MparaPES(double m)
        {
            salvem = m;
            finalm = m * 3.2808;
            return String.Format("\nVocê tinha {0}M e agora tem {1}Pés\n", salvem, finalm);
        }

        public static string MparaPOL(double m)
        {
            salvem = m;
            finalm = m * 39.3701;
            return String.Format("\nVocê tinha {0}M e agora tem {1}Polegadas\n", salvem, finalm);
        }

        public static string MparaKM(double m)
        {
            salvem = m;
            finalm = m * 0.001;
            return String.Format("\nVocê tinha {0}M e agora tem {1}Km\n", salvem, finalm);
        }

        //kM PARA ________________________
        public static string KMparaCM(double km)
        {
            salvekm = km;
            finalkm = km * 100000;
            return String.Format("\nVocê tinha {0}Km e agora tem {1}Cm\n", salvekm, finalkm);
        }

        public static string KMparaM(double km)
        {
            salvekm = km;
            finalkm = km * 1000;
            return String.Format("\nVocê tinha {0}Km e agora tem {1}M\n", salvekm, finalkm);
        }

        public static string KMparaPES(double km)
        {
            salvekm = km;
            finalkm = km * 3280.84;
            return String.Format("\nVocê tinha {0}Km e agora tem {1}Pés\n", salvekm, finalkm);
        }

        public static string KMparaPOL(double km)
        {
            salvekm = km;
            finalkm = km * 39370.1;
            return String.Format("\nVocê tinha {0}Km e agora tem {1}Polegadas\n", salvekm, finalkm);
        }

        //POLEGADAS PARA ________________________
        public static string POLparaCM(double pol)
        {
            salvepol = pol;
            finalpol = pol * 2.54;
            return String.Format("\nVocê tinha {0}Polegadas e agora tem {1}Cm\n", salvepol, finalpol);
        }

        public static string POLparaM(double pol)
        {
            salvepol = pol;
            finalpol = pol * 0.0254;
            return String.Format("\nVocê tinha {0}Polegadas e agora tem {1}M\n", salvepol, finalpol);
        }

        public static string POLparaKM(double pol)
        {
            salvepol = pol;
            finalpol = pol * 0.0000254;
            return String.Format("\nVocê tinha {0}Polegadas e agora tem {1}Km\n", salvepol, finalpol);
        }

        public static string POLparaPES(double pol)
        {
            salvepol = pol;
            finalpol = pol * 0.0833;
            return String.Format("\nVocê tinha {0}Polegadas e agora tem {1}Pés\n", salvepol, finalpol);
        }

        //PÉS PARA ________________________
        public static string PESparaCM(double pes)
        {
            salvepes = pes;
            finalpes = pes * 30.48;
            return String.Format("\nVocê tinha {0}Pés e agora tem {1}Cm\n", salvepes, finalpes);
        }

        public static string PESparaM(double pes)
        {
            salvepes = pes;
            finalpes = pes * 0.3048;
            return String.Format("\nVocê tinha {0}Pés e agora tem {1}M\n", salvepes, finalpes);
        }

        public static string PESparaKM(double pes)
        {
            salvepes = pes;
            finalpes = pes * 0.0003048;
            return String.Format("\nVocê tinha {0}Pés e agora tem {1}M\n", salvepes, finalpes);
        }
    
        public static string PESparaPOL(double pes)
        {
            salvepes = pes;
            finalpes = pes * 12;
            return String.Format("\nVocê tinha {0}Pés e agora tem {1}Polegadas\n", salvepes, finalpes);
        }

        //TEMPERATURAS

        //CELSCIUS PARA ________________________
        public static string CparaK(double cel)
        {
            salvecel = cel;
            finalcel = cel + 273;
            return String.Format("\nVocê tinha {0}ºCelsius e agora tem {1}Kelvin\n", salvecel, finalcel);
        }

        public static string CparaF(double cel)
        {
            salvecel = cel;
            finalcel = (cel * 1.8) + 32;
            return String.Format("\nVocê tinha {0}ºCelsius e agora tem {1}ºFahrenheit\n", salvecel, finalcel);
        }

        //KELVIN PARA ________________________
        public static string KparaC(double kel)
        {
            salvekel = kel;
            finalkel = kel - 273;
            return String.Format("\nVocê tinha {0}Kelvin e agora tem {1}ºCelsius\n", salvekel, finalkel);
        }

        public static string KparaF(double kel)
        {
            salvekel = kel;
            finalkel = (kel * 1.8) - 459.67;
            return String.Format("\nVocê tinha {0}Kelvin e agora tem {1}ºFahrenheit\n", salvekel, finalkel);
        }

        //FAHRENHEIT PARA ________________________
        public static string FparaC(double fh)
        {
            salvefh = fh;
            finalfh = (fh-32)/1.8;
            return String.Format("\nVocê tinha {0}ºFahrenheit e agora tem {1}ºCelsius\n", salvefh, finalfh);
        }

        public static string FparaK(double fh)
        {
            salvefh = fh;
            finalfh = ((fh - 32) / 1.8) + 273;
            return String.Format("\nVocê tinha {0}ºFahrenheit e agora tem {1}Kelvin\n", salvefh, finalfh);
        }
    }
}
