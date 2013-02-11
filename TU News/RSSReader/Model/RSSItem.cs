/*
Karan Thaker
karan.thaker@hotmail.com
 */

using System;
using System.Runtime.Serialization;

namespace RSSReader.Model
{
    /// <summary>
    /// Model for RSS item
    /// </summary>
    [DataContract(IsReference = true)]
    public class RSSItem
    {
        /// <summary>
        /// Property for item title
        /// </summary>
        [DataMember]
        public String Title { get; set; }

        /// <summary>
        /// Property for item summary
        /// </summary>
        [DataMember]
        public String Text { get; set; }

        /// <summary>
        /// Property for item URL
        /// </summary>
        [DataMember]
        public String Url { get; set; }

        /// <summary>
        /// Property for item datestamp
        /// </summary>
        [DataMember]
        public DateTimeOffset Datestamp { get; set; }

        /// <summary>
        /// Property for item feed information
        /// </summary>
        [DataMember]
        public RSSFeed Feed { get; set; }

        /// <summary>
        /// Image associated with the item
        /// </summary>
        /// [DataMember]
        public string Image;


        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="title">Title of the item</param>
        /// <param name="text">Summary of the item</param>
        /// <param name="url">URL of the item</param>
        /// <param name="date">Datestamp of the item</param>
        /// <param name="feed">Feed information</param>
        /// <param name="image">Image associated with the item</param>
        public RSSItem(String title, String text, String url, DateTimeOffset date, RSSFeed feed, string image)
        {
            Title = title;
            Text = text;
            Url = url;
            Datestamp = date;
            Feed = feed;
            Image = image;
        }
    }
}
