using IdentityServer4.Models;
using System;

namespace TokenServiceApi.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
        public ErrorMessage Error { get; set; }
    }
}