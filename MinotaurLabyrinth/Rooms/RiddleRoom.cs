namespace MinotaurLabyrinth
{
    /// <summary>
    /// Represents a riddle room, where the hero must solve a riddle to proceed.
    /// </summary>
    public class RiddleRoom : Room
    {
        static RiddleRoom()
        {
            RoomFactory.Instance.Register(RoomType.RiddleRoom, () => new RiddleRoom());
        }

        /// <inheritdoc/>
        public override RoomType Type { get; } = RoomType.RiddleRoom;

        /// <inheritdoc/>
        public override bool IsActive { get; protected set; } = true;

        /// <summary>
        /// Activates the riddle room, presenting the hero with a riddle to solve.
        /// </summary>
        public override void Activate(Hero hero, Map map)
        {
            if (IsActive)
            {
                ConsoleHelper.WriteLine("You enter a dimly lit room adorned with mysterious engravings...", ConsoleColor.Yellow);
                ConsoleHelper.WriteLine("A mystical voice echoes: 'I speak without a mouth and hear without ears. I have no body, but I come alive with the wind. What am I?'", ConsoleColor.Yellow);

                string playerAnswer = Console.ReadLine();

                if (playerAnswer.Equals("Echo", StringComparison.OrdinalIgnoreCase))
                {
                    IsActive = false;
                    ConsoleHelper.WriteLine("The voice booms with approval: 'Correct! The way forward is now revealed.'", ConsoleColor.Green);
                    // Handle the hero's successful progression
                }
                else
                {
                    ConsoleHelper.WriteLine("The voice chuckles: 'Incorrect answer. Your journey ends here.'", ConsoleColor.DarkRed);
                    // Handle the hero's failure and potential consequences
                    if (hero.HasSword)
                    {
                        ConsoleHelper.WriteLine("But wait! You brandish your sword, and the room trembles. The ground beneath you collapses!", ConsoleColor.Cyan);
                        // Transfer the hero to the PitRoom
                        Room pitRoom = RoomFactory.Instance.BuildRoom(RoomType.Pit);
                        hero.TransferToRoom(pitRoom, map);
                    }
                }
            }
        }

        /// <inheritdoc/>
        public override DisplayDetails Display()
        {
            return IsActive ? new DisplayDetails($"[{Type.ToString()[0]}]", ConsoleColor.Yellow)
                            : base.Display();
        }

        /// <summary>
        /// Displays sensory information about the riddle room, based on the hero's distance from it.
        /// </summary>
        /// <param name="hero">The hero sensing the riddle room.</param>
        /// <param name="heroDistance">The distance between the hero and the riddle room.</param>
        /// <returns>Returns true if a message was displayed; otherwise, false.</returns>
        public override bool DisplaySense(Hero hero, int heroDistance)
        {
            if (!IsActive)
            {
                if (base.DisplaySense(hero, heroDistance))
                {
                    return true;
                }
                if (heroDistance == 0)
                {
                    ConsoleHelper.WriteLine("You recall the riddle you solved in this room, now devoid of its mystical aura.", ConsoleColor.DarkGray);
                    return true;
                }
            }
            else if (heroDistance == 1 || heroDistance == 2)
            {
                ConsoleHelper.WriteLine(heroDistance == 1 ? "You sense a riddle. There is a riddle room nearby!" : "Your intuition tells you that something intriguing is nearby", ConsoleColor.DarkGray);
                return true;
            }
            return false;
        }
    }
}
