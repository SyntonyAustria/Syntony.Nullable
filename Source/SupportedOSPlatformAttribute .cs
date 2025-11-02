// -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="SupportedOSPlatformAttribute .cs" company="Syntony® / Ing. Josef Hahnl, MBA">
//     Copyright © 2017 - 2023 by Syntony® / Ing. Josef Hahnl, MBA - syntony@aon.at - All rights reserved.
// </copyright>
// <author>Ing. Josef Hahnl, MBA - Josef</author>
// <email>syntony@aon.at</email>
// <date>15.08.2024 11:10:24</date>
// <information solution="Syntony.Common.Nullable" project="Syntony.Common.Nullable" framework=".NETStandard,Version=v1.0" kind="Windows (C# - csproj)">
//     <file type=".cs" created="15.08.2024 11:00:56" modified="15.08.2024 11:10:24" lastAccess="15.08.2024 11:10:24">
//         D:\Syntony\Proj\Syntony\Framework\Source\Syntony.Common.Nullable\Source\SupportedOSPlatformAttribute .cs
//     </file>
//     <lineStatistics total="74" netLines="71" blankLines ="3" codeLines="65" codeRatio="87.84 %" allCommentLines="31" commentLines="1" headerLines="30" documentationLines="6"/>
//     <language>C#</language>
//     <namespace>System.Runtime.Versioning</namespace>
//     <class>SupportedOSPlatformAttribute</class>
//     <identifiers>
//         <Namespace>System.Runtime.Versioning</Namespace>
//         <Class>SupportedOSPlatformAttribute</Class>
//         <Record>SupportedOSPlatformAttribute</Record>
//     </identifiers>
//     <codeMetric>
//         <numberOfUsings>1</numberOfUsings>
//         <numberOfMethods>1</numberOfMethods>
//         <numberOfAttributes>2</numberOfAttributes>
//     </codeMetric>
// </information>
// <summary>
//     Records the operating system (and minimum version) that supports an API. Multiple attributes can be applied to indicate support on multiple operating systems.
// </summary>
// -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
#if !NULLABLE_ATTRIBUTES_DISABLE
#nullable enable
#pragma warning disable

namespace System.Runtime.Versioning
{
    using global::System;

#if DEBUG
    /// <summary> Records the operating system (and minimum version) that supports an API. Multiple attributes can be
    /// applied to indicate support on multiple operating systems.</summary>
    /// <remarks> Callers can apply a <see cref="SupportedOSPlatformAttribute " /> or use guards to prevent calls to APIs on unsupported operating systems.
    /// A given platform should only be specified once. </remarks>
    /// <devdoc><a href="https://github.com/dotnet/runtime/blob/main/src/libraries/System.Private.CoreLib/src/System/Runtime/Versioning/PlatformAttributes.cs"/></devdoc>
#endif
    [AttributeUsage(AttributeTargets.Assembly |
                    AttributeTargets.Class |
                    AttributeTargets.Constructor |
                    AttributeTargets.Enum |
                    AttributeTargets.Event |
                    AttributeTargets.Field |
                    AttributeTargets.Interface |
                    AttributeTargets.Method |
                    AttributeTargets.Module |
                    AttributeTargets.Property |
                    AttributeTargets.Struct,
        AllowMultiple = true, Inherited = false)]
#if !NULLABLE_ATTRIBUTES_INCLUDE_IN_CODE_COVERAGE
    [System.Diagnostics.DebuggerNonUserCode]
#endif
    internal sealed partial class SupportedOSPlatformAttribute : OSPlatformAttribute
    {
#if DEBUG
        /// <summary>Initializes a new instance of the <see cref="SupportedOSPlatformAttribute"/> class.</summary>
#endif
        public SupportedOSPlatformAttribute(string platformName) : base(platformName)
        {
        }
    }
}

#pragma warning restore
#nullable restore
#endif // NULLABLE_ATTRIBUTES_DISABLE
