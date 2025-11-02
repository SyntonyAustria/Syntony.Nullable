// ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="UnsupportedOSPlatformGuardAttribute.ExcludeFromCodeCoverage.cs" company="Syntony® / Ing. Josef Hahnl, MBA">
//     Copyright © 2017 - 2023 by Syntony® / Ing. Josef Hahnl, MBA - syntony@aon.at - All rights reserved.
// </copyright>
// <author>Ing. Josef Hahnl, MBA - Josef</author>
// <email>syntony@aon.at</email>
// <date>15.08.2024 11:27:39</date>
// <information solution="Syntony.Common.Nullable" project="Syntony.Common.Nullable" framework=".NETStandard,Version=v1.0" kind="Windows (C# - csproj)">
//     <file type=".cs" created="15.08.2024 11:27:05" modified="15.08.2024 11:27:39" lastAccess="15.08.2024 11:27:39">
//         D:\Syntony\Proj\Syntony\Framework\Source\Syntony.Common.Nullable\Source\UnsupportedOSPlatformGuardAttribute.ExcludeFromCodeCoverage.cs
//     </file>
//     <lineStatistics total="51" netLines="48" blankLines ="3" codeLines="42" codeRatio="82.35 %" allCommentLines="26" commentLines="1" headerLines="25" documentationLines="6"/>
//     <language>.cs</language>
//     <namespace>System.Runtime.Versioning</namespace>
//     <class>UnsupportedOSPlatformGuardAttribute</class>
//     <identifiers>
//         <Namespace>System.Runtime.Versioning</Namespace>
//         <Class>UnsupportedOSPlatformGuardAttribute</Class>
//         <Record>UnsupportedOSPlatformGuardAttribute</Record>
//     </identifiers>
// </information>
// <summary>
//     Annotates the custom guard field, property or method with an unsupported platform name and optional version. Multiple attributes can be applied to indicate guard for multiple unsupported platforms.
// </summary>
// ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
#if !NULLABLE_ATTRIBUTES_DISABLE
#nullable enable
#pragma warning disable

namespace System.Runtime.Versioning
{
    using global::System;

#if DEBUG
    /// <summary>Annotates the custom guard field, property or method with an unsupported platform name and optional version.
    /// Multiple attributes can be applied to indicate guard for multiple unsupported platforms.</summary>
    /// <remarks>Callers can apply a <see cref="UnsupportedOSPlatformGuardAttribute " /> to a field, property or method
    /// and use that  field, property or method in a conditional or assert statements as a guard to safely call APIs unsupported on those platforms.
    /// The type of the field or property should be boolean, the method return type should be boolean in order to be used as platform guard.</remarks>
    /// <devdoc><a href="https://github.com/dotnet/runtime/blob/main/src/libraries/System.Private.CoreLib/src/System/Runtime/Versioning/PlatformAttributes.cs"/></devdoc>
#endif
#if !NULLABLE_ATTRIBUTES_INCLUDE_IN_CODE_COVERAGE
    [Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
#endif
    internal sealed partial class UnsupportedOSPlatformGuardAttribute : OSPlatformAttribute
    { }
}

#pragma warning restore
#nullable restore
#endif // NULLABLE_ATTRIBUTES_DISABLE
