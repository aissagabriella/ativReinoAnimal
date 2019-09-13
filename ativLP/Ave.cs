/*
 * Created by SharpDevelop.
 * User: THGEVER
 * Date: 30/08/2019
 * Time: 20:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ativLP
{
	/// <summary>
	/// Description of Ave.
	/// </summary>

	class Ave : Animal
	{
		public override void Comunica ()
		{
			base.Comunica();
			Console.WriteLine ("hehehehehe");
		}
		public override void Locomove ()
		{
			base.Locomove();
			Console.WriteLine ("A ave está voando");
		}
		public void Migra()
		{
			Consle.WriteLine("É inverno, as aves estão migrando para o Sul");
		}
	}
	
}
