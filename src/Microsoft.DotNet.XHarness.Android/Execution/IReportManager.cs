﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.DotNet.XHarness.Android.Execution
{
    internal interface IReportManager
    {
        string DumpBugReport(AdbRunner runner, string outputFilePathWithoutFormat);
    }
}
