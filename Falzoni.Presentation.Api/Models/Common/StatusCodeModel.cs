﻿using System.Net;

namespace Falzoni.Presentation.Api.Models.Common
{
    public class StatusCodeModel
    {
        public virtual HttpStatusCode Status { get; set; }

        public string Message { get; set; }

        public string[] ErrorsResult { get; set; }
    }
}