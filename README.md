<p align="center">
	<a href="https://github.com/Jassi9927/IOT1026-Project/actions/workflows/ci.yml">
    <img src="https://github.com/Jassi9927/IOT1026-Project/actions/workflows/ci.yml/badge.svg"/>
    </a>
	<a href="https://github.com/Jassi9927/IOT1026-Project/actions/workflows/formatting.yml">
    <img src="https://github.com/Jassi9927/IOT1026-Project/actions/workflows/formatting.yml/badge.svg"/>
	<br/>
    <a href="https://codecov.io/gh/Jassi9927/IOT1026-Project" > 
    <img src="https://codecov.io/gh/Jassi9927/IOT1026-Project/branch/main/graph/badge.svg?token=JS0857X5JD"/> 
	<img title="MIT License" alt="license" src="https://img.shields.io/badge/license-MIT-informational?style=flat-square">	
    </a>
</p>

# IOT1026-Project
Write a description of your `Room` and `Monster` class here.

Description of Riddle Room 

Description: A riddle room is a special type of room that presents a riddle or puzzle to the player. It adds an element of mystery and mental challenge to the game. 

1. Riddle Presentation: When the hero enters a RiddleRoom, a riddle is presented to them through the console. The riddle is displayed using `ConsoleHelper.WriteLine`. In this case, the riddle is: "I speak without a mouth and hear without ears. I have no body, but I come alive with the wind. What am I?"

2. Player Input: The hero can input their answer to the riddle through the console using `Console.ReadLine()`. The answer is stored in the `playerAnswer` variable.

3. Correct Answer: If the player's answer matches the correct answer (in this case, "Echo"), the riddle is considered solved. The room's `IsActive` property is set to `false`, indicating that the riddle has been successfully solved. The message "The voice booms with approval: 'Correct! The way forward is now revealed.'" is displayed using `ConsoleHelper.WriteLine`. You can replace this message with the appropriate logic to handle the hero's successful progression, such as unlocking a passage or revealing a hidden item.

4. Incorrect Answer: If the player's answer is incorrect, the riddle room does not deactivate immediately. Instead, the message "The voice chuckles: 'Incorrect answer. Your journey ends here.'" is displayed using `ConsoleHelper.WriteLine`. You can replace this message with the appropriate logic to handle the hero's failure, such as reducing their health or applying other penalties.

5. Sword Interaction: If the hero has a sword (as determined by the `HasSword` property of the `Hero` class), an additional action takes place when the answer is incorrect. The message "But wait! You brandish your sword, and the room trembles. The ground beneath you collapses!" is displayed using `ConsoleHelper.WriteLine`. This indicates that the hero's possession of a sword triggers a special event. In this case, it causes the hero to be transferred to the PitRoom by calling the `TransferToRoom` method of the `Hero` class. You can implement the necessary logic to handle the transfer to the PitRoom and any additional consequences.

6. Display and Sensory Information: The `Display` method is overridden to show a different display for an active RiddleRoom. It returns a `DisplayDetails` object containing the room's display string and color. When the hero senses the RiddleRoom, the `DisplaySense` method is called. It provides sensory information based on the hero's distance from the room. The method displays different messages depending on the distance. For example, when the hero is at a distance of 1 or 2, messages like "You sense a riddle. There is a riddle room nearby!" or "Your intuition tells you that something intriguing is nearby" are displayed using `ConsoleHelper.WriteLine`.


[Assignment Instructions](docs/instructions.md)  
[How to start coding](docs/how-to-use.md)  
[How to update status badges](docs/how-to-update-badges.md)
