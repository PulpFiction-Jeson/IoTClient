// See https://aka.ms/new-console-template for more information
using IoTClient.Clients.Modbus;
using IoTClient.Clients.PLC;
using IoTClient.Common.Enums;

Console.WriteLine("Hello, World!");
SiemensClient modbusTcpClient = new SiemensClient(SiemensVersion.S7_200Smart,"127.0.0.1",102);
modbusTcpClient.Open();
modbusTcpClient.Write("VW1530", "1无23");

var result= modbusTcpClient.ReadString("VW1530");
Console.WriteLine(result.Value);
Console.ReadLine();
