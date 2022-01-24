using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraindo_um_jogo_de_RPG_usando_orientação_a_objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Heroi guerreiro = new Guerreiro("Arus", 42, "Guerreiro");
            Magos magos  = new Magos("Jennica", 23, "Magia");
            Ninja ninja = new Ninja("Wedge", 30, "Ninja");

            Console.WriteLine(magos.Ataque(65));
            Console.WriteLine(guerreiro.Ataque(1));
            Console.WriteLine(ninja.Ataque(9));
        }
    }
}
