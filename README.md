# Environment Styler for Sitecore
Module to allow environment specific styling (and text) on login screen and header ribbon for Sitecore 8+

Update the `sc.Environment` setting in **SC.EnvironmentStyler.config** on each different environment, either using an config patch or your deployment process.

Default values are:
- LOCAL
- DEV
- TEST
- UAT
- PREPROD
- PROD
- ANIMATED
- RAINBOW

You can use whatever value you want, just ensure a matching CSS file is located in _/sitecore modules/EnvironmentStyler/_ folder in the format `environment-override-$(sc.Environment).css`. You can also edit the existing CSS files to change the styles to suit your own requirements.

**Login Screen**

![Login Screen](screenshots/login-screen.png?raw=true "Login Screen")

**Ribon Header**

![Ribon Header](screenshots/ribbon-header.png?raw=true "Ribbon Header")
