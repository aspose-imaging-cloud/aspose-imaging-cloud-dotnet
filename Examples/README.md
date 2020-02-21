# Aspose.Imaging Cloud SDK Examples
This project provides examples of using Aspose.Imaging Cloud SDK for .NET.

### Running the examples
 ```c#
nuget restore
msbuild.exe AsposeImagingCloudSdkExamples.sln /p:Configuration=Release /t:Clean,Build
cd .\AsposeImagingCloudSdkExamples\bin\Release\
AsposeImagingCloudSdkExamples.exe --appKey=... --appSid=... --baseUrl=...
 ```
`--appKey` and `--appSid` are required parameters to connect to Aspose.Imaging Cloud. They can be looked up at [Aspose Cloud Dashboard](https://dashboard.aspose.cloud/#/apps) (free registration in Aspose Cloud is required for this).

`--baseUrl` is an optional parameter that allows running examples with custom hosted Aspose.Imaging Cloud instance.
