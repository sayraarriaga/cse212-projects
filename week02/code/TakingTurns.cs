﻿﻿public static class TakingTurns {
    public static void Test() {
        // TODO Problem 1 - Run test cases and fix the code to match requirements
        // Test Cases

        // Test 1
        // Scenario: Create a queue with the following people and turns: Bob (2), Tim (5), Sue (3) and
        // run until the queue is empty
        // Expected Result: Bob, Tim, Sue, Bob, Tim, Sue, Tim, Sue, Tim, Tim
        Console.WriteLine("Test 1");
        var players = new TakingTurnsQueue();
        players.AddPerson("Bob", 2);
        players.AddPerson("Tim", 5);
        players.AddPerson("Sue", 3);
        // Console.WriteLine(players);    // This can be un-commented out for debug help
        while (players.Length > 0)
            players.GetNextPerson();
        /*Defect(s) Found: The "Enqueue" function was adding a persona at the front of the list and not at
         the end. I Just change the Cero index for the variable "Lenght".
        */
        Console.WriteLine("---------");

        // Test 2
        // Scenario: Create a queue with the following people and turns: Bob (2), Tim (5), Sue (3)
        // After running 5 times, add George with 3 turns.  Run until the queue is empty.
        // Expected Result: Bob, Tim, Sue, Bob, Tim, Sue, Tim, George, Sue, Tim, George, Tim, George
        Console.WriteLine("Test 2");
        players = new TakingTurnsQueue();
        players.AddPerson("Bob", 2);
        players.AddPerson("Tim", 5);
        players.AddPerson("Sue", 3);
        for (int i = 0; i < 5; i++) {
            players.GetNextPerson();
            // Console.WriteLine(players);
        }

        players.AddPerson("George", 3);
        // Console.WriteLine(players);
        while (players.Length > 0)
            players.GetNextPerson();

        /* Defect(s) Found: This Defect seems to be fixes with the change i made in the "enqueue" function.
        The Enqueue method was trying to add the person to the front of the queue.
        */
        Console.WriteLine("---------");

        // Test 3
        // Scenario: Create a queue with the following people and turns: Bob (2), Tim (Forever), Sue (3)
        // Run 10 times.
        // Expected Result: Bob, Tim, Sue, Bob, Tim, Sue, Tim, Sue, Tim, Tim
        Console.WriteLine("Test 3");
        players = new TakingTurnsQueue();
        players.AddPerson("Bob", 2);
        players.AddPerson("Tim", 0);
        players.AddPerson("Sue", 3);
        // Console.WriteLine(players);
        for (int i = 0; i < 10; i++) {
            players.GetNextPerson();
            // Console.WriteLine(players);
        }
        /* Defect(s) Found: Tim should have unlimited turns, but he was removed from the list permanently 
         because the "dequeue" function removed people permantly when they had "0" turns.
         So I created an if stament, so people that started with "0" turns could be added back to the
         list.
        */
        Console.WriteLine("---------");

         // Test 4
        // Scenario: Create a queue with the following people and turns: Tim (Forever), Sue (3)
        // Run 10 times.
        // Expected Result: Tim, Sue, Tim, Sue, Tim, Sue, Tim, Tim, Tim, Tim
        Console.WriteLine("Test 4");
        players = new TakingTurnsQueue();
        players.AddPerson("Tim", -3);
        players.AddPerson("Sue", 3);
        // Console.WriteLine(players);
        for (int i = 0; i < 10; i++) {
            players.GetNextPerson();
            // Console.WriteLine(players);
        }
        /* Defect(s) Found: When i create the if stament in the Dequeue function (in the test 3) i just 
        set the stament for persons that started with "0" turns, but in this test "Tim" had "-3" numbers of 
        turns and the program needed to give infinite turns to people that started with "0 or less" number of 
        turns, so i just change the "if stament" from "equal than 0" to "equal or less than 0"
        */

        Console.WriteLine("---------");

        // Test 5
        // Scenario: Try to get the next person from an empty queue
        // Expected Result: Error message should be displayed
        Console.WriteLine("Test 5");
        players = new TakingTurnsQueue();
        players.GetNextPerson();
        // Defect(s) Found:
    }
}