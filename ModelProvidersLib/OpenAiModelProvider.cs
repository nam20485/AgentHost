using AgentHost.ApiService.Services;

using SharedLib.Models;

namespace ModelProvidersLib
{
    public class OpenAiModelProvider : IModelProvider
    {
        public string Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public InferenceModel.List Models => throw new NotImplementedException();

        public bool Connect()
        {
            throw new NotImplementedException();
        }

        public bool LoadModel(string modelId)
        {
            throw new NotImplementedException();
        }
    }
}
