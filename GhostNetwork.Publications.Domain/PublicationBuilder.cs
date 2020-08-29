using System;

namespace GhostNetwork.Publications.Domain
{
    public class PublicationBuilder
    {
        private readonly IHashTagsFetcher tagsFetcher;

        public PublicationBuilder(IHashTagsFetcher tagsFetcher)
        {
            this.tagsFetcher = tagsFetcher;
        }

        public Publication Build(string content)
        {
            return new Publication(string.Empty, content, DateTimeOffset.Now, tagsFetcher.Fetch(content));
        }
    }
}