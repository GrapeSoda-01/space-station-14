﻿using Robust.Shared.Prototypes;
using Robust.Shared.Serialization.Manager.Attributes;

namespace Content.Shared.Body.Prototypes
{
    [Prototype("metabolismGroup")]
    public sealed class MetabolismGroupPrototype : IPrototype
    {
        [IdDataFieldAttribute]
        public string ID { get; } = default!;
    }
}
