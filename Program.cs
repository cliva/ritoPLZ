using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace baseball
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MLBApi mlbapi = new MLBApi();
            //var divisionsJSON = mlbapi.DownloadDivisions();
            //Console.WriteLine(divisionsJSON);
            Task t = new Task(DownloadDivisions2);
            t.Start();
            
            
            Schedule schedule = new Schedule();
            
            Console.ReadLine();
        }

        static async void DownloadDivisions2() {
            string page = "http://statsapi.mlb.com/api/v1/schedule/?sportId=1";
            using (HttpClient client = new HttpClient()){
                using (HttpResponseMessage response = await client.GetAsync(page)){
                    using (HttpContent content = response.Content){
                        string result = await content.ReadAsStringAsync();
                        if (result != null && result.Length >= 50)
                            using(StreamWriter sw = new StreamWriter("/users/jackbruzan/desktop/baseball/schedule.json")){
                                sw.WriteLine(result);
                            }
                    }
                }
            }
        }
    }
}
