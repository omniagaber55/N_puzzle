<h1>N-Puzzle Game Solver using A* Algorithm in C#</h1>
<h2>The project of AI course</h2>
<h4>This project is an implementation of the classic N-Puzzle game solved using the A* search algorithm. The N-Puzzle is a sliding puzzle that consists of a grid of tiles (e.g., 3x3, 4x4) with one tile missing. The goal is to rearrange the tiles from a scrambled initial state to a solved state by sliding the tiles into the empty space.

The A* algorithm is used to find the shortest sequence of moves to solve the puzzle. It employs a heuristic function (Manhattan Distance) to efficiently explore the state space and find the optimal solution.

Features
N-Puzzle Solver: Solves any solvable N-Puzzle configuration.

A* Algorithm: Uses the A* search algorithm with Manhattan Distance as the heuristic.

Customizable Puzzle Size: Supports 3x3, 4x4, or any NxN puzzle size.

Step-by-Step Solution: Displays the sequence of moves to solve the puzzle.

Efficient State Space Search: Uses a priority queue to explore the most promising states first.

How It Works
The puzzle is represented as a 2D array, where 0 represents the empty tile.

The A* algorithm explores possible moves (up, down, left, right) from the current state.

The Manhattan Distance heuristic estimates the cost to reach the goal state.

The algorithm continues until the goal state is reached, and the solution path is returned.</h4>
