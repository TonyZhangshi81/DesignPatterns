using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DesignPatterns.PrototypePattern.Util
{
	/// <summary>
	/// 
	/// </summary>
	public class SerializeHelper
	{
		/// <summary>
		/// 序列化
		/// </summary>
		/// <param name="target"></param>
		/// <returns></returns>
		public static string Serializable(object target)
		{
			using (MemoryStream stream = new MemoryStream())
			{
				new BinaryFormatter().Serialize(stream, target);
				return Convert.ToBase64String(stream.ToArray());
			}
		}
		/// <summary>
		/// 反序列化
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="target"></param>
		/// <returns></returns>
		public static T Derializable<T>(string target)
		{
			byte[] targetArray = Convert.FromBase64String(target);
			using (MemoryStream stream = new MemoryStream(targetArray))
			{
				return (T)(new BinaryFormatter().Deserialize(stream));
			}
		}
		/// <summary>
		/// 合并反序列化与序列化
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="t"></param>
		/// <returns></returns>
		public static T DeepClone<T>(T t)
		{
			return Derializable<T>(Serializable(t));
		}
	}
}
