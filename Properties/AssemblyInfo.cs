using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rhino.PlugIns;


[assembly: PlugInDescription(DescriptionType.Email, "alha@kadk.dk")]
[assembly: PlugInDescription(DescriptionType.Organization, "Ayoub Lharchi")]
[assembly: PlugInDescription(DescriptionType.WebSite, "https://www.lharchi.com/tools/assemblysimulator")]

// Icons should be Windows .ico files and contain 32-bit images in the following sizes: 16, 24, 32, 48, and 256.
// This is a Rhino 6-only description.
[assembly: PlugInDescription(DescriptionType.Icon, "AIM_RH.EmbeddedResources.plugin-utility.ico")]

[assembly: AssemblyTitle("Assembly Simulator")]

// This will be used also for the plug-in description.
[assembly: AssemblyDescription("Assembly Simulator")]

[assembly: AssemblyCompany("KADK")]
[assembly: AssemblyProduct("Assembly Simulator")]
[assembly: AssemblyCopyright("Copyright ©  2018")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("31a12a1d-91c5-4a77-984e-5b5478b6ffa5")] // This will also be the Guid of the Rhino plug-in

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]

[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

// Make compatible with Rhino Installer Engine
[assembly: AssemblyInformationalVersion("2")]
