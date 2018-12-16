using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Notificator
{
    /// <summary>
    /// A class provides a way to send messages via Pushover.net API
    /// </summary>
    public class PushoverService
    {
        private const string _requestURL = "https://api.pushover.net/1/messages.json";
        private string _token;

        public PushoverService(string appToken)
        {
            _token = appToken;
        }

        /// <summary>
        /// Sends a message to a specified user
        /// </summary>
        /// <param name="messageText"></param>
        public void SendMessage(string userKey, string messageText)
        {
            var objectToSend = new { token = _token, user = userKey, message = messageText };

            var client = new HttpClient();
            client.PostAsync(_requestURL, new JsonContent(objectToSend));
        }
    }

}
