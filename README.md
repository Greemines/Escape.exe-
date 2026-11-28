# Escape.exe: The Cyber Vault

> Trapped inside a locked cyber vault. Crack the codes, beat the clock, find the exit.

A programming puzzle escape game built in **C# Windows Forms** for the **Visual Programming** semester project (BSE 5A, Bahria University).

## Team CodeBreakers

| Member | Registration No. |
|---|---|
| Minahil Chaudhry | 09-131242-045 |
| Javeria Lodhi | 09-131242-033 |

**Submitted to:** Miss Raheela Ambrin

## Responsibilities

### Minahil Chaudhry
- **Room 2: Missing Keyword** (Easy)
- **Room 4: Logic Gate Switches** (Hard)
- **Final Room:** exit-code check
- **GameSession:** shared 15-minute countdown timer that keeps running across all rooms
- **PuzzleBank:** question banks for Rooms 2 and 4, and the random exit-code digits
- **Scoring, Leaderboard & JSON storage** (`scores.json`)

### Javeria Lodhi
- **Room 1: Binary Door** (Easy)
- **Room 3: Caesar Cipher** (Medium)
- **Room 5: Algorithm Trace** (Hard)
- **Start screen** with name validation, and navigation between forms
- **PuzzleBank:** question generators for Rooms 1, 3 and 5
- **Hint system & wrong-answer penalty**
- **Result screen** (Escaped / Game Over)

### Shared by both
Visual theme, input validation, GitHub, testing and bug fixing, final report and project demonstration.

## About the Game

The player is trapped inside a locked cyber vault and must clear five security rooms before a **15-minute** countdown reaches zero. Each room is protected by a computing challenge that gets harder as you go. Solving a room unlocks the next one and reveals one digit of the final exit code. Every attempt is saved to a local leaderboard.

## The Rooms

| Room | Challenge | Difficulty | How the player answers |
|---|---|---|---|
| R1 | **Binary Door:** convert a 4-bit binary number to decimal | Easy | TextBox + Submit |
| R2 | **Missing Keyword:** choose the C# keyword that completes a line of code | Easy | ComboBox with 4 options |
| R3 | **Caesar Cipher:** decode a word shifted 1 to 5 places | Medium | TextBox |
| R4 | **Logic Gate Switches:** set 4 switches so all 3 lamps turn green | Hard | 4 CheckBoxes, lamps change colour |
| R5 | **Algorithm Trace:** write the array after one pass of bubble sort | Hard | TextBox |
| Final | **Exit Code:** enter the 5 digits collected from the rooms | — | TextBox, no hints allowed |

Every game picks new random questions for every room and a new random exit code, so answers can't be memorised.

## Features

- Player name entry with validation
- 15-minute countdown with a draining ProgressBar that continues across rooms
- 3 hints per game (−50 points each, not allowed in the Final Room)
- Wrong-answer penalty: every 3 wrong answers in a room cost 30 seconds
- Random puzzle versions from question banks and code generators
- Score and Result screen (Escaped / Game Over)
- Top 10 leaderboard saved to `scores.json`
- Input validation on every screen

## Scoring

score = (rooms solved × 200) + seconds remaining − (hints used × 50)

Ties on the leaderboard are broken by the faster time.

## Built With

- **Language:** C#
- **Framework:** .NET 10 · Windows Forms
- **IDE:** Visual Studio Community 2026
- **Storage:** Local JSON file (`System.Text.Json`)
- **Version control:** Git & GitHub

## How to Run

1. Install **Visual Studio 2026** with the **.NET desktop development** workload.
2. Clone this repository:
   git clone https://github.com/Greemines/Escape.exe-.git
3. Open `EscapeExe.slnx` in Visual Studio.
4. Press **F5** to build and run.

## Project Proposal

The full proposal is included in this repository: `Escape. exe Project Proposal.pdf`
