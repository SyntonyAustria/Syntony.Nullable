// -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="TargetPlatformAttribute.ExcludeFromCodeCoverage.cs" company="Syntony® / Ing. Josef Hahnl, MBA">
//     Copyright © 2017 - 2023 by Syntony® / Ing. Josef Hahnl, MBA - syntony@aon.at - All rights reserved.
// </copyright>
// <author>Ing. Josef Hahnl, MBA - Josef</author>
// <email>syntony@aon.at</email>
// <date>15.08.2024 10:53:40</date>
// <information solution="Syntony.Common.Nullable" project="Syntony.Common.Nullable" framework=".NETStandard,Version=v1.0" kind="Windows (C# - csproj)">
//     <file type=".cs" created="15.08.2024 10:51:53" modified="15.08.2024 10:53:40" lastAccess="15.08.2024 10:53:40">
//         D:\Syntony\Proj\Syntony\Framework\Source\Syntony.Common.Nullable\Source\TargetPlatformAttribute.ExcludeFromCodeCoverage.cs
//     </file>
//     <lineStatistics total="47" netLines="44" blankLines ="3" codeLines="42" codeRatio="89.36 %" allCommentLines="26" commentLines="1" headerLines="25" documentationLines="2"/>
//     <language>.cs</language>
//     <namespace>System.Runtime.Versioning</namespace>
//     <class>TargetPlatformAttribute</class>
//     <identifiers>
//         <Namespace>System.Runtime.Versioning</Namespace>
//         <Class>TargetPlatformAttribute</Class>
//         <Record>TargetPlatformAttribute</Record>
//     </identifiers>
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
#if !NULLABLE_ATTRIBUTES_INCLUDE_IN_CODE_COVERAGE
    [Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
#endif
    internal sealed partial class TargetPlatformAttribute : OSPlatformAttribute
    { }
}

#pragma warning restore
#nullable restore
#endif // NULLABLE_ATTRIBUTES_DISABLE
