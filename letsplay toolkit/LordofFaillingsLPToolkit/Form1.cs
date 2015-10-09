//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Reflection;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Upload;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;

namespace LordofFaillingsLPToolkit
{
    public partial class startseite
    {
        internal startseite()
        {
            InitializeComponent();
        }

        private void startseite_Load(object sender, EventArgs e)
        {

        }

        private void SchließenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void EinstellungenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            einstellung.DefaultInstance.Show();

        }

        private void beschr_button_Click(object sender, EventArgs e)
        {
            frmGenerator.DefaultInstance.Show();
        }

        private void lpt_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comming Soon");
        }

        private static startseite _DefaultInstance;
        public static startseite DefaultInstance
        {
            get
            {
                if (_DefaultInstance == null)
                    _DefaultInstance = new startseite();

                return _DefaultInstance;
            }
        }

        private void ytlogin_Click(object sender, EventArgs e)
        {
        }


        internal class MyUploads
        {
            static void Main(string[] args)
            {
                Console.WriteLine("YouTube Data API: My Uploads");
                Console.WriteLine("============================");
                try
                {
                    new MyUploads().Run().Wait();
                }
                catch (AggregateException ex)
                {
                    foreach (var e in ex.InnerExceptions)
                    {
                        Console.WriteLine("Error: " + e.Message);
                    }
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
            private async Task Run()
            {
                UserCredential credential;
                using (var stream = new FileStream("client_secrets.json", FileMode.Open, FileAccess.Read))
                {
                    credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                        GoogleClientSecrets.Load(stream).Secrets,
                        // This OAuth 2.0 access scope allows for read-only access to the authenticated 
                        // user's account, but not other types of account access.
                        new[] { YouTubeService.Scope.YoutubeReadonly },
                        "user",
                        CancellationToken.None,
                        new FileDataStore(this.GetType().ToString())
                    );
                }
                var youtubeService = new YouTubeService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = this.GetType().ToString()
                });
                var channelsListRequest = youtubeService.Channels.List("contentDetails");
                channelsListRequest.Mine = true;
                // Retrieve the contentDetails part of the channel resource for the authenticated user's channel.
                var channelsListResponse = await channelsListRequest.ExecuteAsync();
                foreach (var channel in channelsListResponse.Items)
                {
                    // From the API response, extract the playlist ID that identifies the list
                    // of videos uploaded to the authenticated user's channel.
                    var uploadsListId = channel.ContentDetails.RelatedPlaylists.Uploads;
                    Console.WriteLine("Videos in list {0}", uploadsListId);
                    var nextPageToken = "";
                    while (nextPageToken != null)
                    {
                        var playlistItemsListRequest = youtubeService.PlaylistItems.List("snippet");
                        playlistItemsListRequest.PlaylistId = uploadsListId;
                        playlistItemsListRequest.MaxResults = 50;
                        playlistItemsListRequest.PageToken = nextPageToken;
                        // Retrieve the list of videos uploaded to the authenticated user's channel.
                        var playlistItemsListResponse = await playlistItemsListRequest.ExecuteAsync();
                        foreach (var playlistItem in playlistItemsListResponse.Items)
                        {
                            // Print information about each video.
                            Console.WriteLine("{0} ({1})", playlistItem.Snippet.Title, playlistItem.Snippet.ResourceId.VideoId);
                        }
                        nextPageToken = playlistItemsListResponse.NextPageToken;
                    }
                }
            }
        }
    }
}