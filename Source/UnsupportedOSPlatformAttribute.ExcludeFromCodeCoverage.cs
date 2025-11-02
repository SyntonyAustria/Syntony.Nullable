// -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="UnsupportedOSPlatformAttribute.ExcludeFromCodeCoverage.cs" company="Syntony® / Ing. Josef Hahnl, MBA">
//     Copyright © 2017 - 2023 by Syntony® / Ing. Josef Hahnl, MBA - syntony@aon.at - All rights reserved.
// </copyright>
// <author>Ing. Josef Hahnl, MBA - Josef</author>
// <email>syntony@aon.at</email>
// <date>15.08.2024 11:12:38</date>
// <information solution="Syntony.Common.Nullable" project="Syntony.Common.Nullable" framework=".NETStandard,Version=v1.0" kind="Windows (C# - csproj)">
//     <file type=".cs" created="15.08.2024 11:08:58" modified="15.08.2024 11:12:38" lastAccess="15.08.2024 11:12:38">
//         D:\Syntony\Proj\Syntony\Framework\Source\Syntony.Common.Nullable\Source\UnsupportedOSPlatformAttribute.ExcludeFromCodeCoverage.cs
//     </file>
//     <lineStatistics total="48" netLines="45" blankLines ="3" codeLines="42" codeRatio="87.50 %" allCommentLines="26" commentLines="1" headerLines="25" documentationLines="3"/>
//     <language>.cs</language>
//     <namespace>System.Runtime.Versioning</namespace>
//     <class>UnsupportedOSPlatformAttribute</class>
//     <identifiers>
//         <Namespace>System.Runtime.Versioning</Namespace>
//         <Class>UnsupportedOSPlatformAttribute</Class>
//         <Record>UnsupportedOSPlatformAttribute</Record>
//     </identifiers>
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
#if !NULLABLE_ATTRIBUTES_INCLUDE_IN_CODE_COVERAGE
    [Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
#endif
    internal sealed partial class UnsupportedOSPlatformAttribute : OSPlatformAttribute
    { }
}

#pragma warning restore
#nullable restore
#endif // NULLABLE_ATTRIBUTES_DISABLE
