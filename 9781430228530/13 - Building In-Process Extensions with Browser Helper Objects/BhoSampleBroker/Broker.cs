using System;
using System.IO;
using System.IO.Pipes;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading;

namespace BhoSampleBroker
{
    public class Broker
    {

        static void Main(string[] args)
        {
            // Start a server listener on another thread
            Thread newRunServerThread = new Thread(RunServer);
            newRunServerThread.Start();

            // Loop indefinately
            while(true) {
                Thread.Sleep(1000);
            }
        }

        public static void RunServer()
        {
            // Add a placeholder for the named pipe server stream
            // object
            NamedPipeServerStream pipeServer = null;

            try
            {
                // Create a new pipe security object
                PipeSecurity pipeSecurity = new PipeSecurity();

                // Allow all system objects to access the pipe
                pipeSecurity.SetAccessRule(new PipeAccessRule(
                    new SecurityIdentifier(WellKnownSidType.WorldSid, null),
                    PipeAccessRights.ReadWrite, AccessControlType.Allow));

                // Create the named pipe called BhoPipeExample
                pipeServer = new NamedPipeServerStream(
                    "BhoPipeExample",
                    PipeDirection.InOut,
                    NamedPipeServerStream.MaxAllowedServerInstances,
                    PipeTransmissionMode.Message,
                    PipeOptions.None,
                    1024,
                    1024,
                    pipeSecurity,
                    HandleInheritability.None
                    );

                // Wait for the client to connect.
                Console.WriteLine("Waiting for the client's connection...");

                // Wait for a client connection
                pipeServer.WaitForConnection();

                // Start another server listener once this connection has
                // been used.  Make sure that it's on another thread
                Thread newRunServerThread = new Thread(RunServer);
                newRunServerThread.Start();

                // State that a client has connected
                Console.WriteLine("Client connected");


                // Read a line of input data from the pipe
                byte[] inputMessage = new byte[1024];
                pipeServer.Read(inputMessage, 0, inputMessage.Length);

                // Write the message (an url to the console
                Console.WriteLine("Visited url: \"{1}\"",
                    Encoding.Unicode.GetString(inputMessage).TrimEnd('\0'));

                // Wait for both the message to complete and for the
                // pipe to drain
                while (!pipeServer.IsMessageComplete);
                pipeServer.WaitForPipeDrain();

            }
            catch (Exception) { }
            finally
            {
                // Close this instance of the pipe server if it
                // still exists
                if (pipeServer != null)
                {
                    pipeServer.Close();
                    pipeServer = null;
                }
            }

        }

    }

}