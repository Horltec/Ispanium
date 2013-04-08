using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.Serialization;

namespace Common
{
	public static class ExtentionSerializer
	{
		public static byte[] Serialize<T>(this T obj)
			where T : class
		{
			if(obj == null)
			{
				return null;
			}
			else
			{
				BinaryFormatter bf = new BinaryFormatter();
				MemoryStream ms = new MemoryStream();

				bf.Serialize(ms, obj);

				return ms.ToArray();
			}
		}

		public static T Deserialize<T>(this byte[] array)
			where T : class
		{
			if(array == null)
			{
				return null;
			}
			else
			{
				MemoryStream ms = new MemoryStream(array);
				BinaryFormatter bf = new BinaryFormatter();
				ms.Position = 0;

				try
				{				
					var result = bf.Deserialize(ms);
					return (T)result;
				}
				catch(SerializationException)
				{
					return null;
				}
			}
		}


	}
}

