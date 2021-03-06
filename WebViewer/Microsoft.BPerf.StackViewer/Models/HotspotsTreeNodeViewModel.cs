﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.BPerf.StackViewer
{
    public sealed class HotspotsTreeNodeViewModel : TreeNode
    {
        public string Link => "stackviewer/callers/" + this.Id;
    }
}