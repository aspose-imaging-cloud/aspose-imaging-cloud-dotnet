using System;
using System.IO;
using System.Web.Http;
using System.Threading.Tasks;
using System.IO.Compression;
using System.Drawing;
using System.Drawing.Imaging;
using Aspose.Imaging.Cloud.Sdk.Api;
using Aspose.Storage.Cloud.Sdk.Api;

namespace  Aspose.Imaging.Cloud.Live.Demos.UI.Models
{
	///<Summary>
	/// AsposeImagingCloudBase class to have base methods
	///</Summary>

	public abstract class AsposeImagingCloudBase : ApiController
    {
		//protected ImagingApi imgApi = new ImagingApi(Config.Configuration.AppKey, Config.Configuration.AppSID);
		protected StorageApi storageApi = new StorageApi(Config.Configuration.AppKey, Config.Configuration.AppSID);
		///<Summary>
		/// Get File extension
		///</Summary>
		protected string GetoutFileExtension(string fileName, string folderName)
        {
			string sourceFolder = Config.Configuration.WorkingDirectory + folderName;
            fileName = sourceFolder + "\\" + fileName;
            return Path.GetExtension(fileName);
        }      
		
    }
}
