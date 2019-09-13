/*
 * Created by SharpDevelop.
 * User: THGEVER
 * Date: 30/08/2019
 * Time: 21:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ativLP
{
	/// <summary>
	/// Description of Peixe.
	/// </summary>
	class Peixe : Animal
	{
		public override void Locomove ()
		{
			base.Locomove();
			Console.WriteLine("O peixe está nadando");
		}
	}
	
}
