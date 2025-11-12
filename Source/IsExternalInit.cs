// -------------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="IsExternalInit.cs" company="J.P.Hahnl">
//     Copyright © 2017 - 2025 by Syntony® / Ing. Josef Hahnl, MBA - SyntonyAustria@outlook.com - All rights reserved.
// </copyright>
// <author>Hahnl - hahnl</author>
// <email>j.p.hahnl@outlook.com</email>
// <date>12.11.2025 09:37:11</date>
// <information solution="Syntony.Nullable" project="Syntony.Nullable" framework=".NETStandard,Version=v2.0" kind="Windows (C# - csproj)">
//     <file type=".cs" created="12.11.2025 09:24:51" modified="12.11.2025 09:37:11" lastAccess="12.11.2025 09:37:11">
//         D:\Syntony\Proj\Nullable\Source\Syntony.Nullable\Source\IsExternalInit.cs
//     </file>
//     <lineStatistics total="56" contentLines="52" blankLines ="4" codeLines="20" codeRatio="35.71 %" allCommentLines="31" commentLines="31" headerLines="25"/>
//     <language>C#</language>
//     <namespace>System.Runtime.CompilerServices</namespace>
//     <class>IsExternalInit</class>
//     <identifiers>
//         <Namespace>System.Runtime.CompilerServices</Namespace>
//         <Class>IsExternalInit</Class>
//         <Record>IsExternalInit</Record>
//     </identifiers>
// </information>
// <summary>
//     Reserved for use by the compiler for tracking token. This class should not be used by developers in source code.
// </summary>
// -------------------------------------------------------------------------------------------------------------------------------------------------------------
#if !NULLABLE_ATTRIBUTES_DISABLE
#nullable enable
#pragma warning disable

namespace System.Runtime.CompilerServices
{
    using global::System;
    using global::System.Diagnostics;
    using System.ComponentModel;

#if DEBUG
    // ----------------------------------------------------------------------------------------------------------------------------------------------------------------
    // Polyfill for init-only properties support in .NET Framework 4.7.2
    // See: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-9.0/init
    // https://github.com/dotnet/runtime/blob/main/src/libraries/System.Private.CoreLib/src/System/Runtime/CompilerServices/IsExternalInit.cs
    // ----------------------------------------------------------------------------------------------------------------------------------------------------------------
#endif
#if !NULLABLE_ATTRIBUTES_INCLUDE_IN_CODE_COVERAGE
    [DebuggerNonUserCode]
#endif
#if DEBUG
    /// <summary>Reserved for use by the compiler for tracking token. This class should not be used by developers in source code.</summary>
    /// <devdoc><a href="https://github.com/dotnet/runtime/blob/main/src/libraries/System.Private.CoreLib/src/System/Runtime/CompilerServices/IsExternalInit.cs"/></devdoc>
#endif
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal static partial class IsExternalInit;
}

#pragma warning restore
#nullable restore
#endif // NULLABLE_ATTRIBUTES_DISABLE
