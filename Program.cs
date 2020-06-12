using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace OOP_Abstrac
{
	class Program
	{
		public static void Main(string[] args)
		{
			Implementasi imple = new Implementasi();
			string nama = "Havid Pradipta Husada";
			string almt = "Pati";
                        string Umur = "19";
			string NIM = "2721";
			string Jurusan = "Informatika";

			imple.ShowKTP(nama, almt,umur);
			imple.ShowMHS(nama, NIM, Jurusan);

			Console.ReadKey(true);
		}
	}
}
