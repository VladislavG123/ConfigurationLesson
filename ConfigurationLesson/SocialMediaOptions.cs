using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationLesson
{
    public class SocialMediaOptions
    {
        public string GoogleToken { get; set; }
        public string TwilioToken { get; set; }
    }
}
