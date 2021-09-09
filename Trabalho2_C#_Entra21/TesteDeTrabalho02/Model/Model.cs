using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TesteDeTrabalho02
{
    class Model
    {
        /// <summary>
        /// Propriedade para poder acessar a lista durante o decorrer do codigo e fazer as comparações necessarias.
        /// </summary>
        public static List<string> ListaArmazenada { get; set; }
        private static Random ran = new Random();

        /// <summary>
        /// Essa Função gera a lista a ser entregue para o Controle, onde os botões receberão suas letras.
        /// assim como é enviada a lista para o ListaArmazenada assim que concluida.
        /// </summary>
        /// <returns></returns>
        public static List<string> ListaParaBotoes()
        {
            Random ran = new Random();
            List<string> lista = new List<string>();
            char[] let = "ADEFBCGIUHJVKLMOQNTPRSZ".ToCharArray();
            
            //btn a - d
            int aux = ran.Next(0, 2);
            lista.Add(Convert.ToString(let[aux]));
            //btn e - f
            aux = ran.Next(2, 4);
            lista.Add(Convert.ToString(let[aux]));
            //btn b - c
            aux = ran.Next(4, 6);
            lista.Add(Convert.ToString(let[aux]));
            //btn g - i - u
            aux = ran.Next(6, 9);
            lista.Add(Convert.ToString(let[aux]));
            //btn h - j - v
            aux = ran.Next(9, 12);
            lista.Add(Convert.ToString(let[aux]));
            //btn  k - l
            aux = ran.Next(12, 14);
            lista.Add(Convert.ToString(let[aux]));
            //btn m - o - q
            aux = ran.Next(14, 17);
            lista.Add(Convert.ToString(let[aux]));
            //btn n - t - p
            aux = ran.Next(17, 20);
            lista.Add(Convert.ToString(let[aux]));
            //btn r - s - z
            aux = ran.Next(20, 23);
            lista.Add(Convert.ToString(let[aux]));
            ListaArmazenada = lista;
            return lista;
        }

        /// <summary>
        /// Matriz criada com base na lista gerada para analizar futuramente a posição e cada letra da palavra inserida
        /// </summary>
        /// <param name="lista"></param>
        /// <returns></returns>
        public static int[][] AplicaEmMatriz(List<string> lista)
        {
            int[][] matriz = new int[3][]; 
            for (int i = 0; i < matriz.Length; i++) 
            {
                matriz[i] = new int[3];
            }
            int contador = 0;
            char aux;
            for (int i = 0; i < matriz.Length; i++) 
            {
                for (int j = 0; j < matriz[i].Length; j++) 
                {
                    aux = Convert.ToChar(lista[contador]);
                    matriz[i][j] = Convert.ToInt32(aux);
                    contador++;
                }
            }
            return matriz;

        }
        /// <summary>
        /// Essa função é onde de fato a posição das letras é analizada para ver se ela poderá ou não ser validada de acordo com sua posição
        /// </summary>
        /// <param name="palavra"></param>
        /// <param name="indiceAtual"></param>
        /// <param name="indiceSeguinte"></param>
        /// <returns></returns>
        public static bool ConferePosicao(string palavra, int indiceAtual, int indiceSeguinte) 
        {
            int[][] matriz = AplicaEmMatriz(ListaArmazenada);
            int a = 0, b = 0, c = 0, d = 0;
            int limite = palavra.Length - 1;
            if (limite >= indiceSeguinte) 
            {
                for (int i = 0; i < matriz.Length; i++)
                {
                    for (int j = 0; j < matriz.Length; j++)
                    {
                        if (palavra[indiceAtual] == Convert.ToChar(matriz[i][j]))
                        {
                            a = i;
                            b = j;
                        }
                    }
                }

                for (int i = 0; i < matriz.Length; i++)
                {
                    for (int j = 0; j < matriz.Length; j++)
                    {
                        if (palavra[indiceSeguinte] == Convert.ToChar(matriz[i][j]))
                        {
                            c = i;
                            d = j;
                        }
                    }
                }

            }
            if((a == c) && (b-- == d))
            {
                return true;
            }
            else if ((a == c) && (b++ == d))
            {
                return true;
            }
            else if ((a == 1 && b == 1) || (c == 1 && d == 1))
            {
                return true;
            }
            else if ((b == d) && ((a-- == c) || (a++ == c)))
            {

                return true;
            }
           
            else if (((a++ == c) || (a-- == c)) && ((b++ == d) || (b-- == d)))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        /// <summary>
        /// Essa Função tem como objetivo conferir se as letras digitadas pelo usuario de fato estão no caça-palavras
        /// </summary>
        /// <param name="palavra"></param>
        /// <returns></returns>
        public static bool LetraPermitida(string palavra)
        {
            bool condicao = false;
            if (palavra != "")
            {
                for (int i = 0; i < palavra.Length; i++)
                {
                    if (!ListaArmazenada.Contains(Convert.ToString(palavra[i])))
                    {
                        condicao = true;
                    }
                 
                }
            }
            return condicao;
        }
        /// <summary>
        /// A função Verifica conecta a analise da posição com a aplicação de pontos por palavras inseridas.
        /// </summary>
        /// <param name="palavra"></param>
        /// <returns></returns>
        public static bool Verificando(string palavra)
        {
            bool condicao = false;
            if (palavra != "")
            {
                for (int i = 0; i < palavra.Length; i++)
                {
                    if ((ConferePosicao(palavra, i, i + 1)) == false)
                    {
                        condicao = true;
                    }
                    else
                    {
                        GeraPontos(palavra);
                    }
                }
                
            }

            return condicao;
        }
        /// <summary>
        /// Faz a aplicação de pontos sendo 1 para cada duas letras
        /// </summary>
        /// <param name="palavra"></param>
        /// <returns></returns>
        public static int GeraPontos(string palavra) 
        {
            int pontos = palavra.Length / 2;
            return pontos;
        }
      

       /// <summary>
       /// ConfereLetras é a função responsavel por não deixar que a mesma letra se repita em uma palavra inserida
       /// /// </summary>
       /// <param name="palavra"></param>
       /// <returns></returns>
        public static bool ConfereLetras(string palavra)
        {
            bool cond = false;
            if (palavra != "/0")
            {
                for (int i = 0; i < palavra.Length; i++)
                {
                    if (i < palavra.Length - 1)
                    {
                        char letra = palavra[i];
                        if (palavra.IndexOf(letra, i + 1) > -1)
                        {
                            cond = true;
                            break;
                        }
                    }
                }
            }
            return cond;
        }

        /// <summary>
        /// Faz a busca da palavra inserida pelo usuario na lista para verificar se aquela é ou não uma palavra repetida.
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="palavra"></param>
        /// <returns></returns>
        public static bool BuscaEmLista(List<string> lista, string palavra) 
        {
            bool cond = false;
            foreach (var item in lista)
            {
                if (item == palavra)
                {
                    cond = true;
                }
            }
            return cond;
        }

        


    }

}