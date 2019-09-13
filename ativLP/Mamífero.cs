/*
 * Created by SharpDevelop.
 * User: THGEVER
 * Date: 30/08/2019
 * Time: 21:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ativLP
{
	/// <summary>
	/// Description of Mamífero.
	/// </summary>
	class Mamífero : Animal
	{
		public override void Locomove()
		{
			base.Locomove();
			Console.WriteLine("O mamífero está andando ou voando");
		} 
		public override void Comunica()
		{
			base.Comunica();
			Console.WriteLine("*algum som que mamífeeros fazem*");
		}
		public void Amamenta()
		{
			Console.WriteLine("o mamífero está amamentando");
		}
		
	}
}
