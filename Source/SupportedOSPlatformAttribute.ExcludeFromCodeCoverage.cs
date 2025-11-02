// -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="SupportedOSPlatformAttribute.ExcludeFromCodeCoverage.cs" company="Syntony® / Ing. Josef Hahnl, MBA">
//     Copyright © 2017 - 2023 by Syntony® / Ing. Josef Hahnl, MBA - syntony@aon.at - All rights reserved.
// </copyright>
// <author>Ing. Josef Hahnl, MBA - Josef</author>
// <email>syntony@aon.at</email>
// <date>15.08.2024 11:10:19</date>
// <information solution="Syntony.Common.Nullable" project="Syntony.Common.Nullable" framework=".NETStandard,Version=v1.0" kind="Windows (C# - csproj)">
//     <file type=".cs" created="15.08.2024 11:02:31" modified="15.08.2024 11:10:19" lastAccess="15.08.2024 11:10:19">
//         D:\Syntony\Proj\Syntony\Framework\Source\Syntony.Common.Nullable\Source\SupportedOSPlatformAttribute.ExcludeFromCodeCoverage.cs
//     </file>
//     <lineStatistics total="50" netLines="47" blankLines ="3" codeLines="42" codeRatio="84.00 %" allCommentLines="26" commentLines="1" headerLines="25" documentationLines="5"/>
//     <language>.cs</language>
//     <namespace>System.Runtime.Versioning</namespace>
//     <class>SupportedOSPlatformAttribute</class>
//     <identifiers>
//         <Namespace>System.Runtime.Versioning</Namespace>
//         <Class>SupportedOSPlatformAttribute</Class>
//         <Record>SupportedOSPlatformAttribute</Record>
//     </identifiers>
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
#if !NULLABLE_ATTRIBUTES_INCLUDE_IN_CODE_COVERAGE
    [Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
#endif
    internal sealed partial class SupportedOSPlatformAttribute : OSPlatformAttribute
    { }
}

#pragma warning restore
#nullable restore
#endif // NULLABLE_ATTRIBUTES_DISABLE
