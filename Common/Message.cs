using System;

namespace Common
{
	[Serializable]
	public class Message
	{
		public Message (string mText, string from, string to)
		{
			this.MessageText = mText;
			this.MessageTime = DateTime.Now;
			this.From = from;
			this.To = to;
		}

		public string MessageText{get;set;}

		public DateTime MessageTime {get; set;}

		public string From {get; set;}

		public string To {get; set;}

	}
}

