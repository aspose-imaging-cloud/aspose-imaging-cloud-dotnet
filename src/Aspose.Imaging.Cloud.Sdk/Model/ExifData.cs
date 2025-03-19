// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ExifData.cs">
//   Copyright (c) 2018-2020 Aspose Pty Ltd. All rights reserved.
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
  /// 
  /// </summary>  
  public class ExifData 
  {                       
        /// <summary>
        /// Gets or sets ApertureValue
        /// </summary>  
        public double? ApertureValue { get; set; }

        /// <summary>
        /// Gets or sets BodySerialNumber
        /// </summary>  
        public string BodySerialNumber { get; set; }

        /// <summary>
        /// Gets or sets BrightnessValue
        /// </summary>  
        public double? BrightnessValue { get; set; }

        /// <summary>
        /// Gets or sets CFAPattern
        /// </summary>  
        public byte[] CFAPattern { get; set; }

        /// <summary>
        /// Gets or sets CameraOwnerName
        /// </summary>  
        public string CameraOwnerName { get; set; }

        /// <summary>
        /// Gets or sets ColorSpace
        /// </summary>  
        public string ColorSpace { get; set; }

        /// <summary>
        /// Gets or sets ComponentsConfiguration
        /// </summary>  
        public byte[] ComponentsConfiguration { get; set; }

        /// <summary>
        /// Gets or sets CompressedBitsPerPixel
        /// </summary>  
        public double? CompressedBitsPerPixel { get; set; }

        /// <summary>
        /// Gets or sets Contrast
        /// </summary>  
        public string Contrast { get; set; }

        /// <summary>
        /// Gets or sets CustomRendered
        /// </summary>  
        public string CustomRendered { get; set; }

        /// <summary>
        /// Gets or sets DateTimeDigitized
        /// </summary>  
        public string DateTimeDigitized { get; set; }

        /// <summary>
        /// Gets or sets DateTimeOriginal
        /// </summary>  
        public string DateTimeOriginal { get; set; }

        /// <summary>
        /// Gets or sets DeviceSettingDescription
        /// </summary>  
        public byte[] DeviceSettingDescription { get; set; }

        /// <summary>
        /// Gets or sets DigitalZoomRatio
        /// </summary>  
        public double? DigitalZoomRatio { get; set; }

        /// <summary>
        /// Gets or sets ExifVersion
        /// </summary>  
        public byte[] ExifVersion { get; set; }

        /// <summary>
        /// Gets or sets ExposureBiasValue
        /// </summary>  
        public double? ExposureBiasValue { get; set; }

        /// <summary>
        /// Gets or sets ExposureIndex
        /// </summary>  
        public double? ExposureIndex { get; set; }

        /// <summary>
        /// Gets or sets ExposureMode
        /// </summary>  
        public string ExposureMode { get; set; }

        /// <summary>
        /// Gets or sets ExposureProgram
        /// </summary>  
        public string ExposureProgram { get; set; }

        /// <summary>
        /// Gets or sets ExposureTime
        /// </summary>  
        public double? ExposureTime { get; set; }

        /// <summary>
        /// Gets or sets FNumber
        /// </summary>  
        public double? FNumber { get; set; }

        /// <summary>
        /// Gets or sets FileSource
        /// </summary>  
        public string FileSource { get; set; }

        /// <summary>
        /// Gets or sets Flash
        /// </summary>  
        public string Flash { get; set; }

        /// <summary>
        /// Gets or sets FlashEnergy
        /// </summary>  
        public double? FlashEnergy { get; set; }

        /// <summary>
        /// Gets or sets FlashpixVersion
        /// </summary>  
        public byte[] FlashpixVersion { get; set; }

        /// <summary>
        /// Gets or sets FocalLength
        /// </summary>  
        public double? FocalLength { get; set; }

        /// <summary>
        /// Gets or sets FocalLengthIn35MmFilm
        /// </summary>  
        public int? FocalLengthIn35MmFilm { get; set; }

        /// <summary>
        /// Gets or sets FocalPlaneResolutionUnit
        /// </summary>  
        public string FocalPlaneResolutionUnit { get; set; }

        /// <summary>
        /// Gets or sets FocalPlaneXResolution
        /// </summary>  
        public double? FocalPlaneXResolution { get; set; }

        /// <summary>
        /// Gets or sets FocalPlaneYResolution
        /// </summary>  
        public double? FocalPlaneYResolution { get; set; }

        /// <summary>
        /// Gets or sets GPSAltitude
        /// </summary>  
        public double? GPSAltitude { get; set; }

        /// <summary>
        /// Gets or sets GPSAltitudeRef
        /// </summary>  
        public string GPSAltitudeRef { get; set; }

        /// <summary>
        /// Gets or sets GPSAreaInformation
        /// </summary>  
        public byte[] GPSAreaInformation { get; set; }

        /// <summary>
        /// Gets or sets GPSDOP
        /// </summary>  
        public double? GPSDOP { get; set; }

        /// <summary>
        /// Gets or sets GPSDestBearing
        /// </summary>  
        public double? GPSDestBearing { get; set; }

        /// <summary>
        /// Gets or sets GPSDestBearingRef
        /// </summary>  
        public string GPSDestBearingRef { get; set; }

        /// <summary>
        /// Gets or sets GPSDestDistance
        /// </summary>  
        public double? GPSDestDistance { get; set; }

        /// <summary>
        /// Gets or sets GPSDestDistanceRef
        /// </summary>  
        public string GPSDestDistanceRef { get; set; }

        /// <summary>
        /// Gets or sets GPSDestLatitude
        /// </summary>  
        public List<double?> GPSDestLatitude { get; set; }

        /// <summary>
        /// Gets or sets GPSDestLatitudeRef
        /// </summary>  
        public string GPSDestLatitudeRef { get; set; }

        /// <summary>
        /// Gets or sets GPSDestLongitude
        /// </summary>  
        public List<double?> GPSDestLongitude { get; set; }

        /// <summary>
        /// Gets or sets GPSDestLongitudeRef
        /// </summary>  
        public string GPSDestLongitudeRef { get; set; }

        /// <summary>
        /// Gets or sets GPSDifferential
        /// </summary>  
        public int? GPSDifferential { get; set; }

        /// <summary>
        /// Gets or sets GPSImgDirection
        /// </summary>  
        public double? GPSImgDirection { get; set; }

        /// <summary>
        /// Gets or sets GPSImgDirectionRef
        /// </summary>  
        public string GPSImgDirectionRef { get; set; }

        /// <summary>
        /// Gets or sets GPSDateStamp
        /// </summary>  
        public string GPSDateStamp { get; set; }

        /// <summary>
        /// Gets or sets GPSLatitude
        /// </summary>  
        public List<double?> GPSLatitude { get; set; }

        /// <summary>
        /// Gets or sets GPSLatitudeRef
        /// </summary>  
        public string GPSLatitudeRef { get; set; }

        /// <summary>
        /// Gets or sets GPSLongitude
        /// </summary>  
        public List<double?> GPSLongitude { get; set; }

        /// <summary>
        /// Gets or sets GPSLongitudeRef
        /// </summary>  
        public string GPSLongitudeRef { get; set; }

        /// <summary>
        /// Gets or sets GPSMapDatum
        /// </summary>  
        public string GPSMapDatum { get; set; }

        /// <summary>
        /// Gets or sets GPSMeasureMode
        /// </summary>  
        public string GPSMeasureMode { get; set; }

        /// <summary>
        /// Gets or sets GPSProcessingMethod
        /// </summary>  
        public byte[] GPSProcessingMethod { get; set; }

        /// <summary>
        /// Gets or sets GPSSatellites
        /// </summary>  
        public string GPSSatellites { get; set; }

        /// <summary>
        /// Gets or sets GPSSpeed
        /// </summary>  
        public double? GPSSpeed { get; set; }

        /// <summary>
        /// Gets or sets GPSSpeedRef
        /// </summary>  
        public string GPSSpeedRef { get; set; }

        /// <summary>
        /// Gets or sets GPSStatus
        /// </summary>  
        public string GPSStatus { get; set; }

        /// <summary>
        /// Gets or sets GPSTimestamp
        /// </summary>  
        public List<double?> GPSTimestamp { get; set; }

        /// <summary>
        /// Gets or sets GPSTrack
        /// </summary>  
        public string GPSTrack { get; set; }

        /// <summary>
        /// Gets or sets GPSTrackRef
        /// </summary>  
        public string GPSTrackRef { get; set; }

        /// <summary>
        /// Gets or sets GPSVersionID
        /// </summary>  
        public byte[] GPSVersionID { get; set; }

        /// <summary>
        /// Gets or sets GainControl
        /// </summary>  
        public string GainControl { get; set; }

        /// <summary>
        /// Gets or sets Gamma
        /// </summary>  
        public double? Gamma { get; set; }

        /// <summary>
        /// Gets or sets ISOSpeed
        /// </summary>  
        public long? ISOSpeed { get; set; }

        /// <summary>
        /// Gets or sets ISOSpeedLatitudeYYY
        /// </summary>  
        public long? ISOSpeedLatitudeYYY { get; set; }

        /// <summary>
        /// Gets or sets ISOSpeedLatitudeZZZ
        /// </summary>  
        public long? ISOSpeedLatitudeZZZ { get; set; }

        /// <summary>
        /// Gets or sets PhotographicSensitivity
        /// </summary>  
        public long? PhotographicSensitivity { get; set; }

        /// <summary>
        /// Gets or sets ImageUniqueID
        /// </summary>  
        public string ImageUniqueID { get; set; }

        /// <summary>
        /// Gets or sets LensMake
        /// </summary>  
        public string LensMake { get; set; }

        /// <summary>
        /// Gets or sets LensModel
        /// </summary>  
        public string LensModel { get; set; }

        /// <summary>
        /// Gets or sets LensSerialNumber
        /// </summary>  
        public string LensSerialNumber { get; set; }

        /// <summary>
        /// Gets or sets LensSpecification
        /// </summary>  
        public List<double?> LensSpecification { get; set; }

        /// <summary>
        /// Gets or sets LightSource
        /// </summary>  
        public string LightSource { get; set; }

        /// <summary>
        /// Gets or sets MakerNoteRawData
        /// </summary>  
        public byte[] MakerNoteRawData { get; set; }

        /// <summary>
        /// Gets or sets MaxApertureValue
        /// </summary>  
        public double? MaxApertureValue { get; set; }

        /// <summary>
        /// Gets or sets MeteringMode
        /// </summary>  
        public string MeteringMode { get; set; }

        /// <summary>
        /// Gets or sets OECF
        /// </summary>  
        public byte[] OECF { get; set; }

        /// <summary>
        /// Gets or sets PixelXDimension
        /// </summary>  
        public long? PixelXDimension { get; set; }

        /// <summary>
        /// Gets or sets PixelYDimension
        /// </summary>  
        public long? PixelYDimension { get; set; }

        /// <summary>
        /// Gets or sets RecommendedExposureIndex
        /// </summary>  
        public long? RecommendedExposureIndex { get; set; }

        /// <summary>
        /// Gets or sets RelatedSoundFile
        /// </summary>  
        public string RelatedSoundFile { get; set; }

        /// <summary>
        /// Gets or sets Saturation
        /// </summary>  
        public string Saturation { get; set; }

        /// <summary>
        /// Gets or sets SceneCaptureType
        /// </summary>  
        public string SceneCaptureType { get; set; }

        /// <summary>
        /// Gets or sets SceneType
        /// </summary>  
        public int? SceneType { get; set; }

        /// <summary>
        /// Gets or sets SensingMethod
        /// </summary>  
        public string SensingMethod { get; set; }

        /// <summary>
        /// Gets or sets SensitivityType
        /// </summary>  
        public int? SensitivityType { get; set; }

        /// <summary>
        /// Gets or sets Sharpness
        /// </summary>  
        public int? Sharpness { get; set; }

        /// <summary>
        /// Gets or sets ShutterSpeedValue
        /// </summary>  
        public double? ShutterSpeedValue { get; set; }

        /// <summary>
        /// Gets or sets SpatialFrequencyResponse
        /// </summary>  
        public byte[] SpatialFrequencyResponse { get; set; }

        /// <summary>
        /// Gets or sets SpectralSensitivity
        /// </summary>  
        public string SpectralSensitivity { get; set; }

        /// <summary>
        /// Gets or sets StandardOutputSensitivity
        /// </summary>  
        public long? StandardOutputSensitivity { get; set; }

        /// <summary>
        /// Gets or sets SubjectArea
        /// </summary>  
        public List<int?> SubjectArea { get; set; }

        /// <summary>
        /// Gets or sets SubjectDistance
        /// </summary>  
        public double? SubjectDistance { get; set; }

        /// <summary>
        /// Gets or sets SubjectDistanceRange
        /// </summary>  
        public string SubjectDistanceRange { get; set; }

        /// <summary>
        /// Gets or sets SubjectLocation
        /// </summary>  
        public List<int?> SubjectLocation { get; set; }

        /// <summary>
        /// Gets or sets SubsecTime
        /// </summary>  
        public string SubsecTime { get; set; }

        /// <summary>
        /// Gets or sets SubsecTimeDigitized
        /// </summary>  
        public string SubsecTimeDigitized { get; set; }

        /// <summary>
        /// Gets or sets SubsecTimeOriginal
        /// </summary>  
        public string SubsecTimeOriginal { get; set; }

        /// <summary>
        /// Gets or sets UserComment
        /// </summary>  
        public string UserComment { get; set; }

        /// <summary>
        /// Gets or sets WhiteBalance
        /// </summary>  
        public string WhiteBalance { get; set; }

        /// <summary>
        /// Gets or sets WhitePoint
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
