﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;

namespace Microsoft.VisualStudio.Threading.Analyzers
{
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public sealed class CSharpVSTHRD109AvoidAssertInAsyncMethodsAnalyzer : AbstractVSTHRD109AvoidAssertInAsyncMethodsAnalyzer
    {
        private protected override LanguageUtils LanguageUtils => CSharpUtils.Instance;
    }
}
