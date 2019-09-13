/*
 * Created by SharpDevelop.
 * User: THGEVER
 * Date: 30/08/2019
 * Time: 18:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ativLP
{
	/// <summary>
	/// Description of Animal.
	/// </summary>

    class Animal
    {
        public bool vivo { get; protected set; }
        public float idade { get; protected set; }
        public float peso { get; protected set; }
        public string som { get; protected set; }
        public float velocidade { get; protected set; }

        public void Nasce()
        {
            Vivo = true;
            Idade = 0;
        }

        public void Cresce(float tempoDeVida)
        {
            Idade += tempoDeVida;
        }

        public Animal Reproduz()
        {
            Animal filho = new Animal();
            filho.Nasce();
            return filho;
        }

        public void Morre()
        {
            Vivo = false;
        }

        public virtual void Locomove()
        {
            Console.WriteLine("Moveu-se a uma velocidade de " + Velocidade + "KM/h");
        }

        public virtual void Comunica()
        {
            Console.WriteLine(Som);
        }
    }
}