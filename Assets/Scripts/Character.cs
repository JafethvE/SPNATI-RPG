//Base class for sentient entities in the game.
public class Character : Entity {

    public int HP { get; }//The amount of HP the Character currently has.

    public int MaxHP { get; }//The maximum amout of HP this Character can have (barring special powers).

    public int Level { get; }//The current level of the character.

    public int XP { get; }//The amount of XP this character has.

    /*
     * Returns the amount of XP the character still needs to level up.
     */
    public int XPForNextLevel()
    {
        return 0;
    }
}
