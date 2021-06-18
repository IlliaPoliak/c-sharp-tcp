using System;
using System.Net.Sockets;
using System.Text;
 
namespace TcpClientApp
{
    class Program
    {
        private const int port = 82;
        private const string server = "10.36.26.167";
 
        static void Main(string[] args)
        {
            try
            {
                TcpClient client = new TcpClient();
                client.Connect(server, port);
                NetworkStream stream = client.GetStream();

                string response = "1";
                byte[] data = System.Text.Encoding.UTF8.GetBytes(response);
                stream.Write(data, 0, data.Length);
                // Console.WriteLine(response.ToString());

                System.Threading.Thread.Sleep(500);

                response = "2";
                data = System.Text.Encoding.UTF8.GetBytes(response);
                stream.Write(data, 0, data.Length);
                // Console.WriteLine(response.ToString());

                System.Threading.Thread.Sleep(500);

                response = "3";
                data = System.Text.Encoding.UTF8.GetBytes(response);
                stream.Write(data, 0, data.Length);
                // Console.WriteLine(response.ToString());

                System.Threading.Thread.Sleep(500);

                response = "4";
                data = System.Text.Encoding.UTF8.GetBytes(response);
                stream.Write(data, 0, data.Length);
                Console.WriteLine(response.ToString());
 
                // Закрываем потоки
                stream.Close();
                client.Close();
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}", e.Message);
            }
 
            Console.WriteLine("Запрос завершен...");
            Console.Read();
        }
    }
}