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

        private bool ImageFormatsEqual(FileFormat resultImageFormat, string formatExtension)
        {
            formatExtension = NormalizeImageFormatExtension(formatExtension);
            var originalImageFormat = ResolveFormat(formatExtension);
            return resultImageFormat == originalImageFormat;
        }

        /// <summary>
        /// Resolves the format.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <returns></returns>
        protected FileFormat ResolveFormat(string format)
        {
            switch (format.ToLower())
            {
                case "bmp":
                case "dib":
                    return Imaging.FileFormat.Bmp;
                case "png":
                    return Imaging.FileFormat.Png;
                case "jpg":
                case "jpeg":
                    return Imaging.FileFormat.Jpeg;
                case "gif":
                    return Imaging.FileFormat.Gif;
                case "psd":
                    return Imaging.FileFormat.Psd;
                case "tif":
                case "tiff":
                    return Imaging.FileFormat.Tiff;
                case "jp2":
                case "j2k":
                case "jpf":
                case "jpm":
                case "jpx":
                case "mj2":
                case "jpg2":
                case "mjp2":
                    return Imaging.FileFormat.Jpeg2000;
                case "webp":
                    return Imaging.FileFormat.Webp;
                case "emf+":
                case "emf":
                    return Imaging.FileFormat.Emf;
                case "wmf":
                    return Imaging.FileFormat.Wmf;
                case "svg":
                    return Imaging.FileFormat.Svg;
                case "cdr":
                    return Imaging.FileFormat.Cdr;
                case "djv":
                case "djvu":
                    return Imaging.FileFormat.Djvu;
                case "dicom":
                    return Imaging.FileFormat.Dicom;
                case "dng":
                    return Imaging.FileFormat.Dng;
                case "odg":
                    return Imaging.FileFormat.Odg;
                case "otg":
                    return Imaging.FileFormat.Otg;
                case "eps":
                    return Imaging.FileFormat.Eps;
                case "cmx":
                    return Imaging.FileFormat.Cmx;
                default:
                    return FileFormat.Custom;
            }
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
