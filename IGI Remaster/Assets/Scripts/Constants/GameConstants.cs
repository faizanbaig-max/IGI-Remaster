using System;
using UnityEngine;

public class GameConstants
{
    public const float PlayerMovementSpeed=5;

    public const string Keyboard_Horizontal ="Horizontal";
    public const string Keyboard_Vertical = "Vertical";
    public const string Mouse_Horizontal = "Mouse X";
    public const string Mouse_Vertical = "Mouse Y";


}
[Serializable]
public enum CharacterType
{
    Player,
    Enemy,
    NPC
}
[Serializable]
public enum ItemType
{
    HandGun,
    LightWightGun,
    RIfle,
    HeavyGun,
    Shortgun,
    RocketLauncher,
    SniperRifle,
    Gernade,
    SmaokeBomb,
    AttachableMine,

}
[Serializable]
public enum EnviornmentItems
{
    Breakable,
    Explodable,
    NonDamageable

}
 





