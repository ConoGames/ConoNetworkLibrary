using System;
namespace ConoNetworkLibrary
{
	public class NetworkHandler : IConoNetworkHandler
	{
		/**
		@brief
		연결이 됬을 때 호출되는 함수.

		@details
		연결이 되면 이 함수를 호출해준다.

		@param ConoConnect connect\n
		연결 정보가 이곳에 담겨 옴.\n
		만약 null이 온다면 연결실패한 경우임.\n
		*/
		public void Connect(ConoConnect connect)
		{
			Console.WriteLine("connect");
			byte[] data = new byte[5000];
			int test = 4996;
			byte[] a= BitConverter.GetBytes(test);

			if (BitConverter.IsLittleEndian)
				Array.Reverse(a);

			Console.WriteLine(" " + + a.Length + " " + a[0] + " " + a[1] + " " + a[2] + " " + a[3]);

			data[0] = a[0];
			data[1] = a[1];
			data[2] = a[2];
			data[3] = a[3];
			data[4] = 1;

		connect.Send(data, 5000);
		}

		public void Disconnect(ConoConnect connect)
		{
			Console.WriteLine("Disconnect");
		}

		public void ReceiveData(ConoConnect connect, byte[] data, int dataLen)
		{
			Console.WriteLine("ReceiveData : " + dataLen + data.ToString());
		}
	}
}
