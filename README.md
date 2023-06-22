# Iframe Token Based Authorization Sample
This sample demonstrates the embedding the dashboard in iframe with token based authoriztion.

## Dashboard view

![Dashboard View](https://github.com/boldbi/aspnet-core-sample/assets/91586758/b61a18f4-6026-4379-bb7e-82844a7fdd6f)

 #### Help link

 * https://help.boldbi.com/embedded-bi/faq/where-can-i-find-the-product-version/

 #### Supported browsers
  
  * Google Chrome, Microsoft Edge, Mozilla Firefox, and Safari.

 ## Configuration

  1. Need to change the mantory properties for `EmbedSecretKey`, `DashboardURL` and `UserEmail`.

 ## Developer IDE

  * Visual studio 2022(https://visualstudio.microsoft.com/downloads/)

 ### Run a Sample Using Visual Studio 2022
 
  * Open the solution file `EmbedDashboardWithTokenAuthentication.sln` in Visual Studio.

  * Run your `Iframe token based authentication` sample in Visual Studio.

  * After run your sample, the application will automatically launch in the default browser. You can access it at the specified location (e.g., http://../embed.html).

  * Open `File Explorer` and navigate to the specified file [location](https://github.com/boldbi/iframe-token-based-authorization-sample/tree/master/EmbedDashboardWithTokenAuthentication)

  * Newly generated one file called `embed` in `Chrome` browser. Open the `embed` file, dashboard will be rendering.

    ![dashboard image](https://github.com/boldbi/aspnet-core-sample/assets/91586758/b61a18f4-6026-4379-bb7e-82844a7fdd6f)


Please refer to the [help documentation](https://help.boldbi.com/embedding-options/iframe-embedding/dashboard-with-token-based-authentication/) to know how to run the sample.

## Important notes

It is recommended not to store passwords and sensitive information in configuration files for security reasons in a real-world application. Instead, it would be best if you considered using a secure application, such as Key Vault, to safeguard your credentials.

## Online demos

Look at the Bold BI Embedding sample to live demo [here](https://samples.boldbi.com/embed).

## Documentation

A complete Bold BI Embedding documentation can be found on [Bold BI Embedding Help](https://help.boldbi.com/embedding-options/iframe-embedding/).