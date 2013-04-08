using System;

namespace server
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
