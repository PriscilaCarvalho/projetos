using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedraPapelTesoura
{
    class Player
    {
        
        public enum Jogada
        {
            P = 'P',
            R = 'R',            
            S = 'S'
        }

        string nome;
        Jogada jogada;

        public string GetNome (){
            return nome;
        }

        public string SetNome(string nome) {
            this.nome = nome;
            return nome;
        }

        public Jogada GetJogada()
        {
            return jogada;
        }

        public Jogada SetJogada(Jogada jogada)
        {
            this.jogada = jogada;
            return jogada;
        }

    }
}
