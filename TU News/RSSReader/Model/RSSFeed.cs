﻿/*
Karan Thaker
karan.thaker@hotmail.com
 */

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ComponentModel;

namespace RSSReader.Model
{
    /// <summary>
    /// A single RSS feed
    /// </summary>
    [DataContract(IsReference = true)]
    public class RSSFeed : INotifyPropertyChanged
    {
        /// <summary>
        /// Implementation of PropertyChanged event declared in INotifyPropertyChanged
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Property for URL of the feed
        /// </summary>
        [DataMember]
        public String URL { get; set; }

        /// <summary>
        /// Class member for image URL of the feed
        /// </summary>
        private String imageURL;

        /// <summary>
        /// Property for image URL of the feed
        /// </summary>
        [DataMember]
        public String ImageURL 
        {
            get
            {
                return imageURL;
            }
            set
            {
                if (imageURL != value)
                {
                    imageURL = value;
                    OnPropertyChanged("ImageURL");
                }
            }
        }

        /// <summary>
        /// The title of the feed
        /// </summary>
        [DataMember]
        public String Title { get; set; }

        /// <summary>
        /// A list of items for this feed
        /// </summary>
        [DataMember]
        public List<RSSItem> Items { get; set; }

        /// <summary>
        /// The timestamp this feed was last refreshed
        /// Used when checking if cache can be used or
        /// should the feed be refreshed
        /// </summary>
        [DataMember]
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Whether the feed is visible on the RSSPage or not
        /// </summary>
        [DataMember]
        public Boolean IsVisible { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public RSSFeed()
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="url">URL of the feed</param>
        /// <param name="title">Title of the feed</param>
        public RSSFeed(String url, String title)
        {
            this.URL = url;
            this.Title = title;
            this.Items = new List<RSSItem>();
        }

        /// <summary>
        /// Helper method for PropertyChanged event
        /// </summary>
        /// <param name="changed">Name of the property that has changed</param>
        protected virtual void OnPropertyChanged(String changed)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(changed));
            }
        }
    }
}
