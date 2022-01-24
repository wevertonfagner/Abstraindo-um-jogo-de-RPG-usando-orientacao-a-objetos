using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraindo_um_jogo_de_RPG_usando_orientação_a_objetos
{
    public class Heroi
    { 
        //método construtor
        public Heroi(string Nome, int Nivel, string TipoHeroi)
        {
            this.Nome = Nome;
            this.Nivel = Nivel;
            this.TipoHeroi = TipoHeroi;
        }
        
        public Heroi()
        {

        }

        public string Nome;
        public int Nivel;
        public string TipoHeroi;

        public override string ToString()
        {
            return this.Nome + " " + this.Nivel + " " + this.TipoHeroi;
        }

        public virtual string Ataque()
        {
            return this.Nome + " Atacou com sua espada";
        }
        public string Ataque(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Nome + " Atacou forte com sua espada com bonus de " + Bonus;
            }
            else
            {
                return this.Nome + " Atacou fraco com sua espada com bonus de " + Bonus;
            }
        }
    }
}
