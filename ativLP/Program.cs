/*
 * Created by SharpDevelop.
 * User: THGEVER
 * Date: 30/08/2019
 * Time: 18:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ativLP
{
	class Program
	{
		static void Main (string[] args)
		{
			Humano ross = new Humano(25, "WE WERE ON A BREAK", 50, 10, 11111111111 );
			ross.Reproduz();
		
		
	}
		static void Main (string[] args)
		{
			Pato patinhofeio = new Pato();
			patinhofeio.Nasce();
		}
		
		static void Main (string[] args)
		{
			Tubarão babyshark = new Tubarão();
			babyshark.Morre();
		}
		
		static void Main (string[] args)
		{
			Peixe nemo = new Peixe( );
			nemo.Locomove();
		}
		
		static void Main (string[] args)
		{
		    Cachorro belinha = new Cachorro( );
		    belinha.Comunica ();
		}
		
		
		
		
		

	
		
}