﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Mastodon.Common;
using Mastodon.Model;

namespace Mastodon.Api
{
    public partial class Media
    {
        /// <summary>
        /// Uploading a media attachment
        /// </summary>
        /// <param name="domain">Mastodon instance domain</param>
        /// <param name="token">AccessToken</param>
        /// <param name="file">Media to be uploaded</param>
        /// <returns>Returns an <see cref="AttachmentModel"/> that can be used when creating a status</returns>
        public static async Task<AttachmentModel> Uploading(string domain, string token, byte[] file)
        {
            return await HttpHelper.PostAsync<AttachmentModel, StreamContent>($"{HttpHelper.HTTPS}{domain}{Constants.MediaUploading}", token, new []
            {
                (nameof(file), new StreamContent(new MemoryStream(file)))
            });
        }
    }
}