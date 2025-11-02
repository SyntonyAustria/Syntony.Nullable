// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="SupportedOSPlatformGuardAttribute.ExcludeFromCodeCoverage.cs" company="Syntony® / Ing. Josef Hahnl, MBA">
//     Copyright © 2017 - 2023 by Syntony® / Ing. Josef Hahnl, MBA - syntony@aon.at - All rights reserved.
// </copyright>
// <author>Ing. Josef Hahnl, MBA - Josef</author>
// <email>syntony@aon.at</email>
// <date>15.08.2024 11:19:29</date>
// <information solution="Syntony.Common.Nullable" project="Syntony.Common.Nullable" framework=".NETStandard,Version=v1.0" kind="Windows (C# - csproj)">
//     <file type=".cs" created="15.08.2024 11:18:38" modified="15.08.2024 11:19:29" lastAccess="15.08.2024 11:19:29">
//         D:\Syntony\Proj\Syntony\Framework\Source\Syntony.Common.Nullable\Source\SupportedOSPlatformGuardAttribute.ExcludeFromCodeCoverage.cs
//     </file>
//     <lineStatistics total="51" netLines="48" blankLines ="3" codeLines="42" codeRatio="82.35 %" allCommentLines="26" commentLines="1" headerLines="25" documentationLines="6"/>
//     <language>.cs</language>
//     <namespace>System.Runtime.Versioning</namespace>
//     <class>SupportedOSPlatformGuardAttribute</class>
//     <identifiers>
//         <Namespace>System.Runtime.Versioning</Namespace>
//         <Class>SupportedOSPlatformGuardAttribute</Class>
//         <Record>SupportedOSPlatformGuardAttribute</Record>
//     </identifiers>
// </information>
// <summary>
//     Annotates a custom guard field, property or method with a supported platform name and optional version. Multiple attributes can be applied to indicate guard for multiple supported platforms.
// </summary>
// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
#if !NULLABLE_ATTRIBUTES_DISABLE
#nullable enable
#pragma warning disable

namespace System.Runtime.Versioning
{
    using global::System;

#if DEBUG
    /// <summary>Annotates a custom guard field, property or method with a supported platform name and optional version.
    /// Multiple attributes can be applied to indicate guard for multiple supported platforms.</summary>
    /// <remarks>Callers can apply a <see cref="SupportedOSPlatformGuardAttribute " /> to a field, property or method
    /// and use that field, property or method in a conditional or assert statements in order to safely call platform specific APIs.
    /// The type of the field or property should be boolean, the method return type should be boolean in order to be used as platform guard.</remarks>
    /// <devdoc><a href="https://github.com/dotnet/runtime/blob/main/src/libraries/System.Private.CoreLib/src/System/Runtime/Versioning/PlatformAttributes.cs"/></devdoc>
#endif
#if !NULLABLE_ATTRIBUTES_INCLUDE_IN_CODE_COVERAGE
    [Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
#endif
    internal sealed partial class SupportedOSPlatformGuardAttribute : OSPlatformAttribute
    { }
}

#pragma warning restore
#nullable restore
#endif // NULLABLE_ATTRIBUTES_DISABLE
