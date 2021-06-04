using System.Web.Mvc;
using Aspose.Imaging.Cloud.Sdk.Api;
using Aspose.Imaging.Cloud.Sdk.Model.Requests;

namespace Aspose.Imaging.Cloud.Live.Demos.UI.Controllers
{
	/// <summary>
	/// Common  API controller.
	/// </summary>

	public  class CommonController : BaseController
	{
		public override string Product => (string)RouteData.Values["product"];

		ImagingApi imagingApi = new ImagingApi(Config.Configuration.AppKey, Config.Configuration.AppSID, "https://api.aspose.cloud/");
		/// <summary>
		/// Sends back specified file from specified folder inside OutputDirectory.
		/// </summary>
		/// <param name="folder">Folder inside OutputDirectory.</param>
		/// <param name="file">File.</param>
		/// <returns>HTTP response with file.</returns>


		public FileResult DownloadFile(string file)
		{
			DownloadFileRequest dfr = new DownloadFileRequest(file);	
			return File(imagingApi.DownloadFile(dfr), "application/octet-stream", file);
		}
		
	}
}
