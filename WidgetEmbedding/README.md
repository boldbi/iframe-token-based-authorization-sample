# Embed Widget with SSO using Token

This sample demonstrates the embedding the widget with iFrame based Single Sign-On(SSO) using token based authentication.

## Widget view

![Widget View](https://github.com/boldbi/blazor-webassembly-sample/assets/91586758/a4fc2b3a-33ff-4225-be1e-027a38ff348c)

### Help link

* <https://help.boldbi.com/embedded-bi/faq/where-can-i-find-the-product-version?utm_source=github&utm_medium=backlinks>

### Supported browsers
  
* Google Chrome, Microsoft Edge, Mozilla Firefox.

## Configuration

  1. Requires the following properties to be configured as mandatory:
      * DashboardURL
      * EmbedSecretKey
      * EmbedUserEmail

| **Parameter**        | **Description**                                                                                                                                                                                                                                                                               |
|----------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| **Dashboard URL**    | URL of the dashboard widget to be embed. Refer this [link](https://help.boldbi.com/embedding-options/iframe-embedding/embedding-a-widget/#how-to-get-the-embed-widget-url?utm_source=github&utm_medium=backlinks) to get the URL. **Example:** ``` http://test.boldbi.com/bi/en-us/site/site1/dashboards/8428c9d9-85db-418c-b877-ea4495dcddd7/Predictive%20Analytics/Personal%20Expense%20Analysis?isWidgetMode=true&widgetId=0000aeab-3359-40c6-b014-1ea98e9a7ce9 ``` |
| **EmbedSecretKey**   | Get your EmbedSecret key from the Embed tab by enabling the Enable embed authentication in the [Administration page](https://help.boldbi.com/site-administration/embed-settings/#get-embed-secret-code?utm_source=github&utm_medium=backlinks). **Example:** ``` EmbedSecretKey = "TVGajVPZ5M89IPfFqSnszgAzN1d6Jbkd"; ``` |
| **Embed User Email** | UserEmail of the Admin in your Bold BI. **Example:** ``` Embed_User_Email = "test@domain.com"; ```                                                                                                                                                                                            |

## Developer IDE

* Visual studio 2022(<https://visualstudio.microsoft.com/downloads/>)

### Run a Sample Using Visual Studio 2022

* Open the solution file `EmbedWidgetswithSSOusingToken.sln` in Visual Studio.

* The properties `DashboardURL`, `EmbedSecretKey`, and `EmbedUserEmail` must be configured as mandatory.

* Run your `EmbedWidgetswithSSOusingToken` sample in Visual Studio.

    ![widget image](https://github.com/boldbi/blazor-webassembly-sample/assets/91586758/a4fc2b3a-33ff-4225-be1e-027a38ff348c)

> **NOTE:** The default behavior is to display `iframe` content in the `Chrome` browser. If you do not have `Chrome`, please manually retrieve the `iframe` content from the application.

Please refer to the [help documentation](https://help.boldbi.com/embedding-options/iframe-embedding/embed-widgets-with-sso-using-token?utm_source=github&utm_medium=backlinks) to know how to run the sample.

## Important notes

It is recommended not to store passwords and sensitive information in configuration files for security reasons in a real-world application. Instead, it would be best if you considered using a secure application, such as Key Vault, to safeguard your credentials.

## Online demos

Look at the Bold BI Embedding sample to live demo [here](https://samples.boldbi.com/embed?utm_source=github&utm_medium=backlinks).

## Documentation

A complete Bold BI Embedding documentation can be found on [Bold BI Embedding Help](https://help.boldbi.com/embedding-options/iframe-embedding?utm_source=github&utm_medium=backlinks).
