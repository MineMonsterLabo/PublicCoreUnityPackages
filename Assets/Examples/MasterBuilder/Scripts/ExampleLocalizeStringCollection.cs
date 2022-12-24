﻿using System;
using MasterBuilder.Attributes;
using MasterBuilder.BuildIn;

namespace MasterBuilder.Examples
{
    public class ExampleLocalizeStringCollection : LocalizeStringCollection<ExampleLocalizeString>
    {
    }

    [Serializable]
    [MasterAsset(AssetPath = "Assets/Examples/MasterBuilder/Resources/Masters/Master")]
    [Master(Contexts = new[] { "default", "en-US" })]
    public class ExampleLocalizeString : LocalizeString
    {
    }
}