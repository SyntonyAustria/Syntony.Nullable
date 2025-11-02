// -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="UnsupportedOSPlatformAttribute.cs" company="Syntony® / Ing. Josef Hahnl, MBA">
//     Copyright © 2017 - 2023 by Syntony® / Ing. Josef Hahnl, MBA - syntony@aon.at - All rights reserved.
// </copyright>
// <author>Ing. Josef Hahnl, MBA - Josef</author>
// <email>syntony@aon.at</email>
// <date>15.08.2024 11:08:48</date>
// <information solution="Syntony.Common.Nullable" project="Syntony.Common.Nullable" framework=".NETStandard,Version=v1.0" kind="Windows (C# - csproj)">
//     <file type=".cs" created="15.08.2024 11:07:38" modified="15.08.2024 11:08:48" lastAccess="15.08.2024 11:08:48">
//         D:\Syntony\Proj\Syntony\Framework\Source\Syntony.Common.Nullable\Source\UnsupportedOSPlatformAttribute.cs
//     </file>
//     <lineStatistics total="78" netLines="75" blankLines ="3" codeLines="71" codeRatio="91.03 %" allCommentLines="32" commentLines="1" headerLines="31" documentationLines="4"/>
//     <language>C#</language>
//     <namespace>System.Runtime.Versioning</namespace>
//     <class>UnsupportedOSPlatformAttribute</class>
//     <identifiers>
//         <Namespace>System.Runtime.Versioning</Namespace>
//         <Class>UnsupportedOSPlatformAttribute</Class>
//         <Record>UnsupportedOSPlatformAttribute</Record>
//     </identifiers>
//     <codeMetric>
//         <numberOfUsings>1</numberOfUsings>
//         <numberOfMethods>2</numberOfMethods>
//         <numberOfProperties>1</numberOfProperties>
//         <numberOfAttributes>2</numberOfAttributes>
//     </codeMetric>
// </information>
// <summary>
//     Marks APIs that were removed in a given operating system version.
// </summary>
// -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
#if !NULLABLE_ATTRIBUTES_DISABLE
#nullable enable
#pragma warning disable

namespace System.Runtime.Versioning
{
    using global::System;

#if DEBUG
    /// <summary>Marks APIs that were removed in a given operating system version.</summary>
    /// <remarks>Primarily used by OS bindings to indicate APIs that are only available in earlier versions.</remarks>
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
    internal sealed partial class UnsupportedOSPlatformAttribute : OSPlatformAttribute
    {
#if DEBUG
        /// <summary>Initializes a new instance of the <see cref="UnsupportedOSPlatformAttribute"/> class.</summary>
#endif
        public UnsupportedOSPlatformAttribute(string platformName) : base(platformName)
        {
        }
        public UnsupportedOSPlatformAttribute(string platformName, string? message) : base(platformName)
        {
            Message = message;
        }
        public string? Message { get; }
    }
}

#pragma warning restore
#nullable restore
#endif // NULLABLE_ATTRIBUTES_DISABLE
