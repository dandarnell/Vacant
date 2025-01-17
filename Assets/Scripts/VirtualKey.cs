﻿/// <summary>
/// Represents the logical outcome of pressing a key, allowing
/// multiple physical keys to map to the same logical behavior.
/// Authors: Scott Clarke and Daniel Darnell.
/// </summary>
public enum VirtualKey
{
    /// <summary>
    /// A key that will perform any behavior associated with holding right (e.g. moving rightward).
    /// </summary>
    Right,

    /// <summary>
    /// A key that will perform any behavior associated with holding left (e.g. moving leftward).
    /// </summary>
    Left,

    /// <summary>
    /// A key that will perform any behavior associated with holding up (e.g. moving forward).
    /// </summary>
    Up,

    /// <summary>
    /// A key that will perform any behavior associated with holding down (e.g. moving backward).
    /// </summary>
    Down,

    /// <summary>
    /// A key that will pause or unpause the game.
    /// </summary>
    TogglePause,

    /// <summary>
    /// A key that will pick up an item.
    /// </summary>
    PickUpItem,

    /// <summary>
    /// A key that will drop the held item that is currently active.
    /// </summary>
    DropItem,

    /// <summary>
    /// A key that will allow the player to swap which held item is currently active.
    /// </summary>
    SwapItem
}
