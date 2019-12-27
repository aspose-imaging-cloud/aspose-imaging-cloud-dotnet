//-----------------------------------------------------------------------------------------------------------
// <copyright file="ImagingApiTester.cs" company="Aspose Pty Ltd." author="Maksym Shnurenok" date="05.07.2019 16:50:26">
//    Copyright (c) 2001-2019 Aspose Pty Ltd.
// </copyright>
//-----------------------------------------------------------------------------------------------------------

using System.IO;

namespace Aspose.Imaging.Cloud.Sdk.Test.Api
{
    using Aspose.Imaging.Cloud.Sdk.Test.Base;

    using NUnit.Framework;

    /// <summary>
    /// Intermediate worker class for Imaging tests
    /// </summary>
    /// <seealso cref="ApiTester" />
    [Category("Imaging")]
    public abstract class ImagingApiTester : ApiTester
    {
        protected void AssertImageFormatsEqual(Stream resultStream, string formatExtension)
        {
            Assert.NotNull(resultStream);
            resultStream.Position = 0;
            Assert.IsTrue(ImageFormatsEqual(Image.Load(resultStream).FileFormat, formatExtension));
        }

        private bool ImageFormatsEqual(FileFormat asposeImageFormat, string formatExtension)
        {
            formatExtension = NormalizeImageFormatExtension(formatExtension);

            if (string.Equals(asposeImageFormat.ToString(), formatExtension, System.StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }

            if (asposeImageFormat == FileFormat.Jpeg && formatExtension == "jpg")
            {
                return true;
            }

            return false;
        }

        private string NormalizeImageFormatExtension(string formatExtension)
        {
            if (formatExtension.StartsWith("."))
            {
                formatExtension = formatExtension.Substring(1);
            }

            return formatExtension.ToLower();
        }
    }
}
