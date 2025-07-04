using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AgentHost.ApiService.Services
{
    public class CompletionsService : ICompletionsService
    {
        private readonly IModelProvidersService _modelProvidersService;
        private readonly ILogger<CompletionsService> _logger; 

        public CompletionsService(IModelProvidersService modelProvidersService, ILogger<CompletionsService> logger)
        {
            _modelProvidersService = modelProvidersService;
            _logger = logger;
        }

    }
}
