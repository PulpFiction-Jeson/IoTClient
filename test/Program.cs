// See https://aka.ms/new-console-template for more information
using IoTClient.Clients.Modbus;

Console.WriteLine("Hello, World!");
ModbusTcpClient modbusTcpClient = new ModbusTcpClient("127.0.0.1",502);
modbusTcpClient.Open();

var result= modbusTcpClient.ReadInt16("2");
Console.WriteLine(result.Value);
Console.ReadLine();
