using System.IO;
using System.Web.Http;

namespace  Aspose.Imaging.Cloud.Live.Demos.UI.Models
{
	///<Summary>
	/// AsposeImagingCloudBase class to have base methods
	///</Summary>

	public abstract class AsposeImagingCloudBase : ApiController
    {
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
