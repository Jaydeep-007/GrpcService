
using Grpc.Net.Client;
using GrpcService;
using GrpcService.Protos;

//var message = new HelloRequest { Name = "Jaydeep" };

//var channel = GrpcChannel.ForAddress("http://localhost:5045");
//var client = new Greeter.GreeterClient(channel);

//var srerveReply = await client.SayHelloAsync(message);

//Console.WriteLine(srerveReply.Message);

//Console.ReadLine();

var channel = GrpcChannel.ForAddress("http://localhost:5045");
var client = new Product.ProductClient(channel);

var product = new GetProductDetail { ProductId = 3 };

var serverReply = await client.GetProductsInformationAsync(product);

Console.WriteLine($"{serverReply.ProductName} | {serverReply.ProductDescription} | {serverReply.ProductPrice} | {serverReply.ProductStock}");

Console.ReadLine();
