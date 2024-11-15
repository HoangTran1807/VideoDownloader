using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebEmbeding
{
    internal class APIHelper
    {
        // create a new instance of the APIHelper class
        private static APIHelper _instance;
        String APIURL = "";

        public static APIHelper Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new APIHelper();
                }
                return _instance;
            }
        }

        public APIHelper()
        {
        }

        public void SetAPIURL(string url)
        {
            APIURL = url;
        }

        public async Task<VideoFormat[]> GetVideoInfoAsync(HttpClient _httpClient, string url)
        {
            var requestData = new { url = url };
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(requestData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                var response = await _httpClient.PostAsync(APIURL + "/info", content);
                response.EnsureSuccessStatusCode();
                var jsonResponse = await response.Content.ReadAsStringAsync();

                // Deserialize to the wrapper class
                var videoInfoResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<VideoInfoResponse>(jsonResponse);
                return videoInfoResponse.formats;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
            return null;
        }

        public async Task DownloadVideoAsync(HttpClient _httpClient, string url, string output_dir, string format_id, string filename)
        {
            var requestBody = new
            {
                url = url,
                output = output_dir,
                format_id = format_id,
                filename = filename
            };

            var json = JsonConvert.SerializeObject(requestBody);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                var response = await _httpClient.PostAsync(APIURL + "/download", content);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                MessageBox.Show("Tải video hoàn tất!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }

        public async Task DownloadVideoAsync(HttpClient _httpClient, string url, string output_dir, string format_id, string filename, int start, int end)
        {
            if (start < 0 || end < 0 || start >= end)
            {
                MessageBox.Show("Invalid start or end time.");
                return;
            }
            var requestBody = new
            {
                url = url,
                output = output_dir,
                format_id = format_id,
                filename = filename,
                start = start,
                end = end,
            };

            var json = JsonConvert.SerializeObject(requestBody);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                var response = await _httpClient.PostAsync(APIURL + "/download", content);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                MessageBox.Show("Tải video hoàn tất!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }

        public async Task TestConnect(HttpClient _httpClient)
        {
            try
            {
                var response = await _httpClient.GetAsync(APIURL);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                MessageBox.Show(responseBody);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }


    }
}
