using System;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using Common;


namespace server
{
	public class Server
	{
		public void Listen ()
		{
			var listener = new TcpListener (60000);

			listener.Start();


			var socket = listener.AcceptSocket();

			while(true)
			{
				byte[] buff = new byte[1000];

				socket.Receive(buff);

				var obj = buff.Deserialize<Message>();

				if(obj != null)
				{
					Console.WriteLine (string.Format("{0} ({1}): {2}",obj.From,obj.MessageTime.ToShortTimeString(),obj.MessageText));
				}

			}

		}

	}

}

