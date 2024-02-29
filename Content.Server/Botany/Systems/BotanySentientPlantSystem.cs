using Content.Server.Botany.Components;
using Content.Server.Chemistry.Containers.EntitySystems;
using Content.Server.Fluids.Components;
using Content.Server.Ghost.Roles.Components;
using Content.Server.NPC;
using Content.Shared.Botany;
using Content.Shared.Chemistry.Reagent;
using Content.Shared.Mobs;
using Content.Shared.Popups;
using Robust.Server.GameObjects;
using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;
using Robust.Shared.Player;
using Robust.Shared.Prototypes;
using Robust.Shared.Random;

namespace Content.Server.Botany.Systems;

public sealed class BotanySentientPlantSystem : BotanySystem
{
    [Dependency] private readonly BotanySystem _botany = default!; // for referring to botany data?
    [Dependency] private readonly NPCSystem _npc = default!;
    [Dependency] private readonly SharedPopupSystem _popupSystem = default!;

    public override void Initialize()
    {
        base.Initialize();
        SubscribeLocalEvent<SeedComponent, ???>(OnHarvest)
        SubscribeLocalEvent<BotanySentientPlantComponent, Event>(OnHarvestSentientPlant); 
    }



}
