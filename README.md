# Iframe Token Based Authorization Sample

This sample demonstrates the embedding the dashboard in iframe with token based authoriztion.

## Dashboard view

![Dashboard View](https://github.com/boldbi/aspnet-core-sample/assets/91586758/b61a18f4-6026-4379-bb7e-82844a7fdd6f)

 #### Help link

 * https://help.boldbi.com/embedded-bi/faq/where-can-i-find-the-product-version/

 #### Supported browsers
  
  * Google Chrome, Microsoft Edge, Mozilla Firefox, and Safari.

 ## Configuration

  1. Requires the following properties to be configured as mandatory:
      * EmbedSecretKey
      * DashboardURL 
      * UserEmail

   <table>
   <tr>
   <td style="width: 23%"><strong>Parameter</strong></td>
   <td style="width: 77%"><strong>Description</strong></td>
   </tr>

   <tr>
   <td>Dashboard URL</td>
   <td>URL of the dashboard to be embed. Refer this <a href="/working-with-dashboards/share-dashboards/get-dashboard-link/">link</a> to get the URL. <code>

   ```js
      Example:
      https://test.boldbi.com/bi/en-us/site/site1/dashboards/8428c9d9-85db-418c-b877-ea4495dcddd7/Predictive%20Analytics/Personal%20Expense%20Analysis
   ```

   </code> </td>
   </tr>

   <tr>
   <td>EmbedSecretKey</td>
   <td>Get your EmbedSecret key from the Embed tab by enabling the Enable embed authentication in the <a href="https://help.boldbi.com/site-administration/embed-settings/#get-embed-secret-code">Administration page</a> <code>

   ```js
      Example:
      EmbedSecretKey ="TVGajVPZ5M89IPfFqSnszgAzN1d6Jbkd";
   ```

</code> </td>
   </tr>

   <tr>
   <td>Embed_user_email</td>
    <td>UserEmail of the Admin in your Bold BI<code>

   ```js
      Example:
      UserEmail = "admin@domain.com";
   ```

</code></td>
</tr>
</table>

 ## Developer IDE

  * Visual studio 2022(https://visualstudio.microsoft.com/downloads/)

 ### Run a Sample Using Visual Studio 2022
 
  * Open the solution file `EmbedDashboardWithTokenAuthentication.sln` in Visual Studio.

  * Run your `Iframe token based authentication` sample in Visual Studio.

  * After starting the sample application, an `HTML` file will be generated at the specified [location](https://github.com/boldbi/iframe-token-based-authorization-sample/tree/master/EmbedDashboardWithTokenAuthentication). You can open this file in a web browser to render and view the dashboard.

    ![dashboard image](https://github.com/boldbi/aspnet-core-sample/assets/91586758/b61a18f4-6026-4379-bb7e-82844a7fdd6f)

Please refer to the [help documentation](https://help.boldbi.com/embedding-options/iframe-embedding/dashboard-with-token-based-authentication/) to know how to run the sample.

## Important notes

It is recommended not to store passwords and sensitive information in configuration files for security reasons in a real-world application. Instead, it would be best if you considered using a secure application, such as Key Vault, to safeguard your credentials.

## Online demos

Look at the Bold BI Embedding sample to live demo [here](https://samples.boldbi.com/embed).

## Documentation

A complete Bold BI Embedding documentation can be found on [Bold BI Embedding Help](https://help.boldbi.com/embedding-options/iframe-embedding/).