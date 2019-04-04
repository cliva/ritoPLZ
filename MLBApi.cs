using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace baseball{
    public class MLBApi
    {
        public MLBApi(){
            baseURL = "http://statsapi.mlb.com/";
            apiVersion = "v1/";
        }
        public string baseURL {get;}
        public string apiVersion { get; }
    }
}