using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Linq;
using System.Net.NetworkInformation;
public class UDPClient : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        UDPTest();
    }
    
    void UDPTest() {
        UdpClient client = new UdpClient(5600);

        try {
            client.Connect("127.0.0.1", 5500); 
            // server used on my own computer, local host

           UdpSend(client);
           UdpReceive(client);
           client.Close();
           // Closes the client
        }
        catch (Exception e) {
            Debug.Log("Exception thrown: " + e.Message);
        }
    }
    void UdpSend(UdpClient client) {
        byte[] sendBytes = Encoding.ASCII.GetBytes("Hello from the client");
        // converts the string to a byte array

        client.Send(sendBytes, sendBytes.Length);
        // client sends a message
    }
    void UdpReceive(UdpClient client) {
            IPEndPoint remoteEndPoint = new IPEndPoint(IPAddress.Any, 0);
            // Any indicates that Socket instance must listen for client activity 
            // on all network interfaces.

            byte[] receiveBytes = client.Receive(ref remoteEndPoint); 
            // Receive blocks execution until it receives a message
            // remoteEndPoint is the local host

            string receivedString = Encoding.ASCII.GetString(receiveBytes);

            print("Message received from the server \n" + receivedString);
    }

}
