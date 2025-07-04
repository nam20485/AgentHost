
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

using SharedLib.Models;

namespace AgentHost.ApiService.Services
{
    // Provier of inferemce models eg.e OpenAI, Google Vertex, Ollama, LM Studio, etc.
    public interface IModelProvider
    {
        string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public InferenceModel.List Models { get; }

        public class List : List<IModelProvider> { };

        public bool Connect();
        public bool LoadModel(string modelId);
        // Add methods to interact with the model provider, such as fetching models, etc.

    }
}
