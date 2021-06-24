using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

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

            byte[] sendBytes = Encoding.ASCII.GetBytes("Hello from the client");
            // converts the string to a byte array

            client.Send(sendBytes, sendBytes.Length);

            IPEndPoint remoteEndPoint = new IPEndPoint(IPAddress.Any, 0);

            byte[] receiveBytes = client.Receive(ref remoteEndPoint); // remoteEndPoint is the local host

            string receivedString = Encoding.ASCII.GetString(receiveBytes);

            print("Message received from the server \n" + receivedString);
        }
        catch (Exception e){
            print("Exception thrown " + e.Message);
        }
    }

}
