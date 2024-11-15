using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;
using System.Security.Policy;
using System.Diagnostics;


namespace WebEmbeding
{
    public partial class VideoDownloader : Form
    {
        #region Attributes
        private readonly HttpClient _httpClient;
        private string APIURL;
        private APIHelper apiHelper;

        #endregion

        public VideoDownloader()
        {
            InitializeComponent();
            _httpClient = new HttpClient();
            APIURL = "http://127.0.0.1:5000";
            apiHelper = APIHelper.Instance;
            apiHelper.SetAPIURL(APIURL);

        }



        #region Events
        private void CoreWebView2_HistoryChanged(object sender, object e)
        {
            cbx_format.DataSource = null;
        }


        private async void Form1_Load(object sender, EventArgs e)
        {
            
            //await apiHelper.TestConnect(_httpClient);
            // Khởi tạo WebView2
            await webView21.EnsureCoreWebView2Async();
            // Load config
            loadConfig();
            // Đặt URL cần tải
            webView21.CoreWebView2.Navigate("https://www.youtube.com");
            webView21.CoreWebView2.HistoryChanged += CoreWebView2_HistoryChanged;
        }

        private void VideoDownloader_FormClosing(object sender, FormClosingEventArgs e)
        {
            //StopPythonScript();
            saveConfig();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate(txt_url.Text);
        }

        private void btn_prePage_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.GoBack();
        }

        private void btn_nextPage_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.GoForward();
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            check_format();
        }

        private void txt_start_Validated(object sender, EventArgs e)
        {
            string time = convert_time(txt_start.Text);
            txt_start.Text = time;
        }

        private void txt_end_Validated(object sender, EventArgs e)
        {
            string time = convert_time(txt_end.Text);
            txt_end.Text = time;
        }


        private async void btn_dowload_Click(object sender, EventArgs e)
        {
            if (cbx_format.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a video format.");
                return;
            }
            string _output_dir = txt_save_dir.Text;
            if (string.IsNullOrWhiteSpace(_output_dir))
            {
                MessageBox.Show("Please select a output directory.");
                return;
            }
            string currenturl = webView21.CoreWebView2.Source;
            string output_dir = _output_dir;
            string format_id = cbx_format.SelectedValue.ToString();
            string filename = txt_filename.Text;

            await apiHelper.DownloadVideoAsync(_httpClient, currenturl, output_dir, format_id, filename);
        }


        private async void btn_downloadSegment_Click(object sender, EventArgs e)
        {
            if (cbx_format.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a video format.");
                return;
            }
            string _output_dir = txt_save_dir.Text;
            if (string.IsNullOrWhiteSpace(_output_dir))
            {
                MessageBox.Show("Please select a output directory.");
                return;
            }
            int start = Convert.ToInt32(txt_start.Text);
            int end = Convert.ToInt32(txt_end.Text);
            string currenturl = webView21.CoreWebView2.Source;
            string output_dir = _output_dir;
            string format_id = cbx_format.SelectedValue.ToString();
            string filename = txt_filename.Text;

            await apiHelper.DownloadVideoAsync(_httpClient, currenturl, output_dir, format_id, filename, start, end);
        }

        private void txt_url_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                // Enter key is pressed navigate to the URL to txt.url
                webView21.CoreWebView2.Navigate(txt_url.Text);
            }
        }



        private void txt_save_dir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txt_save_dir.Text = folderBrowserDialog.SelectedPath;
            }

        }
        #endregion


        #region Methods


        private async void check_format()
        {
            string currenturl = webView21.CoreWebView2.Source;
            if (string.IsNullOrWhiteSpace(currenturl))
            {
                MessageBox.Show("Please enter a valid YouTube URL.");
                return;
            }

            // Gửi yêu cầu POST tới API
            try
            {
                var formats = await apiHelper.GetVideoInfoAsync(_httpClient, currenturl);
                if (formats != null)
                {
                    cbx_format.DataSource = formats;
                    cbx_format.DisplayMember = "Resolution";
                    cbx_format.ValueMember = "format_id";
                    cbx_format.SelectedIndex = 0;

                }
                else
                {
                    //MessageBox.Show("No video formats found or error occurred.");
                    Console.WriteLine("No video formats found or error occurred.");
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Error: {ex.Message}");
                Console.WriteLine(ex.Message);
            }
        }




        private string convert_time(string _time)
        {
            if (string.IsNullOrWhiteSpace(_time))
            {
                return "0";
            }
            // convert time hh:mm:ss to seconds
            string[] time = _time.Split(':');
            int hours = 0;
            int minutes = 0;
            int seconds = 0;

            if (time.Length == 3)
            {
                hours = Convert.ToInt32(time[0]);
                minutes = Convert.ToInt32(time[1]);
                seconds = Convert.ToInt32(time[2]);
            }
            else if (time.Length == 2)
            {
                minutes = Convert.ToInt32(time[0]);
                seconds = Convert.ToInt32(time[1]);
            }
            else if (time.Length == 1)
            {
                seconds = Convert.ToInt32(time[0]);
            }
            else
            {
                MessageBox.Show("Invalid time format.");
            }

            int total_seconds = hours * 3600 + minutes * 60 + seconds;
            return total_seconds.ToString();
        }



        #endregion

        private void loadConfig()
        {
            // Load config from settings file
            string save_dir = Properties.Settings.Default.save_dir;
            if (!string.IsNullOrWhiteSpace(save_dir))
            {
                txt_save_dir.Text = save_dir;
            }

        }

        private void saveConfig()
        {
            // Save config to settings file
            Properties.Settings.Default.save_dir = txt_save_dir.Text;
            Properties.Settings.Default.Save();

        }

       
    }

    public class VideoFormat
    {
        public string format_id { get; set; }
        public string Ext { get; set; }
        public string Resolution { get; set; }
        public string format_note { get; set; }

    }

    public class VideoInfoResponse
    {
        public VideoFormat[] formats { get; set; }
    }
}
