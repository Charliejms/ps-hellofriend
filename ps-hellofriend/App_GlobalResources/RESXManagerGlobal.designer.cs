//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option or rebuild the Visual Studio project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Web.Application.StronglyTypedResourceProxyBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class RESXManagerGlobal {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal RESXManagerGlobal() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Resources.RESXManagerGlobal", global::System.Reflection.Assembly.Load("App_GlobalResources"));
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
        ///   Looks up a localized string similar to You have added/removed &quot;##SelectedCultureFullName##&quot; resource files. Because you are running in Medium trust mode or below, please go to &lt;span style=&quot;color:red;&quot;&gt;ROOT_OF_YOUR_SITE\\config\\RESXManager.config&lt;/span&gt; file and add/remove the following entry manually:
        ///&lt;br/&gt;
        ///In setting&apos;s &lt;span style=&quot;color:red;&quot;&gt;key=&quot;Main.Languages&quot;&lt;/span&gt; add/remove to &lt;span style=&quot;color:red;&quot;&gt;value&lt;/span&gt; attribute &quot;&lt;span style=&quot;color:red;&quot;&gt;##SelectedCulture##&lt;/span&gt;&quot;. 
        ///&lt;br/&gt;
        ///Note that different cultures in &lt;span style=&quot;co [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string MediumTrustAddRemoveLanguageFromConfig {
            get {
                return ResourceManager.GetString("MediumTrustAddRemoveLanguageFromConfig", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You are running in Medium trust mode or below.
        /// </summary>
        internal static string MediumTrustTitle {
            get {
                return ResourceManager.GetString("MediumTrustTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You have modified the data entry fields since last savings. If you leave this page, any changes will be lost. To save these changes, click Cancel to return to the page, and then Save the data..
        /// </summary>
        internal static string ModifiedDataPromptMessage {
            get {
                return ResourceManager.GetString("ModifiedDataPromptMessage", resourceCulture);
            }
        }
    }
}
