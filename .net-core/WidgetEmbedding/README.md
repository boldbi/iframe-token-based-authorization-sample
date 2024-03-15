# Iframe Widget Embedding with ASP.NET Core

This project was created using ASP.NET Core 6.0.  This application aims to demonstrate how to embed the Bold BI widget with iFrame based Single Sign-On(SSO) using token based authentication.

## Dashboard view

![iframewidget](https://github.com/boldbi/iframe-token-based-authorization-sample/assets/129487075/7d95ba94-42d4-4a65-a99a-e609731e42e5)

## Prerequisites

 * [Visual Studio Code](https://code.visualstudio.com/download)
 * [.NET Core 6.0](https://dotnet.microsoft.com/en-us/download/dotnet)

 #### Supported browsers
  
  * Google Chrome, Microsoft Edge, and Mozilla Firefox.

 ## Configuration

To set the following properties in the `EmbedProperties.cs` file, follow these instructions:

![iframewidget_properties](https://github.com/boldbi/iframe-token-based-authorization-sample/assets/129487075/6b270ed8-ff32-48bb-b76f-21bbdd3f774f)

<meta charset="utf-8"/>
    <table>
    <tbody>
        <tr>
            <td align="left">UserEmail</td>
            <td align="left">UserEmail of the Admin in your Bold BI, which will be used to get the dashboard.</td>
        </tr>
        <tr>
        <td align="left">EmbedSecret</td>
            <td align="left">Get your EmbedSecret key from embed tab by enabling <code>Enable embed authentication</code> in the <a href='https://help.boldbi.com/embedded-bi/site-administration/embed-settings/'>Administration page</a>. </td>
        </tr>  
        <tr>
        <td align="left">DashboardUrl</td>
            <td align="left">Get the <a href='https://help.boldbi.com/working-with-dashboards/share-dashboards/get-dashboard-link/#get-link'>dashboard URL</a> of the dashboard in your Bold BI.</td>
        </tr>
        <tr>
        <td align="left">WidgetId</td>
            <td align="left">Get the <a href='https://help.boldbi.com/embedding-options/iframe-embedding/embedding-a-widget/#how-to-get-the-embed-widget-url'>widget Id</a> of the dashboard in your Bold BI.</td>
        </tr> 
    </tbody>
    </table>   

 ## Run a Sample Using Command Line Interface 
    
  1. Open the command line interface and navigate to the specified file [location](https://github.com/boldbi/iframe-token-based-authorization-sample/.net-core/WidgetEmbedding/EmbedWidgetwithSSOusingToken) where the project is located.

  2. Execute the command `dotnet restore` to restore the necessary packages. Once the packages have been successfully restored, use the `dotnet build` command to build the project.
  
  3. Finally, run the application using the command `dotnet run`. After the application has started, it will display a URL in the `command line interface`, typically something like (e.g., https://localhost:7195). Copy this URL and paste it into your default web browser.

 ## Developer IDE

  * [Visual Studio Code](https://code.visualstudio.com/download)

 ### Run a Sample Using Visual Studio Code
 
  * Open the folder [WidgetEmbedding](https://github.com/boldbi/iframe-token-based-authorization-sample/.net-core/WidgetEmbedding/EmbedWidgetwithSSOusingToken) in Visual Studio Code.
   
  * Open the terminal in Visual Studio Code and execute the command `dotnet restore` to restore the required dependencies.
 
  * Build your .NET project by executing the `dotnet build` command in the terminal.
 
  * To run the application, use the command `dotnet run` in the terminal. After the application has started, it will display a URL in the `command line interface`, typically something like (e.g., https://localhost:7195). Copy this URL and paste it into your default web browser.

    ![iframewidget](https://github.com/boldbi/iframe-token-based-authorization-sample/assets/129487075/38346784-17e1-4692-ad9a-96d3a8eb7263)

## Important notes

It is recommended not to store passwords and sensitive information in configuration files for security reasons in a real-world application. Instead, it would be best if you considered using a secure application, such as Key Vault, to safeguard your credentials.

## Online demos

Look at the Bold BI Embedding sample to live demo [here](https://samples.boldbi.com/embed).

## Documentation

A complete Bold BI Embedding documentation can be found on [Bold BI Embedding Help](https://help.boldbi.com/embedding-options/iframe-embedding/).
