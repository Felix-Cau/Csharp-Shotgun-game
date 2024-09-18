using Examinationsuppgift2.EntityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examinationsuppgift2.HelperClasses
{
    public static class EventResolver
    {
        public static (Player, Npc) CalculateResolution(Player player, Npc npc)
        {
            Player _localPlayer = player;
            Npc _localNpc = npc;
            ActionOptionsEnum playerAction = _localPlayer.ActionState;
            ActionOptionsEnum npcAction = npc.ActionState;

            switch (playerAction)
            {
                case ActionOptionsEnum.Load:
                    if (npcAction == ActionOptionsEnum.Load)
                    {
                        _localPlayer.AmmoCount++;
                        _localNpc.AmmoCount++;
                        return (_localPlayer, _localNpc);
                    }
                    else if (npcAction == ActionOptionsEnum.Block)
                    {
                        _localPlayer.AmmoCount++;
                        return (_localPlayer, _localNpc);
                    }
                    else if (npcAction == ActionOptionsEnum.Shoot)
                    {
                        _localPlayer.AmountOfLosses++;
                        _localNpc.AmmoCount--;
                        return (_localPlayer, _localNpc);
                    }
                    else
                    {
                        _localPlayer.AmountOfLosses++;
                        _localNpc.AmmoCount -= 3;
                        return (_localPlayer, _localNpc);
                    }
                case ActionOptionsEnum.Block:
                    if (npcAction == ActionOptionsEnum.Load)
                    {
                        _localNpc.AmmoCount++;
                        return (_localPlayer, _localNpc);
                    }
                    else if (npcAction == ActionOptionsEnum.Block)
                    {
                        return (_localPlayer, _localNpc);
                    }
                    else if (npcAction == ActionOptionsEnum.Shoot)
                    {
                        _localNpc.AmmoCount--;
                        return (_localPlayer, _localNpc);
                    }
                    else
                    {
                        _localPlayer.AmountOfLosses++;
                        _localNpc.AmmoCount -= 3;
                        return (_localPlayer, _localNpc);
                    }
                case ActionOptionsEnum.Shoot:
                    if (npcAction == ActionOptionsEnum.Load)
                    {
                        _localPlayer.AmountOfWins++;
                        _localPlayer.AmmoCount--;
                        return (_localPlayer, _localNpc);
                    }
                    else if (npcAction == ActionOptionsEnum.Block)
                    {
                        _localPlayer.AmmoCount--;
                        return (_localPlayer, _localNpc);
                    }
                    else if (npcAction == ActionOptionsEnum.Shoot)
                    {
                        _localPlayer.AmmoCount--;
                        _localNpc.AmmoCount--;
                        return (_localPlayer, _localNpc);
                    }
                    else
                    {
                        _localPlayer.AmmoCount--;
                        _localPlayer.AmountOfLosses++;
                        _localNpc.AmmoCount -= 3;
                        return (_localPlayer, _localNpc);
                    }
                case ActionOptionsEnum.Shotgun:
                    if (npcAction == ActionOptionsEnum.Load)
                    {
                        _localPlayer.AmountOfWins++;
                        _localPlayer.AmmoCount -= 3;
                        return (_localPlayer, _localNpc);
                    }
                    else if (npcAction == ActionOptionsEnum.Block)
                    {
                        _localPlayer.AmountOfWins++;
                        _localPlayer.AmmoCount -= 3;
                        return (_localPlayer, _localNpc);
                    }
                    else if (npcAction == ActionOptionsEnum.Shoot)
                    {
                        _localPlayer.AmountOfWins++;
                        _localPlayer.AmmoCount -= 3;
                        _localNpc.AmmoCount--;
                        return (_localPlayer, _localNpc);
                    }
                    else
                    {
                        _localPlayer.AmmoCount -= 3;
                        _localNpc.AmmoCount -= 3;
                        return (_localPlayer, _localNpc);
                    }
                default:
                    return (_localPlayer, _localNpc);
            }
        }
    }
}