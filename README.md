the goal of which is to knock down all the presents on the field with the help of a snowman and colorful candy.

Field: GameBoard object - Plane primitive. Set the field to the maximum "slipperiness".

Gifts: 6 white gifts with colored ribbons. At game start, spawn at a random location on the game board and receive one of the colors (red, blue, green) at random. The colors should be easily customizable.
Immobile. React to the collision with the snowman as follows: if the color of the gift ribbon coincides with the color of the snowman's hat, the gift is destroyed, otherwise nothing happens, and the snowman just crashes and bounces off the gift.

Candy: fixed with the "trigger" property. When the game starts, it is in a random place on the game board and randomly receives one of the three game colors. Reacts to the collision with the snowman as follows: changes the color of the snowman's hat to his own, moves to another random place on the playing field, again randomly gets one of the above three colors.

Snowman: at the start of the game is in the center of the platform. Movable, physical. At the start of the game the hat is gray in color. Interacts with gifts and candy in the above manner. When reaching the borders of the field, the snowman must "bounce" from them. When you press the LKM, a force of X (*needs to find a suitable value, not too big and not too small) units is applied to it using the AddForce() method in the direction of the cursor at the moment of pressing.

Camera: "Looks" from top to bottom on the playing field, stationary.



https://github.com/ArsenPetrossov/Bouncer_game-/assets/157959288/43938423-f954-46be-9abf-b0c566bfb46f


add UI 



https://github.com/ArsenPetrossov/Bouncer_game-/assets/157959288/6bbd3878-c6e2-4343-9ae8-89fe3450679c

