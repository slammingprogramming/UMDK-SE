﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mdk.Notification.Windows {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Mdk.Notification.Windows.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your script was copied to the clipboard..
        /// </summary>
        internal static string App_OnCopyToClipboardClicked_CopiedToClipboard {
            get {
                return ResourceManager.GetString("App_OnCopyToClipboardClicked_CopiedToClipboard", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while copying the script to the clipboard: {0}.
        /// </summary>
        internal static string App_OnCopyToClipboardClicked_CopyToClipboardError {
            get {
                return ResourceManager.GetString("App_OnCopyToClipboardClicked_CopyToClipboardError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while opening the script folder: {0}.
        /// </summary>
        internal static string App_OnShowMeClicked_ShowMeError {
            get {
                return ResourceManager.GetString("App_OnShowMeClicked_ShowMeError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Copy to clipboard.
        /// </summary>
        internal static string App_OnStartup_CopyToClipboard {
            get {
                return ResourceManager.GetString("App_OnStartup_CopyToClipboard", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No message provided..
        /// </summary>
        internal static string App_OnStartup_CustomNotificationNoMessage {
            get {
                return ResourceManager.GetString("App_OnStartup_CustomNotificationNoMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while reading the script file: {0}.
        /// </summary>
        internal static string App_OnStartup_ErrorReadingScript {
            get {
                return ResourceManager.GetString("App_OnStartup_ErrorReadingScript", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid type
        ///Expected: script [project name] [script folder].
        /// </summary>
        internal static string App_OnStartup_InvalidType {
            get {
                return ResourceManager.GetString("App_OnStartup_InvalidType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No project name provided.
        ///Expected: script [project name] [script folder].
        /// </summary>
        internal static string App_OnStartup_NoProjectNameProvided {
            get {
                return ResourceManager.GetString("App_OnStartup_NoProjectNameProvided", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The given folder does not contain a script file..
        /// </summary>
        internal static string App_OnStartup_NoScriptFile {
            get {
                return ResourceManager.GetString("App_OnStartup_NoScriptFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No script folder was provided.
        ///Expected: script [project name] [script folder].
        /// </summary>
        internal static string App_OnStartup_NoScriptFolderProvided {
            get {
                return ResourceManager.GetString("App_OnStartup_NoScriptFolderProvided", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} nuget package has a new version available: {1} -&gt; {2}.
        /// </summary>
        internal static string App_OnStartup_NugetPackageVersionAvailable {
            get {
                return ResourceManager.GetString("App_OnStartup_NugetPackageVersionAvailable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your script &quot;{0}&quot; has been successfully deployed..
        /// </summary>
        internal static string App_OnStartup_ScriptDeployed {
            get {
                return ResourceManager.GetString("App_OnStartup_ScriptDeployed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provided script folder does not exist..
        /// </summary>
        internal static string App_OnStartup_ScriptFolderDoesNotExist {
            get {
                return ResourceManager.GetString("App_OnStartup_ScriptFolderDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Show Me.
        /// </summary>
        internal static string App_OnStartup_ShowMe {
            get {
                return ResourceManager.GetString("App_OnStartup_ShowMe", resourceCulture);
            }
        }
    }
}
