﻿namespace Liga.Api
{
    public class ResponseBase
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public object Content { get; set; }
    }
}
