using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraindo_um_jogo_de_RPG_usando_orientação_a_objetos
{
    internal class Guerreiro : Heroi
    {
        public Guerreiro(string Nome, int Nivel, string TipoHeroi)
        {
            this.Nome = Nome;
            this.Nivel = Nivel;
            this.TipoHeroi = TipoHeroi;
        }
    }
}
