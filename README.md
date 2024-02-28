# CME1205-DEU-PBL-I
 Basic C# Game: SHIFT

---



This game is played on a 3x3 board, featuring numbers from 1 to 9. Players take turns, with the Human player initiating the game and the Computer as the opponent. The objective is to gain the maximum score across 5 rounds.

### Game Players

- **Q. Initiator**: A third-party human player who initiates the game by creating a random board with numbers 1 to 9, then exits.
- **Player**: The Human player who starts each round.
- **Computer**: The Computer serves as the opponent.

### Game Initialization

The game initiator provides X and Y coordinates (1-3) for each number from 1 to 9. The board must be randomized and unbiased.

### Game Playing Rules

- Each player has 6 different move types:
  1. Shift the first row of the board to the right.
  2. Shift the second row of the board to the right.
  3. Shift the third row of the board to the right.
  4. Shift the first column of the board downward.
  5. Shift the second column of the board downward.
  6. Shift the third column of the board downward.
  
  Movements are only allowed from left to right or from top to bottom.

- Player's objective:
  1. Achieve 3 consecutive numbers in a row (horizontal, vertical, or diagonal) in either ascending or descending order.
  2. Players can create series using 3 rows, 3 columns, and 2 diagonals. Multiple series can be formed simultaneously.
  
- Scoring:
  - 1 series on the board: 1 point.
  - 2 series on the board: 4 points.
  - 3 series on the board: 9 points.

### Game Progression

1. When a player forms one or more series, the current round ends, and a new round starts. The game comprises 5 rounds.
2. In the first round, the human initiator creates the random board. For subsequent rounds, the computer generates the random board. The Human player starts each round.
3. Players can only gain scores from the board after their move. The initial random board may have series, but no scores can be obtained from them. The board must have 0 series at some point during the round for valid series to be formed.

---

