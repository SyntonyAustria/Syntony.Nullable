// -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="TargetPlatformAttribute.cs" company="Syntony® / Ing. Josef Hahnl, MBA">
//     Copyright © 2017 - 2023 by Syntony® / Ing. Josef Hahnl, MBA - syntony@aon.at - All rights reserved.
// </copyright>
// <author>Ing. Josef Hahnl, MBA - Josef</author>
// <email>syntony@aon.at</email>
// <date>15.08.2024 10:52:45</date>
// <information solution="Syntony.Common.Nullable" project="Syntony.Common.Nullable" framework=".NETStandard,Version=v1.0" kind="Windows (C# - csproj)">
//     <file type=".cs" created="24.01.2024 14:12:44" modified="15.08.2024 10:52:45" lastAccess="15.08.2024 10:52:45">
//         D:\Syntony\Proj\Syntony\Framework\Source\Syntony.Common.Nullable\Source\TargetPlatformAttribute.cs
//     </file>
//     <lineStatistics total="78" netLines="74" blankLines ="4" codeLines="70" codeRatio="89.74 %" allCommentLines="33" commentLines="2" headerLines="31" documentationLines="4"/>
//     <language>C#</language>
//     <namespace>System.Runtime.Versioning</namespace>
//     <class>TargetPlatformAttribute</class>
//     <identifiers>
//         <Namespace>System.Runtime.Versioning</Namespace>
//         <Class>TargetPlatformAttribute</Class>
//         <Class>OSPlatformAttribute</Class>
//         <Record>TargetPlatformAttribute</Record>
//         <Record>OSPlatformAttribute</Record>
//     </identifiers>
//     <codeMetric>
//         <numberOfUsings>1</numberOfUsings>
//         <numberOfMethods>2</numberOfMethods>
//         <numberOfProperties>1</numberOfProperties>
//         <numberOfAttributes>3</numberOfAttributes>
//     </codeMetric>
// </information>
// <summary>
//     Records the platform that the project targeted.
// </summary>
// -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
#if !NULLABLE_ATTRIBUTES_DISABLE
#nullable enable
#pragma warning disable

namespace System.Runtime.Versioning
{
    using global::System;

#if DEBUG
    /// <summary>Records the platform that the project targeted.</summary>
    /// <devdoc><a href="https://github.com/dotnet/runtime/blob/main/src/libraries/System.Private.CoreLib/src/System/Runtime/Versioning/PlatformAttributes.cs"/></devdoc>
#endif
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false, Inherited = false)]
#if !NULLABLE_ATTRIBUTES_INCLUDE_IN_CODE_COVERAGE
    [System.Diagnostics.DebuggerNonUserCode]
#endif
    internal sealed partial class TargetPlatformAttribute : OSPlatformAttribute
    {
#if DEBUG
        /// <summary>Initializes a new instance of the <see cref="TargetPlatformAttribute"/> class.</summary>
#endif
        public TargetPlatformAttribute(string platformName) : base(platformName)
        {
        }
    }

#pragma warning disable CS3015 // Type has no accessible constructors which use only CLS-compliant types
#if DEBUG
    /// <summary>Base type for all platform-specific API attributes.</summary>
#endif
#if !NULLABLE_ATTRIBUTES_INCLUDE_IN_CODE_COVERAGE
    [System.Diagnostics.DebuggerNonUserCode]
#endif
    internal abstract class OSPlatformAttribute : Attribute
#pragma warning restore CS3015
    {
        private protected OSPlatformAttribute(string platformName)
        {
            PlatformName = platformName;
        }
        public string PlatformName { get; }
    }
}

#pragma warning restore
#nullable restore
#endif // NULLABLE_ATTRIBUTES_DISABLE
