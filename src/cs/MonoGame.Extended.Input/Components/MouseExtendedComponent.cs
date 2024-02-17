namespace MonoGame.Extended.Input.Components;

using Microsoft.Xna.Framework;

/// <summary>
/// Will update <see cref="MouseExtended"/> states when added to the GameComponents list
/// </summary>
public class MouseExtendedComponent : SimpleGameComponent
{
    /// <summary>
    /// Will update <see cref="MouseExtended"/> states when added to the GameComponents list
    /// </summary>
    /// <param name="gameTime"></param>
    public override void Update(GameTime gameTime) => MouseExtended.Refresh();
}
