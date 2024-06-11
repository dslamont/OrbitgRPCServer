using Grpc.Core;
using OrbitgRPCServer;

namespace OrbitgRPCServer.Services
{
    public class TagsService : Tags.TagsBase
    {
        private readonly ILogger<TagsService> _logger;
        public TagsService(ILogger<TagsService> logger)
        {
            _logger = logger;
        }

        public override Task<TagResponse> GetTag(TagRequest request, ServerCallContext context)
        {
            return Task.FromResult(new TagResponse
            {
                TagNo = $"Tag {request.TagId}"
            });
        }
    }
}
