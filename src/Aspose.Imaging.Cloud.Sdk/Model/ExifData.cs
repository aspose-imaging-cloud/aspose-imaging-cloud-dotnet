// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ExifData.cs">
//   Copyright (c) 2018 Aspose Pty Ltd. All rights reserved.
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Aspose.Imaging.Cloud.Sdk.Model 
{
  using System;  
  using System.Collections;
  using System.Collections.Generic;
  using System.Runtime.Serialization;
  using System.Text;
  using Newtonsoft.Json;
  using Newtonsoft.Json.Converters;

  /// <summary>
  /// Represents common EXIF data section.
  /// </summary>  
  public class ExifData 
  {                       
        /// <summary>
        /// Gets or sets the aperture.
        /// </summary>  
        public double? ApertureValue { get; set; }

        /// <summary>
        /// Gets or sets the body serial number.
        /// </summary>  
        public string BodySerialNumber { get; set; }

        /// <summary>
        /// Gets or sets the brightness.
        /// </summary>  
        public double? BrightnessValue { get; set; }

        /// <summary>
        /// Gets or sets the CFA pattern.
        /// </summary>  
        public byte[] CFAPattern { get; set; }

        /// <summary>
        /// Gets or sets the camera owner name.
        /// </summary>  
        public string CameraOwnerName { get; set; }

        /// <summary>
        /// Gets or sets the color space.
        /// </summary>  
        public string ColorSpace { get; set; }

        /// <summary>
        /// Gets or sets the components configuration.
        /// </summary>  
        public byte[] ComponentsConfiguration { get; set; }

        /// <summary>
        /// Gets or sets the compressed bits per pixel.
        /// </summary>  
        public double? CompressedBitsPerPixel { get; set; }

        /// <summary>
        /// Gets or sets the contrast.
        /// </summary>  
        public string Contrast { get; set; }

        /// <summary>
        /// Gets or sets the value indincating if custom rendering is performed.
        /// </summary>  
        public string CustomRendered { get; set; }

        /// <summary>
        /// Gets or sets date and time when image was digitized.
        /// </summary>  
        public string DateTimeDigitized { get; set; }

        /// <summary>
        /// Gets or sets date and time of the original image.
        /// </summary>  
        public string DateTimeOriginal { get; set; }

        /// <summary>
        /// Gets or sets the device setting description.
        /// </summary>  
        public byte[] DeviceSettingDescription { get; set; }

        /// <summary>
        /// Gets or sets the digital zoom ratio.
        /// </summary>  
        public double? DigitalZoomRatio { get; set; }

        /// <summary>
        /// Gets or sets EXIF version.
        /// </summary>  
        public byte[] ExifVersion { get; set; }

        /// <summary>
        /// Gets or sets the exposure bias.
        /// </summary>  
        public double? ExposureBiasValue { get; set; }

        /// <summary>
        /// Gets or sets the exposure index.
        /// </summary>  
        public double? ExposureIndex { get; set; }

        /// <summary>
        /// Gets or sets the exposure mode.
        /// </summary>  
        public string ExposureMode { get; set; }

        /// <summary>
        /// Gets or sets the exposure program.
        /// </summary>  
        public string ExposureProgram { get; set; }

        /// <summary>
        /// Gets or sets the exposure time.
        /// </summary>  
        public double? ExposureTime { get; set; }

        /// <summary>
        /// Gets or sets the focal number.
        /// </summary>  
        public double? FNumber { get; set; }

        /// <summary>
        /// Gets or sets the file source.
        /// </summary>  
        public string FileSource { get; set; }

        /// <summary>
        /// Gets or sets the flash.
        /// </summary>  
        public string Flash { get; set; }

        /// <summary>
        /// Gets or sets the flash energy.
        /// </summary>  
        public double? FlashEnergy { get; set; }

        /// <summary>
        /// Gets or sets the Flashpix version.
        /// </summary>  
        public byte[] FlashpixVersion { get; set; }

        /// <summary>
        /// Gets or sets the focal length.
        /// </summary>  
        public double? FocalLength { get; set; }

        /// <summary>
        /// Gets or sets the focal length in 35mm film.
        /// </summary>  
        public int? FocalLengthIn35MmFilm { get; set; }

        /// <summary>
        /// Gets or sets the focal plane resolution unit.
        /// </summary>  
        public string FocalPlaneResolutionUnit { get; set; }

        /// <summary>
        /// Gets or sets the focal plane X resolution.
        /// </summary>  
        public double? FocalPlaneXResolution { get; set; }

        /// <summary>
        /// Gets or sets the focal plane Y resolution.
        /// </summary>  
        public double? FocalPlaneYResolution { get; set; }

        /// <summary>
        /// Gets or sets the GPS altitude.
        /// </summary>  
        public double? GPSAltitude { get; set; }

        /// <summary>
        /// Gets or sets the GPS altitude reference (if it's above or below sea level).
        /// </summary>  
        public string GPSAltitudeRef { get; set; }

        /// <summary>
        /// Gets or sets the GPS area information.
        /// </summary>  
        public byte[] GPSAreaInformation { get; set; }

        /// <summary>
        /// Gets or sets the GPS DOP (data degree of precision).
        /// </summary>  
        public double? GPSDOP { get; set; }

        /// <summary>
        /// Gets or sets the GPS bearing of the destination.
        /// </summary>  
        public double? GPSDestBearing { get; set; }

        /// <summary>
        /// Gets or sets the GPS reference unit for bearing of the destination.
        /// </summary>  
        public string GPSDestBearingRef { get; set; }

        /// <summary>
        /// Gets or sets the GPS destination distance.
        /// </summary>  
        public double? GPSDestDistance { get; set; }

        /// <summary>
        /// Gets or sets the GPS reference unit for destination distance.
        /// </summary>  
        public string GPSDestDistanceRef { get; set; }

        /// <summary>
        /// Gets or sets the GPS destination latitude.
        /// </summary>  
        public List<double?> GPSDestLatitude { get; set; }

        /// <summary>
        /// Gets or sets the GPS reference destination latitude (north or south).
        /// </summary>  
        public string GPSDestLatitudeRef { get; set; }

        /// <summary>
        /// Gets or sets the GPS destination longtitude.
        /// </summary>  
        public List<double?> GPSDestLongitude { get; set; }

        /// <summary>
        /// Gets or sets the GPS reference destination longtitude (east or west).
        /// </summary>  
        public string GPSDestLongitudeRef { get; set; }

        /// <summary>
        /// Gets or sets the GPS differential.
        /// </summary>  
        public int? GPSDifferential { get; set; }

        /// <summary>
        /// Gets or sets the GPS image direction.
        /// </summary>  
        public double? GPSImgDirection { get; set; }

        /// <summary>
        /// Gets or sets the GPS reference image direction.
        /// </summary>  
        public string GPSImgDirectionRef { get; set; }

        /// <summary>
        /// Gets or sets the GPS date stamp.
        /// </summary>  
        public string GPSDateStamp { get; set; }

        /// <summary>
        /// Gets or sets the GPS latitude.
        /// </summary>  
        public List<double?> GPSLatitude { get; set; }

        /// <summary>
        /// Gets or sets the GPS latitude reference (north or south).
        /// </summary>  
        public string GPSLatitudeRef { get; set; }

        /// <summary>
        /// Gets or sets the GPS longitude.
        /// </summary>  
        public List<double?> GPSLongitude { get; set; }

        /// <summary>
        /// Gets or sets the GPS longitude reference (east or west).
        /// </summary>  
        public string GPSLongitudeRef { get; set; }

        /// <summary>
        /// Gets or sets the geodetic survey data used by the GPS receiver.
        /// </summary>  
        public string GPSMapDatum { get; set; }

        /// <summary>
        /// Gets or sets the GPS measure mode.
        /// </summary>  
        public string GPSMeasureMode { get; set; }

        /// <summary>
        /// Gets or setsthe GPS processing method.
        /// </summary>  
        public byte[] GPSProcessingMethod { get; set; }

        /// <summary>
        /// Gets or sets the GPS satellites info.
        /// </summary>  
        public string GPSSatellites { get; set; }

        /// <summary>
        /// Gets or sets the GPS speed.
        /// </summary>  
        public double? GPSSpeed { get; set; }

        /// <summary>
        /// Gets or sets the GPS speed reference unit.
        /// </summary>  
        public string GPSSpeedRef { get; set; }

        /// <summary>
        /// Gets or sets the GPS status.
        /// </summary>  
        public string GPSStatus { get; set; }

        /// <summary>
        /// Gets or sets the GPS times tamp.
        /// </summary>  
        public List<double?> GPSTimestamp { get; set; }

        /// <summary>
        /// Gets or sets the GPS track.
        /// </summary>  
        public string GPSTrack { get; set; }

        /// <summary>
        /// Gets or sets the GPS track reference.
        /// </summary>  
        public string GPSTrackRef { get; set; }

        /// <summary>
        /// Gets or sets the GPS version ID.
        /// </summary>  
        public byte[] GPSVersionID { get; set; }

        /// <summary>
        /// Gets or sets the gain control.
        /// </summary>  
        public string GainControl { get; set; }

        /// <summary>
        /// Gets or sets the gamma.
        /// </summary>  
        public double? Gamma { get; set; }

        /// <summary>
        /// Gets or sets the ISO speed.
        /// </summary>  
        public long? ISOSpeed { get; set; }

        /// <summary>
        /// Gets or sets the ISO speed latitude YYY value.
        /// </summary>  
        public long? ISOSpeedLatitudeYYY { get; set; }

        /// <summary>
        /// Gets or sets the ISO speed latitude ZZZ value.
        /// </summary>  
        public long? ISOSpeedLatitudeZZZ { get; set; }

        /// <summary>
        /// Gets or sets the photographic sensitivity.
        /// </summary>  
        public long? PhotographicSensitivity { get; set; }

        /// <summary>
        /// Gets or sets the image unique ID.
        /// </summary>  
        public string ImageUniqueID { get; set; }

        /// <summary>
        /// Gets or sets the lens manufacturer.
        /// </summary>  
        public string LensMake { get; set; }

        /// <summary>
        /// Gets or sets the lens model.
        /// </summary>  
        public string LensModel { get; set; }

        /// <summary>
        /// Gets or sets the lens serial number.
        /// </summary>  
        public string LensSerialNumber { get; set; }

        /// <summary>
        /// Gets or sets the lens specification.
        /// </summary>  
        public List<double?> LensSpecification { get; set; }

        /// <summary>
        /// Gets or sets the light source.
        /// </summary>  
        public string LightSource { get; set; }

        /// <summary>
        /// Gets or sets the maker note raw data.
        /// </summary>  
        public byte[] MakerNoteRawData { get; set; }

        /// <summary>
        /// Gets or sets the max aperture.
        /// </summary>  
        public double? MaxApertureValue { get; set; }

        /// <summary>
        /// Gets or sets the metering mode.
        /// </summary>  
        public string MeteringMode { get; set; }

        /// <summary>
        /// Gets or sets the OECF (Opto-Electric Conversion Function).
        /// </summary>  
        public byte[] OECF { get; set; }

        /// <summary>
        /// Gets or sets the pixel X dimension.
        /// </summary>  
        public long? PixelXDimension { get; set; }

        /// <summary>
        /// Gets or sets the pixel Y dimension.
        /// </summary>  
        public long? PixelYDimension { get; set; }

        /// <summary>
        /// Gets or sets the recommended exposure index.
        /// </summary>  
        public long? RecommendedExposureIndex { get; set; }

        /// <summary>
        /// Gets or sets the related sound file.
        /// </summary>  
        public string RelatedSoundFile { get; set; }

        /// <summary>
        /// Gets or sets the saturation.
        /// </summary>  
        public string Saturation { get; set; }

        /// <summary>
        /// Gets or sets the scene capture type.
        /// </summary>  
        public string SceneCaptureType { get; set; }

        /// <summary>
        /// Gets or sets the scene type.
        /// </summary>  
        public int? SceneType { get; set; }

        /// <summary>
        /// Gets or sets the sensing method.
        /// </summary>  
        public string SensingMethod { get; set; }

        /// <summary>
        /// Gets or sets the sensitivity type.
        /// </summary>  
        public int? SensitivityType { get; set; }

        /// <summary>
        /// Gets or sets the sharpness.
        /// </summary>  
        public int? Sharpness { get; set; }

        /// <summary>
        /// Gets or sets the shutter speed.
        /// </summary>  
        public double? ShutterSpeedValue { get; set; }

        /// <summary>
        /// Gets or sets the spatial frequency response.
        /// </summary>  
        public byte[] SpatialFrequencyResponse { get; set; }

        /// <summary>
        /// Gets or sets the spectral sensitivity.
        /// </summary>  
        public string SpectralSensitivity { get; set; }

        /// <summary>
        /// Gets or sets the standard output sensitivity.
        /// </summary>  
        public long? StandardOutputSensitivity { get; set; }

        /// <summary>
        /// Gets or sets the subject area.
        /// </summary>  
        public List<int?> SubjectArea { get; set; }

        /// <summary>
        /// Gets or sets the subject distance.
        /// </summary>  
        public double? SubjectDistance { get; set; }

        /// <summary>
        /// Gets or sets the subject distance range.
        /// </summary>  
        public string SubjectDistanceRange { get; set; }

        /// <summary>
        /// Gets or sets the subject location.
        /// </summary>  
        public List<int?> SubjectLocation { get; set; }

        /// <summary>
        /// Gets or sets the fractions of seconds for the DateTime tag.
        /// </summary>  
        public string SubsecTime { get; set; }

        /// <summary>
        /// Gets or sets the fractions of seconds for the DateTimeDigitized tag.
        /// </summary>  
        public string SubsecTimeDigitized { get; set; }

        /// <summary>
        /// Gets or sets the fractions of seconds for the DateTimeOriginal tag.
        /// </summary>  
        public string SubsecTimeOriginal { get; set; }

        /// <summary>
        /// Gets or sets the user comment.
        /// </summary>  
        public string UserComment { get; set; }

        /// <summary>
        /// Gets or sets the white balance.
        /// </summary>  
        public string WhiteBalance { get; set; }

        /// <summary>
        /// Gets or sets the white point.
        /// </summary>  
        public List<double?> WhitePoint { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ExifData {\n");
          sb.Append("  ApertureValue: ").Append(this.ApertureValue).Append("\n");
          sb.Append("  BodySerialNumber: ").Append(this.BodySerialNumber).Append("\n");
          sb.Append("  BrightnessValue: ").Append(this.BrightnessValue).Append("\n");
          sb.Append("  CFAPattern: ").Append(this.CFAPattern).Append("\n");
          sb.Append("  CameraOwnerName: ").Append(this.CameraOwnerName).Append("\n");
          sb.Append("  ColorSpace: ").Append(this.ColorSpace).Append("\n");
          sb.Append("  ComponentsConfiguration: ").Append(this.ComponentsConfiguration).Append("\n");
          sb.Append("  CompressedBitsPerPixel: ").Append(this.CompressedBitsPerPixel).Append("\n");
          sb.Append("  Contrast: ").Append(this.Contrast).Append("\n");
          sb.Append("  CustomRendered: ").Append(this.CustomRendered).Append("\n");
          sb.Append("  DateTimeDigitized: ").Append(this.DateTimeDigitized).Append("\n");
          sb.Append("  DateTimeOriginal: ").Append(this.DateTimeOriginal).Append("\n");
          sb.Append("  DeviceSettingDescription: ").Append(this.DeviceSettingDescription).Append("\n");
          sb.Append("  DigitalZoomRatio: ").Append(this.DigitalZoomRatio).Append("\n");
          sb.Append("  ExifVersion: ").Append(this.ExifVersion).Append("\n");
          sb.Append("  ExposureBiasValue: ").Append(this.ExposureBiasValue).Append("\n");
          sb.Append("  ExposureIndex: ").Append(this.ExposureIndex).Append("\n");
          sb.Append("  ExposureMode: ").Append(this.ExposureMode).Append("\n");
          sb.Append("  ExposureProgram: ").Append(this.ExposureProgram).Append("\n");
          sb.Append("  ExposureTime: ").Append(this.ExposureTime).Append("\n");
          sb.Append("  FNumber: ").Append(this.FNumber).Append("\n");
          sb.Append("  FileSource: ").Append(this.FileSource).Append("\n");
          sb.Append("  Flash: ").Append(this.Flash).Append("\n");
          sb.Append("  FlashEnergy: ").Append(this.FlashEnergy).Append("\n");
          sb.Append("  FlashpixVersion: ").Append(this.FlashpixVersion).Append("\n");
          sb.Append("  FocalLength: ").Append(this.FocalLength).Append("\n");
          sb.Append("  FocalLengthIn35MmFilm: ").Append(this.FocalLengthIn35MmFilm).Append("\n");
          sb.Append("  FocalPlaneResolutionUnit: ").Append(this.FocalPlaneResolutionUnit).Append("\n");
          sb.Append("  FocalPlaneXResolution: ").Append(this.FocalPlaneXResolution).Append("\n");
          sb.Append("  FocalPlaneYResolution: ").Append(this.FocalPlaneYResolution).Append("\n");
          sb.Append("  GPSAltitude: ").Append(this.GPSAltitude).Append("\n");
          sb.Append("  GPSAltitudeRef: ").Append(this.GPSAltitudeRef).Append("\n");
          sb.Append("  GPSAreaInformation: ").Append(this.GPSAreaInformation).Append("\n");
          sb.Append("  GPSDOP: ").Append(this.GPSDOP).Append("\n");
          sb.Append("  GPSDestBearing: ").Append(this.GPSDestBearing).Append("\n");
          sb.Append("  GPSDestBearingRef: ").Append(this.GPSDestBearingRef).Append("\n");
          sb.Append("  GPSDestDistance: ").Append(this.GPSDestDistance).Append("\n");
          sb.Append("  GPSDestDistanceRef: ").Append(this.GPSDestDistanceRef).Append("\n");
          sb.Append("  GPSDestLatitude: ").Append(this.GPSDestLatitude).Append("\n");
          sb.Append("  GPSDestLatitudeRef: ").Append(this.GPSDestLatitudeRef).Append("\n");
          sb.Append("  GPSDestLongitude: ").Append(this.GPSDestLongitude).Append("\n");
          sb.Append("  GPSDestLongitudeRef: ").Append(this.GPSDestLongitudeRef).Append("\n");
          sb.Append("  GPSDifferential: ").Append(this.GPSDifferential).Append("\n");
          sb.Append("  GPSImgDirection: ").Append(this.GPSImgDirection).Append("\n");
          sb.Append("  GPSImgDirectionRef: ").Append(this.GPSImgDirectionRef).Append("\n");
          sb.Append("  GPSDateStamp: ").Append(this.GPSDateStamp).Append("\n");
          sb.Append("  GPSLatitude: ").Append(this.GPSLatitude).Append("\n");
          sb.Append("  GPSLatitudeRef: ").Append(this.GPSLatitudeRef).Append("\n");
          sb.Append("  GPSLongitude: ").Append(this.GPSLongitude).Append("\n");
          sb.Append("  GPSLongitudeRef: ").Append(this.GPSLongitudeRef).Append("\n");
          sb.Append("  GPSMapDatum: ").Append(this.GPSMapDatum).Append("\n");
          sb.Append("  GPSMeasureMode: ").Append(this.GPSMeasureMode).Append("\n");
          sb.Append("  GPSProcessingMethod: ").Append(this.GPSProcessingMethod).Append("\n");
          sb.Append("  GPSSatellites: ").Append(this.GPSSatellites).Append("\n");
          sb.Append("  GPSSpeed: ").Append(this.GPSSpeed).Append("\n");
          sb.Append("  GPSSpeedRef: ").Append(this.GPSSpeedRef).Append("\n");
          sb.Append("  GPSStatus: ").Append(this.GPSStatus).Append("\n");
          sb.Append("  GPSTimestamp: ").Append(this.GPSTimestamp).Append("\n");
          sb.Append("  GPSTrack: ").Append(this.GPSTrack).Append("\n");
          sb.Append("  GPSTrackRef: ").Append(this.GPSTrackRef).Append("\n");
          sb.Append("  GPSVersionID: ").Append(this.GPSVersionID).Append("\n");
          sb.Append("  GainControl: ").Append(this.GainControl).Append("\n");
          sb.Append("  Gamma: ").Append(this.Gamma).Append("\n");
          sb.Append("  ISOSpeed: ").Append(this.ISOSpeed).Append("\n");
          sb.Append("  ISOSpeedLatitudeYYY: ").Append(this.ISOSpeedLatitudeYYY).Append("\n");
          sb.Append("  ISOSpeedLatitudeZZZ: ").Append(this.ISOSpeedLatitudeZZZ).Append("\n");
          sb.Append("  PhotographicSensitivity: ").Append(this.PhotographicSensitivity).Append("\n");
          sb.Append("  ImageUniqueID: ").Append(this.ImageUniqueID).Append("\n");
          sb.Append("  LensMake: ").Append(this.LensMake).Append("\n");
          sb.Append("  LensModel: ").Append(this.LensModel).Append("\n");
          sb.Append("  LensSerialNumber: ").Append(this.LensSerialNumber).Append("\n");
          sb.Append("  LensSpecification: ").Append(this.LensSpecification).Append("\n");
          sb.Append("  LightSource: ").Append(this.LightSource).Append("\n");
          sb.Append("  MakerNoteRawData: ").Append(this.MakerNoteRawData).Append("\n");
          sb.Append("  MaxApertureValue: ").Append(this.MaxApertureValue).Append("\n");
          sb.Append("  MeteringMode: ").Append(this.MeteringMode).Append("\n");
          sb.Append("  OECF: ").Append(this.OECF).Append("\n");
          sb.Append("  PixelXDimension: ").Append(this.PixelXDimension).Append("\n");
          sb.Append("  PixelYDimension: ").Append(this.PixelYDimension).Append("\n");
          sb.Append("  RecommendedExposureIndex: ").Append(this.RecommendedExposureIndex).Append("\n");
          sb.Append("  RelatedSoundFile: ").Append(this.RelatedSoundFile).Append("\n");
          sb.Append("  Saturation: ").Append(this.Saturation).Append("\n");
          sb.Append("  SceneCaptureType: ").Append(this.SceneCaptureType).Append("\n");
          sb.Append("  SceneType: ").Append(this.SceneType).Append("\n");
          sb.Append("  SensingMethod: ").Append(this.SensingMethod).Append("\n");
          sb.Append("  SensitivityType: ").Append(this.SensitivityType).Append("\n");
          sb.Append("  Sharpness: ").Append(this.Sharpness).Append("\n");
          sb.Append("  ShutterSpeedValue: ").Append(this.ShutterSpeedValue).Append("\n");
          sb.Append("  SpatialFrequencyResponse: ").Append(this.SpatialFrequencyResponse).Append("\n");
          sb.Append("  SpectralSensitivity: ").Append(this.SpectralSensitivity).Append("\n");
          sb.Append("  StandardOutputSensitivity: ").Append(this.StandardOutputSensitivity).Append("\n");
          sb.Append("  SubjectArea: ").Append(this.SubjectArea).Append("\n");
          sb.Append("  SubjectDistance: ").Append(this.SubjectDistance).Append("\n");
          sb.Append("  SubjectDistanceRange: ").Append(this.SubjectDistanceRange).Append("\n");
          sb.Append("  SubjectLocation: ").Append(this.SubjectLocation).Append("\n");
          sb.Append("  SubsecTime: ").Append(this.SubsecTime).Append("\n");
          sb.Append("  SubsecTimeDigitized: ").Append(this.SubsecTimeDigitized).Append("\n");
          sb.Append("  SubsecTimeOriginal: ").Append(this.SubsecTimeOriginal).Append("\n");
          sb.Append("  UserComment: ").Append(this.UserComment).Append("\n");
          sb.Append("  WhiteBalance: ").Append(this.WhiteBalance).Append("\n");
          sb.Append("  WhitePoint: ").Append(this.WhitePoint).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}