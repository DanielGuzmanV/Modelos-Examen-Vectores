using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newVectores2
{
    class classVector
    {
        // Atributos 
        const int dimension = 50;
        private int[] vector;
        private int cantidad;

        // Constructor 
        public classVector()
        {
            vector = new int[dimension];
            cantidad = 0;
        }

        // Metodos y funciones auxiliares para los ejercicios ***********
        
        // Metodos para cargar, descargar y cargar elemento por elemento

        // Cargar elementos random ----------------------------
        public void cargarRandom(int cant, int ini, int fin)
        {
            Random rand = new Random();
            this.cantidad = cant;
            for(int ter = 1; ter <= this.cantidad; ter++)
            {
                vector[ter] = rand.Next(ini, fin + 1);
            }
        }

        // Descargar elementos random --------------------------
        public string descargar()
        {
            string separador = "";
            for(int ter = 1; ter <= this.cantidad; ter++)
            {
                separador = separador + vector[ter] + "|";
            }
            return separador;
        }

        // Cargar elemento por elemento ----------------------
        public void cargarElexEle(int number)
        {
            this.cantidad = this.cantidad + 1; // o this.cantidad++; "Manera mas simple"
            vector[this.cantidad] = number;
        }

        // *** Funciones auxiliares ***
        // ----------------------------

        // Funcion para intercambio de elementos -------------
        public void intercambio(int date1, int date2)
        {
            int auxi = vector[date2];
            vector[date2] = vector[date1];
            vector[date1] = auxi;
        }
        
        // Funcion ordenamiento por parametros ---------------
        public void ordenParametros(int ini, int fin)
        {
            for(int ter1 = ini; ter1 < fin; ter1++)
            {
                for(int ter2 = ter1 + 1; ter2 <= fin; ter2++)
                {
                    // Hacemos el cambio aqui para ordenar de mayor a menor o de menor a mayor (solo por parametros)
                    if(vector[ter2] < vector[ter1])
                    {
                        this.intercambio(ter2, ter1);
                    }
                }
            }
        }

        // Funcion para busqueda secuencial de un elemento
        public bool busquedaSecuencial(int number)
        {
            bool respu = false; int ter = 1;
            while (ter <= this.cantidad && respu == false)
            {
                if(vector[ter] == number)
                {
                    respu = true;
                }
                ter++;
            }
            return respu;
        }

        // Funcion para frecuencia de un elemento
        public int frecuenciaElem(int number)
        {
            int conta = 0;
            for(int ter = 1; ter <= this.cantidad; ter++)
            {
                if(vector[ter] == number)
                {
                    conta++;
                }
            }
            return conta;
        }

        // Funcion auxiliar para ordenar sin parametros
        public void ordenSinparametros()
        {
            for(int ter1 = 1; ter1 < this.cantidad; ter1++)
            {
                for (int ter2 = ter1 + 1; ter2 <= this.cantidad; ter2++)
                {
                    if(vector[ter2] > vector[ter1])
                    {
                        this.intercambio(ter2, ter1);
                    }
                }
            }
        }

        // Funcion auxiliar para encontrar un elemento mayor del vector por parametros
        public int elemMaximo(int number, int ini, int fin)
        {
            //bool respu = false;
            //int posi = ini;
            for (int posi = ini; posi <= fin; posi++)
            {
                if (vector[posi] > number)
                {
                    number = vector[posi];
                    //respu = true;
                }
                //posi++;
            }
            return number;
        }

        // funcion auxiliar busqueda de fibonacci por parametros
        public bool busquedaFibo(int number, int ini, int fin)
        {
            bool respu = false;
            int ter, varfibo, varA, varB;
            ter = ini; varfibo = 0; varA = 0; varB = 1;

            while(ter <= fin && respu == false)
            {
                varfibo = varA + varB;
                if(varfibo == number)
                {
                    respu = true;
                }
                else if(number < varfibo)
                {
                    ter++;
                }
                else if(number > varfibo)
                {
                    varA = varB; varB = varfibo;
                }
            }
            return respu;
        }

        // Modelos de examen *********************************

        // Pregunta 1: Encontrar elemento y frecuencia (ordenado de < a >)
        // de elementos de fibonacci del rango a y b

        public void elemFrecuFibonacci(int ini, int fin, ref classVector vecEle, ref classVector vecFrecu)
        {
            vecEle.cantidad = 0;
            vecFrecu.cantidad = 0;

            int ter1, ele, frecu, varfibo, varA, varB;
            ter1 = ini; varfibo = 0; varA = 0; varB = 1;

            this.ordenParametros(ter1, fin);
            while(ter1 <= fin)
            {
                varfibo = varA + varB;
                frecu = 0;
                ele = vector[ter1];
                
                if(ele == varfibo)
                {
                    while(ter1 <= fin && vector[ter1] == ele)
                    {
                        ter1++; frecu++;
                    }
                    vecEle.cargarElexEle(ele);
                    vecFrecu.cargarElexEle(frecu);
                    varA = varB; varB = varfibo;
                }
                else if(ele < varfibo)
                {
                    ter1++;
                }
                else if(ele > varfibo)
                {
                    varA = varB; varB = varfibo;
                }
            }
        }
        // Pregunta 2: Cargar randomicamente el vector sin repetidos
        public void cargarSinRepet(int cant, int ini, int fin)
        {
            Random rand = new Random();
            int ele;
            do
            {
                ele = rand.Next(ini, fin + 1);
                if (!(busquedaSecuencial(ele)))
                {
                    this.cantidad++;
                    vector[this.cantidad] = ele;
                }
            } while (!(this.cantidad == cant));
        }
        
        // Pregunta 3: Eliminar los elementos de posicion multiplos, donde solo
        // estaran los elementos que no seran multiplos

        public void elimPosMultiplos(int number)
        {
            int conta, resi;
            conta = 0;
            for(int ter = 1; ter <= this.cantidad; ter++)
            {
                resi = ter % number;
                if(resi != 0)
                {
                    conta++;
                    vector[conta] = vector[ter];
                }
            }
            this.cantidad = conta;
        }

        // Pregunta 4: Segmentar el vector en repetidos y no repetidos
        // ordenados descendentemente

        public void segmentarRepetYNoRepet()
        {
            for(int ter1 = 1; ter1 < this.cantidad; ter1++)
            {
                for(int ter2 = ter1 + 1; ter2 <= this.cantidad; ter2++)
                {
                    if((frecuenciaElem(vector[ter2]) != 1) && (!(frecuenciaElem(vector[ter1]) != 1)) ||
                        (frecuenciaElem(vector[ter2]) != 1) && (frecuenciaElem(vector[ter1]) != 1) && (vector[ter2] > vector[ter1]) ||
                        (!(frecuenciaElem(vector[ter2]) != 1)) && (!(frecuenciaElem(vector[ter1]) !=1 )) && (vector[ter2] > vector[ter1]))
                    {
                        this.intercambio(ter2, ter1);
                    }
                }
            }
        }
        
        // Pregunta 5: Encontrar elemento y frecuencia del rango a y b, donde los elementos
        // estan ordenados descendentemente (mayor a menor) y el resultado es de aquellos que tienen frecuencia
        public void elementFrecu(int ini, int fin, ref classVector vecEle, ref classVector vecFrecu)
        {
            vecEle.cantidad = 0;
            vecFrecu.cantidad = 0;

            int ele, frecu, ter;
            ter = ini;
            this.ordenParametros(ter, fin);
            while(ter <= fin)
            {
                frecu = 0;
                ele = vector[ter];
                while(ter <= fin && vector[ter] == ele)
                {
                    ter++; frecu++;
                }
                if(frecu != 1)
                {
                    vecEle.cargarElexEle(ele);
                    vecFrecu.cargarElexEle(frecu);
                    // Para ordenar de mayor a menor cambiamos la funcion auxiliar
                    // ordenParametros(), osea de "<" a ">"
                }
            }
        }
        
        // Pregunta 6: Ordenar de mayor a menor los elementos de posiciones 
        // multiplos de m
        public void ordenMayMenPosMulti(int number)
        {
            int media = this.cantidad / number;
            for(int ter1 = 1; ter1 < media; ter1++)
            {
                for(int ter2 = ter1 + 1; ter2 <= media; ter2++)
                {
                    if(vector[ter2 * number] > vector[ter1 * number])
                    {
                        this.intercambio((ter2 * number), (ter1 * number));
                    }
                }
            }
        }

        // Pregunta 7: eliminar elementos repetidos "Purgar" del vector, debe quedar
        // solo elemento. *LA PURGAR DEBE SER EN EL MISMO VECTOR*
        public void elimElemRepet()
        {
            int ele, ter1, cont;
            ter1 = 1; cont = 0;
            this.ordenSinparametros();

            while(ter1 <= this.cantidad)
            {
                ele = vector[ter1];
                while(ter1 <= this.cantidad && vector[ter1] == ele)
                {
                    ter1++;
                }
                cont++;
                vector[cont] = ele;
            }
            this.cantidad = cont;
        }

        // Pregunta 8: Cargar Randomicamente 2 vectores "conjuntos" 
        // SIN ELEMENTOS REPETIDOS y realizar la union
        public void unioVectoresSinRepet(classVector vect2, ref classVector vectResult)
        {
            for(int ter1 = 1; ter1 <= this.cantidad; ter1++)
            {
                vectResult.cargarElexEle(vector[ter1]);
            }
            for(int ter2 = 1; ter2 <= vect2.cantidad; ter2++)
            {
                if (!(busquedaSecuencial(vect2.vector[ter2])))
                {
                    vectResult.cargarElexEle(vect2.vector[ter2]);
                }
            }
        }

        // Pregunta 9: Intecalar mayor y menor del rango a y b
        // Ejemplo v[4,7|8,6,4,9,3,5,9,3|4,6]
        //               a             b
        //         v[4,7|9,3,9,3,8,4,6,5|4,6]
        //               + - + - + - + -
        public void interMayMen(int ini, int fin)
        {
            bool cambio = true;
            for(int ter1 = ini; ter1 < fin; ter1++)
            {
                if(cambio == true)
                {
                    for(int ter2 = ter1 + 1; ter2 <= fin; ter2++)
                    {
                        if((elemMaximo(vector[ter2], ini, fin) > 0) && (!(elemMaximo(vector[ter1], ini, fin) > 0)) ||
                            (elemMaximo(vector[ter2], ini, fin) > 0) && (elemMaximo(vector[ter1], ini, fin) > 0) && (vector[ter2] > vector[ter1])||
                            (!(elemMaximo(vector[ter2], ini, fin) > 0)) && (!(elemMaximo(vector[ter1], ini, fin) > 0)) && (vector[ter2] < vector[ter1]))
                        {
                            this.intercambio(ter2, ter1);
                        }
                    }
                }
                else
                {
                    for (int ter2 = ter1 + 1; ter2 <= fin; ter2++)
                    {
                        if ((!(elemMaximo(vector[ter1], ini, fin) > 0)) && (elemMaximo(vector[ter2], ini, fin) > 0) ||
                            (!(elemMaximo(vector[ter2], ini, fin) > 0)) && (!(elemMaximo(vector[ter1], ini, fin) > 0)) && (vector[ter2] > vector[ter1]) ||
                            (elemMaximo(vector[ter2], ini, fin) > 0) && (elemMaximo(vector[ter1], ini, fin) > 0) && (vector[ter2] < vector[ter1]))
                        {
                            this.intercambio(ter2, ter1);
                        }
                    }
                }
                cambio = !cambio;
            }
        }
        // ************************************************
        // pregunta 9.1: funcion para dar la vuelta a un vector
        public void invertirVector()
        {
            for(int ter1 = 1; ter1 < this.cantidad; ter1++)
            {
                for(int ter2 = ter1 + 1; ter2 <= this.cantidad; ter2++)
                {
                    if(vector[ter2] > vector[ter1] || vector[ter2] < vector[ter1])
                    {
                        intercambio(ter2, ter1);
                    }
                }
            }
        }
        // ************************************************
        // Pregunta 10: Encontrar el elemento y su frecuencia del elemento que mas se repite
        // en el rango a y b 
        // (En el codigo incluimos los elementos mayores iguales, en caso que solo queramos mayores pero no iguale mayor, comentamos "max")
        public void elemMasFrecu(int ini, int fin, ref classVector vecEle, ref classVector vecFrecu)
        {
            vecEle.cantidad = 0;
            vecFrecu.cantidad = 0;

            int ele, ter, frecu, conta, max;
            ter = ini; max = 0; conta = 0;
            this.ordenParametros(ter, fin);
            while(ter <= fin)
            {
                frecu = 0;
                ele = vector[ter];
                while(ter <= fin && vector[ter] == ele)
                {
                    ter++; frecu++;
                }
                if((frecu > max) && (frecu != 1))
                {
                    max = frecu;
                    conta = 0;
                    conta++;
                    vecEle.vector[conta] = ele;
                    vecFrecu.vector[conta] = frecu;
                }
                else if((frecu >= max) && (frecu != 1))
                {
                    conta++;
                    vecEle.vector[conta] = ele;
                    vecFrecu.vector[conta] = frecu;
                }
            }
            vecEle.cantidad = conta;
            vecFrecu.cantidad = conta;
        }

        // La pregunta 11 es la mismaa que la pregunta 3
        // Pregunta 11: eliminar los elementos de posiciones multiplos de m
        public void elimPosMulti(int number)
        {
            int conta, ele;
            conta = 0; 
            for(int ter = 1; ter <= this.cantidad; ter++)
            {
                ele = ter % number;
                if (ele != 0)
                {
                    conta++;
                    vector[conta] = vector[ter];
                }
            }
            this.cantidad = conta;
        }

        // pregunta 12: Encontrar el numero de elementos diferentes del rango a y b
        public int elemDife(int ini, int fin)
        {
            int ele,conta, ter;
            conta = 0; ter = ini;
            this.ordenParametros(ter, fin);
            
            while(ter <= fin)
            {
                ele = vector[ter];
                while(ter <= fin && vector[ter] == ele)
                {
                    ter++;
                }
                conta++;
            }
            return conta;
        }
        // Pregunta 13: examen del 07/05/2024 
        // Encontrar la diferencia simetrica del vector A y vector B
        // A{2,5,3} y B{4,2,3,7} es VR{5,4,7}.
        public void diferenSimetri(classVector vec2, ref classVector vecRes)
        {
            vecRes.cantidad = 0;
            for(int ter = 1; ter <= this.cantidad; ter++)
            {
                if(vec2.busquedaSecuencial(vector[ter]) == false)
                {
                    vecRes.cargarElexEle(vector[ter]);
                }
            }
            for(int ter =1; ter <= vec2.cantidad; ter++)
            {
                if(busquedaSecuencial(vec2.vector[ter]) == false)
                {
                    vecRes.cargarElexEle(vec2.vector[ter]);
                }
            }
        }

        // Pregunta 14: Segmentar en fibonacci y no fibonacci
        // ordenados ASC y DESC respectivamente, el segmento (rango) a y b
        public void segmenFiboNoFibo(int ini, int fin)
        {
            for(int ter1 = ini; ter1 < fin; ter1++)
            {
                for(int ter2 = ter1 + 1; ter2 <= fin; ter2++)
                {
                    if((busquedaFibo(vector[ter2], ini, fin)) && (!(busquedaFibo(vector[ter1], ini, fin))) ||
                        (busquedaFibo(vector[ter2], ini, fin)) && (busquedaFibo(vector[ter1], ini, fin)) && (vector[ter2] < vector[ter1]) ||
                        (!(busquedaFibo(vector[ter2], ini, fin))) && (!(busquedaFibo(vector[ter1], ini, fin))) && (vector[ter2] > vector[ter1]))
                    {
                        this.intercambio(ter2, ter1);
                    }
                }
            }
        }
        // Pregunta 15: eliminar elementos del segundo vector, de acuerdo a los
        // elementos del primer vector
        public void elimElemVector(classVector vec2, ref classVector vecRes)
        {
            vecRes.cantidad = 0;
            for(int ter = 1; ter <= vec2.cantidad; ter++)
            {
                if (busquedaSecuencial(vec2.vector[ter]) == false)
                {
                    vecRes.cargarElexEle(vec2.vector[ter]);
                }
            }
        }

        // pregunta 17: Examen del 08/05/2024  
        // ordenar en sentido espiral inverso por parametros
        // v [3,4 |2,7,1,6,8,3,5|4,7]
        // vRes [3,4 |2,5,7,8,6,3,1|4,7]
        public void ordenEspiral(int ini, int fin)
        {
            int quantity = fin;
            int half = fin / 2;
            int idx = ini;
            int aux;
            this.ordenParametros(idx, fin);

            while(idx <= half)
            {
                aux = vector[idx];
                for(int idx2 = idx; idx2 < quantity; idx2++)
                {
                    vector[idx2] = vector[idx2 + 1];
                }
                vector[quantity] = aux;
                quantity--; idx++;
            }
        }

        // *************************************************************************************************
        // funciona correctamente
        // Pregunta 16: segmentar en primos y no primos, en el rango a y b
        // del vector (Primos en forma descendente y no primos de forma ascendente)
        // **************************************************
        public bool elemPrimo(int number)
        {
            int ele, conta; bool respu = false;
            int ter1 = 1; conta = 0;

            while(ter1 <= number)
            {
                ele = number % ter1;
                if (ele == 0)
                {
                    conta++;
                }
                ter1++;
            }
            if(conta == 2)
            {
                respu = true;
            }
            return respu;
        }
            
        // ****************************************************
       
        public void segmentarPrimNoPrim(int ini, int fin)
        {
            for(int ter1 = ini; ter1 < fin; ter1++)
            {
                for(int ter2 = ter1 + 1; ter2 <= fin; ter2++)
                {
                    if((elemPrimo(vector[ter2]) == true) && (!(elemPrimo(vector[ter1]) == true)) ||
                        (elemPrimo(vector[ter2]) == true) && (elemPrimo(vector[ter1]) == true) && (vector[ter2] > vector[ter1]) ||
                        (!(elemPrimo(vector[ter2]) == true)) && (!(elemPrimo(vector[ter1]) == true)) && (vector[ter2] < vector[ter1]))
                    {
                        this.intercambio(ter2, ter1);
                    }
                }
            }
        }
    }
}
