using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AgentHost.ApiService.Services
{
    public interface IModelProvidersService
    {
        public IModelProvider.List ModelProviders { get; set; }
        public IModelProvider CurrentModelProvider { get; set; }
    }
}
