# Licensing

## Evaluation Period
You can evaluate our library for several months before purchasing it.

The trial period stops at the end of the month. When you receive a license expiration error, download the latest version which will automatically extend your trial period.

You can also purchase the library [here](/pricing)

Upon purchase, you will receive a license name and a license key.

## How can I get a free license for a personal or academic purpose?
We don't offer free licenses.

However, you can benefit from all the prime features for personal or academic projects for free by downloading the trial at the beginning of every month.

## Setup License from config file
The license name and key can be added directly in the app.config or web.config file in the appSettings section.


```csharp
<appSettings>
	<add key="Z_Expressions_Eval_LicenseName" value="[licenseName]"/>
	<add key="Z_Expressions_Eval_LicenseKey" value="[licenseKey]"/>
</appSettings>
```

## Setup License from appsettings.json file (.NET Core)
The license name and key can be added directly in the appsettings.json.

```csharp
{
  "Z.Expressions.Eval": {
    "LicenseName": "[licenseName]",
    "LicenseKey": "[licenseKey]"
  }
}
```

## Setup License from code
You can also set the license name and key directly in the code.


```csharp
// using Z.Expressions; // Don't forget to include this.

string licenseName = //... PRO license name
string licenseKey = //... PRO license key

EvalManager.AddLicense(licenseName, licenseKey);
```

### Recommendation
- Use the config file to store your license name and license key.
- **Web App:** Use Application_Start in global.asax to activate your license.
- **WinForm App:** Use the main thread method to activate your license.
- **Win Service:** Use the OnStart method to activate your license

> The AddLicense must be set before the first call to the library. Otherwise, you will start the evaluation period

## How can I check if my license is valid?
The validate method allows you to know whether your license is valid or not.

```csharp
string licenseErrorMessage;
if (!Z.Expressions.EvalManager.ValidateLicense(out licenseErrorMessage))
{
    throw new Exception(licenseErrorMessage);
}
```
