using System;

namespace BDSA2019.Lecture07.Models.Facade
{
    public interface IPublisher
    {
        void PublishOnline(Article article);
    }

    public class Publisher : IPublisher
    {
        public void PublishOnline(Article article)
        {
            Console.WriteLine($"Published {article.Title} by {article.Author} online");
        }
    }
}
