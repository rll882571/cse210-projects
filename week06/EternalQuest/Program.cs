using System;

// --- CREATIVITY AND EXCEEDING REQUIREMENTS ---
// English comment: To exceed the core requirements, I have implemented a simple leveling system.
// 1. A player's "Level" is calculated and displayed along with their score. The formula is (score / 1000) + 1.
//    So, 0-999 points is Level 1, 1000-1999 is Level 2, and so on.
// 2. When a player records an event and their score crosses a 1000-point threshold, a "LEVEL UP!"
//    message is displayed to celebrate their progress.
// This adds a fun gamification element to encourage the user.

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}