﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tru.Repo.Scripts {
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
    internal class RepoScript {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal RepoScript() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Tru.Repo.Scripts.RepoScript", typeof(RepoScript).Assembly);
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
        ///   Looks up a localized string similar to IF (NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = &apos;Tru&apos; AND TABLE_NAME = &apos;Repo&apos;))
        ///	SELECT -1
        ///ELSE IF (NOT EXISTS (SELECT * FROM Tru.Repo WHERE RepoName = @RepoName))
        ///	SELECT -1
        ///ELSE
        ///	SELECT MAX(PatchVersion) FROM [Tru].[Repo] WHERE RepoName = @RepoName.
        /// </summary>
        internal static string GetMaxPatchVersion {
            get {
                return ResourceManager.GetString("GetMaxPatchVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE SCHEMA Tru
        ///
        ///CREATE TABLE Tru.Repo
        ///(
        ///	RepoName NVARCHAR(100) NOT NULL,
        ///	PatchVersion INT NOT NULL,
        ///	PatchDateUtc DATETIME NOT NULL,
        ///	PatchText NVARCHAR(MAX) NOT NULL,
        ///	CONSTRAINT PK_Tru_Repo_RepoName_PatchVersion PRIMARY KEY CLUSTERED (RepoName, PatchVersion)
        ///).
        /// </summary>
        internal static string Patch0 {
            get {
                return ResourceManager.GetString("Patch0", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO Tru.Repo VALUES(@RepoName, @PatchVersion, GETUTCDATE(), @PatchText).
        /// </summary>
        internal static string RegisterPatch {
            get {
                return ResourceManager.GetString("RegisterPatch", resourceCulture);
            }
        }
    }
}
