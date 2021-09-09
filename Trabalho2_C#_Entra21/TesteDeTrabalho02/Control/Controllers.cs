using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteDeTrabalho02
{
    class Controllers
    {



        /// <summary>
        /// Quando o View solicitar as letras para aplicar nos botões, o controle chamará a função:
        /// ListaParaBotões, que como o proprio nome diz, retornará a lista que será aplicada nos botões do View.
        ///
        /// </summary>
        /// <returns></returns>
        public static List<string> ListaBotoes()
        {
            List<string> lista = Model.ListaParaBotoes();            
            return lista;

        }

        public static bool ConferindoLetras(string palavra) // verifica se a palavra inserida tem letras repetidas
        {
            return Model.ConfereLetras(palavra);
        }


        public static bool BuscandoNaLista(List<string> lista, string palavra) // chama a função que busca a palavra inserida na lista de palavras já armazenadas
        {
            return Model.BuscaEmLista(lista, palavra);
        }


        public static bool LetrasPermitidas(string palavra) // chama a função que confere se as letras inseridas estão em posições vizinhas.
        {
            return Model.Verificando(palavra);
        }

        public static bool LetraExiste(string palavra) // chama uma função para conferir se as letras digitadas estão no caça-palavras
        {
            return Model.LetraPermitida(palavra);
        }



        public static int GerandoPonto(string palavra) // chama a função que gera os pontos por palavras
        {
            return Model.GeraPontos(palavra);
        }



    }
}