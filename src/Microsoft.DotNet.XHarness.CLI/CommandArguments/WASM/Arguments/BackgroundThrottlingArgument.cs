﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.DotNet.XHarness.CLI.CommandArguments.Wasm
{
    internal class BackgroundThrottlingArgument : SwitchArgument
    {
        public BackgroundThrottlingArgument()
            : base("background-throttling", "Hide browser tab and don't prevent timer throttling", false)
        {
        }
    }
}
