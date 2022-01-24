using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraindo_um_jogo_de_RPG_usando_orientação_a_objetos
{
    //Herança
    public class Magos : Heroi
    {
        //Método construtor Mago
        public Magos(string Nome, int Nivel, string TipoHeroi)
        {
            this.Nome = Nome;
            this.Nivel = Nivel;
            this.TipoHeroi = TipoHeroi;
        }
        public override string Ataque()
        {
            return this.Nome + " Lançou magia";
        }
        //Encapsulamento
        public string Ataque(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Nome + " Lançou Magia super poderosa com bonus de " + Bonus;
            }
            else
            {
                return this.Nome + " Lançou uma magia fraca com bonus de " + Bonus;
            }
        }
    }
}
