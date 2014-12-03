using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;
using System.Configuration;
using System.Diagnostics;

namespace SimpleAzureCdn
{
    public partial class simpleAzureCdnForm : Form
    {
        public simpleAzureCdnForm()
        {
            InitializeComponent();
        }

        static CloudStorageAccount storageAccount;

        private void Form1_Load(object sender, EventArgs e)
        {
            //gets connectionstring from app.config
            storageAccount = CloudStorageAccount.Parse(ConfigurationManager.AppSettings["StorageConnectionString"]);
        }

        private void do_button_Click(object sender, EventArgs e)
        {
            //simple dialog box to select a file
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {

                try
                {

                    //create client to work with blobs
                    CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();


                    //already created container via azure management portal, set container reference
                    CloudBlobContainer container = blobClient.GetContainerReference("SomeContainer");

                    
                    using (var fileStream = System.IO.File.OpenRead(openFileDialog1.FileName))
                    {
                        //set distination (will create or overwrite existing blob)
                        CloudBlockBlob blockBlob = container.GetBlockBlobReference(openFileDialog1.SafeFileName);

                        //upload from stream
                        blockBlob.UploadFromStream(fileStream);
                    } 

                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
            
        }
    }
}
