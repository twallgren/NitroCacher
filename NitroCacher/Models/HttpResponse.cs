using System;
using System.Collections.Generic;

namespace NitroCacher.Models
{
    [Serializable]
    public class HttpResponse
    {
        public HttpResponse()
        {

        }
     
        public HttpResponse(List<Header> headers, string body, TimeSpan duration)
        {
            Headers = headers;
            Body = body;
            Duration = duration;
        }
        public List<Header> Headers { get; set; }
        public string Body { get; set; }
        public TimeSpan Duration { get; set; }
    }
}
