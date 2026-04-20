// See https://aka.ms/new-console-template for more information
using Microsoft.Agents.AI;
using OpenAI;
using OpenAI.Chat;
using System.ClientModel;

// Conectarme al modelo local de foundry
ApiKeyCredential key = new ("notneeded");


// saber el puerto ejecutar foundry service status y buscar el puerto del
// modelo que se ha desplegado, en este caso es el 56803
OpenAIClient client = new (key, new OpenAIClientOptions
{
    Endpoint = new Uri("http://127.0.0.1:56803/v1")
});

// Nombre debe ser el mismo que el modelo que se ha desplegado en foundry, con la misma version 
// foundry model run phi-4-mini
// que generó el comando 🟢 Model phi-4-mini-instruct-openvino-gpu:2 loaded successfully
var chatClient = client.GetChatClient("phi-4-mini-instruct-openvino-gpu:2");

AIAgent agent = chatClient.AsAIAgent(
    instructions: """
                Actúa como un asistente de programación que ayuda a los usuarios a escribir código en C#. 
                Responde a las preguntas de los usuarios y proporciona ejemplos de código cuando sea necesario.
                - Si pregunta cosas que no sean relacionadas con la programación en C#, responde que no puedes ayudar con eso.
                """,
    name: "Asistente de Programación C#",
    description: "Un asistente de programación que ayuda a los usuarios a escribir código en C# y responde a preguntas relacionadas con la programación en C#."
);

Console.WriteLine("Escribe qué comando de c# o instrucciones debeas conocer?");
var userInput = Console.ReadLine();

var response = await agent.RunAsync(userInput);

Console.WriteLine(response);
