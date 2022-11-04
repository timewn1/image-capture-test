# Driver Image Capture

This project was generated with [Blazor](https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor) and [ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/introduction-to-aspnet-core?view=aspnetcore-6.0). The purpose of this project is for demonstrating ability of organizing project structure, reusable code and implementing of the PWA using Blazor and ASP.NET Core.

## Requirement
1. Capture and JPEG image from mobile camera and convert it into pdf.
2. Save the PDF and JPEG image on the server.

## Environment
* .Net 6.0

Run `dotnet run` in Server directory to run project. Navigate to `https://localhost:7027`. When capture and save the image, the files of PDF and JPEG format are saved in `upload` folder in Server directory.

## Short Description
This project connected cameras using the `MediaDevices` interface of the `Window.Navigator` object and saved captured image as PDF and JPEG format on the server using `IronPdf` library.
