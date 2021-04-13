        public static byte[] Post(string uri, NameValueCollection pairs)
        {
            byte[] numArray;
            using (WebClient webClient = new WebClient())
            {
                numArray = webClient.UploadValues(uri, pairs);
            }
            return numArray;
        }


        public static void sendWebHook(string URL, string msg, string username)
        {
            Post(URL, new NameValueCollection()
            {
                { "username", username },
                { "content", msg }
            });
        }
        
        public void SendHook()
        {
             sendWebHook("discord webhook api link", string.Concat(new string[] { "Hello from WebHook: " + "Lol" + " Pass: " + "Random shit idc", }), "Ticket BOT");
        }
