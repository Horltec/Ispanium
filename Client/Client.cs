using System;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using Common;

namespace Client
{
	public class Client
	{
		public void Connect ()
		{
			TcpClient client = new TcpClient ("localhost", 60000);

			var stream = client.GetStream ();

			while (true) 
			{
				Console.Write ("> ");
				var text = Console.ReadLine();
				var m = new Message (text,"Vasya", "Sergey");
				var mes = m.Serialize ();
				stream.Write (mes, 0, mes.Length);
			}
		}

	}
}

