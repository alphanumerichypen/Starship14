﻿using Content.Shared.DoAfter;
using Robust.Shared.Serialization;

namespace Content.Shared._RMC14.Flag;

[Serializable, NetSerializable]
public sealed partial class PlantableFlagRemoveDoAfterEvent : SimpleDoAfterEvent;
