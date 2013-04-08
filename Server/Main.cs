using System;

namespace Server
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Server server = new Server();
			server.Listen();
		}
	}
}
