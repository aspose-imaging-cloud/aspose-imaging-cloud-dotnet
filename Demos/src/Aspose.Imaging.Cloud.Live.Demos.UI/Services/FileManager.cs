using System;
using System.IO;
using System.Diagnostics;
using Aspose.Imaging.Cloud.Live.Demos.UI.Models;

namespace Aspose.Imaging.Cloud.Live.Demos.UI.Services
{
    public static class FileManager 
    {
		
		public static FileUploadResult UploadFile( System.Web.HttpPostedFileBase postedFile)
		{
			FileUploadResult uploadResult = null;
			string fn = "";

			try
			{
				string folderName = Guid.NewGuid().ToString();

				// Prepare a path in which the result file will be
				string uploadPath = Config.Configuration.WorkingDirectory + "\\" + folderName;

				// Check directroy already exist or not
				if (!Directory.Exists(uploadPath))
					Directory.CreateDirectory(uploadPath);

				// Check if File is available.
				if (postedFile != null && postedFile.ContentLength > 0)
				{
					fn = System.IO.Path.GetFileName(postedFile.FileName);

					postedFile.SaveAs(uploadPath + "\\" + fn);
				}

				// Create response
				return new FileUploadResult
				{
					FileName = fn,
					FolderId = folderName
				};
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
			return uploadResult;
		}
		
		
       
		
	}
}
