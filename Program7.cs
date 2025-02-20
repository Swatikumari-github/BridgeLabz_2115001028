using System;
using System.IO;
using System.IO.Pipes;
using System.Text;
using System.Threading;

namespace Streams
{
   

    class PipeCommunication
    {
        static void Main()
        {
            using (AnonymousPipeServerStream serverPipe = new AnonymousPipeServerStream(PipeDirection.Out, HandleInheritability.Inheritable))
            using (AnonymousPipeClientStream clientPipe = new AnonymousPipeClientStream(PipeDirection.In, serverPipe.GetClientHandleAsString()))
            {
                Thread writerThread = new Thread(() => WriteData(serverPipe));
                Thread readerThread = new Thread(() => ReadData(clientPipe));

                writerThread.Start();
                readerThread.Start();

                writerThread.Join();
                readerThread.Join();
            }
        }

        static void WriteData(PipeStream serverPipe)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(serverPipe, Encoding.UTF8, 1024, leaveOpen: true))
                {
                    streamWriter.AutoFlush = true;
                    for (int counter = 1; counter <= 5; counter++)
                    {
                        string dataMessage = $"Message {counter}";
                        Console.WriteLine($"Writing: {dataMessage}");
                        streamWriter.WriteLine(dataMessage);
                        Thread.Sleep(500);
                    }
                }
            }
            catch (IOException exception)
            {
                Console.WriteLine("Write error: " + exception.Message);
            }
        }

        static void ReadData(PipeStream clientPipe)
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(clientPipe, Encoding.UTF8))
                {
                    string receivedMessage;
                    while ((receivedMessage = streamReader.ReadLine()) != null)
                    {
                        Console.WriteLine($"Read: {receivedMessage}");
                    }
                }
            }
            catch (IOException exception)
            {
                Console.WriteLine("Read error: " + exception.Message);
            }
        }
    }

}
