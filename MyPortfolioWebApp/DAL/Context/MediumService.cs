using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Xml;

public class MediumService
{
    private const string MediumRssUrl = "https://medium.com/feed/@melihh";

    public List<BlogPost> GetMediumPosts()
    {
        var blogPosts = new List<BlogPost>();

        using (var reader = XmlReader.Create(MediumRssUrl))
        {
            var feed = SyndicationFeed.Load(reader);
            if (feed != null)
            {
                blogPosts = feed.Items.Select(item => new BlogPost
                {
                    Title = item.Title.Text,
                    PublishedDate = item.PublishDate.DateTime,
                    Link = item.Links.FirstOrDefault()?.Uri.ToString(),
                    Summary = item.Summary?.Text
                }).ToList();
            }
        }

        return blogPosts;
    }
}

public class BlogPost
{
    public string Title { get; set; }
    public DateTime PublishedDate { get; set; }
    public string Link { get; set; }
    public string Summary { get; set; }
}
