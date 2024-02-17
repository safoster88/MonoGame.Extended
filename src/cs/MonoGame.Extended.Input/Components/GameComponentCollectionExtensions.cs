namespace MonoGame.Extended.Input.Components;

using Microsoft.Xna.Framework;

/// <summary>
/// A collection of input related extensions for the <see cref="GameComponentCollection"/> class.
/// </summary>
public static class GameComponentCollectionExtensions
{
    /// <summary>
    /// Adds <see cref="MouseExtendedComponent"/> and <see cref="KeyboardExtendedComponent"/> to the <see cref="GameComponentCollection"/>
    /// </summary>
    /// <param name="gcc">The <see cref="GameComponentCollection"/></param>
    public static void AddInputExtendedComponents(
        this GameComponentCollection gcc)
    {
        gcc.Add(new MouseExtendedComponent());
        gcc.Add(new KeyboardExtendedComponent());
    }
}
