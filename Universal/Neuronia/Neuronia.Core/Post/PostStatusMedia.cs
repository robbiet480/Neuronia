﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuronia.Core.Post
{
    public class PostStatusMedia:PostStatusBase
    {
        private PostMedia media;

        public PostMedia Media
        {
            get { return media; }
            set { media = value; ModelPropertyChanged("Media"); }
        }
        public PostStatusMedia(string status,PostMedia media)
            :base(status)
        {
            this.media = new PostMedia();
            this.media.Data = new byte[media.Data.Count()];
            media.Data.CopyTo(this.media.Data, 0);
            this.media.FileName = media.FileName;
        }
    }
}
