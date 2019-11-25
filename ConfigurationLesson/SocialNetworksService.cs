using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationLesson
{
    /// <summary>
    /// Класс для работы с Google и Twilio
    /// </summary>
    public class SocialNetworksService
    {
        private readonly string googleToken;
        private readonly string twilioToken;

        public SocialNetworksService(IOptions<SocialMediaOptions> options)
        {
            googleToken = options.Value.GoogleToken;
            twilioToken = options.Value.TwilioToken;
        }

        public void ToDo()
        {
            
        }
    }
}
