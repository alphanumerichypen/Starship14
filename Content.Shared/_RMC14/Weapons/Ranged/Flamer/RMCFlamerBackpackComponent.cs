﻿using Robust.Shared.GameStates;

namespace Content.Shared._RMC14.Weapons.Ranged.Flamer;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
[Access(typeof(SharedRMCFlamerSystem))]
public sealed partial class RMCFlamerBackpackComponent : Component
{
    [DataField, AutoNetworkedField]
    public string SolutionId = "tank";
}
