﻿namespace Firebase.Net.Http
{
    class HttpClientFactory
    {
        public static IHttpClientFacade Create()
        {
            IHttpClientFacade client = new HttpClientFacade();
            client = new HttpClientFirebaseErrorsDecorator(client);
            return client;
        }
    }
}