using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JogodeCartas.src
{
    class Baralho
    {
        public static string[,] Criar()
        {
            string[,] cartas = new string[4,13];
            for (int i = 0; i < 4; i++)
            {
                for (int v = 0; v < 13; v++)
                {
                    switch (v)
                    {
                        case 0:
                            switch (i)
                            {
                                case 0:
                                    cartas[i,v] = "As Copas";
                                    break;
                                case 1:
                                    cartas[i,v] = "As Espada";
                                    break;
                                case 2:
                                    cartas[i, v] = "As Paus";
                                    break;                                   
                                case 3:
                                    cartas[i, v] = "As Ouro";
                                    break;
                            }

                            break;
                        case 10:
                            switch (i)
                            {
                                case 0:
                                    cartas[i, v] = "Valete Copas";
                                    break;
                                case 1:
                                    cartas[i, v] = "Valete Espada";
                                    break;
                                case 2:
                                    cartas[i, v] = "Valete Paus";
                                    break;                                   
                                case 3:
                                    cartas[i, v] = "Valete Ouro";
                                    break;
                            }
                            break;
                        case 11:
                            switch (i)
                            {
                                case 0:
                                    cartas[i, v] = "Dama Copas";
                                    break;
                                case 1:
                                    cartas[i, v] = "Dama Espada";
                                    break;
                                case 2:
                                    cartas[i, v] = "Dama Paus";
                                    break;                                   
                                case 3:
                                    cartas[i, v] = "Dama Ouro";
                                    break;
                            }
                            break;
                        case 12:
                            switch (i)
                            {
                                case 0:
                                    cartas[i, v] = "Rei Copas";
                                    break;
                                case 1:
                                    cartas[i, v] = "Rei Espada";
                                    break;
                                case 2:
                                    cartas[i, v] = "Rei Paus";
                                    break;                                    
                                case 3:
                                    cartas[i, v] = "Rei Ouro";
                                    break;
                            }
                            break;

                        default:
                            switch (i)
                            {
                                case 0:
                                    cartas[i, v] = (v+1) + " de Copas";
                                    break;
                                case 1:
                                    cartas[i, v] = (v+1) + " de Espada";
                                    break;
                                case 2:
                                    cartas[i, v] = (v+1) + " de Paus";
                                    break;                                    
                                case 3:
                                    cartas[i, v] = (v+1) + " de Ouro";
                                    break;
                            }

                            break;
                    }
                }
            }
            return cartas;
        }
    }
}
