﻿public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Create a queue with the following people and priority: Tim (3), Sue (2), George (3), 
        //Bob (5), Lindsay(3) and return the person with the highest priority
        // Expected Result: Bob
        Console.WriteLine("Test 1");
        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Tim", 3);
        priorityQueue.Enqueue("sue", 2);
        priorityQueue.Enqueue("George", 3);
        priorityQueue.Enqueue("Bob", 5);
        priorityQueue.Enqueue("Lindsay", 3);
        priorityQueue.Dequeue();

    
        // Defect(s) Found: I had to wirte a console WriteLine inside the Dequeue function to print the value

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Create a queue with the following people and priority : Tim (2), Sue (1), George (3) 
        // and return the person with the highest priority
        // Expected Result: George
        Console.WriteLine("Test 2");
        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Tim", 2);
        priorityQueue.Enqueue("sue", 1);
        priorityQueue.Enqueue("George", 3);
        priorityQueue.Dequeue();
       
       

        // Defect(s) Found: The for loop was staring at the second element and was  only reaching the 
        //penultimate element

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below

        // Test 3
        // Scenario: Create a queue with the following people and priority : Tim (1), Sue (0), George (1) 
        // Bob(0) and return the person with the highest priority
        // Expected Result: Tim
        Console.WriteLine("Test 3");
        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Tim", 2);
        priorityQueue.Enqueue("sue", 0);
        priorityQueue.Enqueue("George", 1);
        priorityQueue.Enqueue("Bob", 0);
        priorityQueue.Dequeue();

        //Defect(s) Found: No defects Found
        Console.WriteLine("--------");


        // Test 4
        // Scenario: Create a queue with the following people and priority : Tim (-1), Sue (0), George (-3) 
        // and return the person with the highest priority
        // Expected Result: Sue
        Console.WriteLine("Test 4");
        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Tim", -1);
        priorityQueue.Enqueue("sue", 0);
        priorityQueue.Enqueue("George", -3);
        priorityQueue.Dequeue();
       

        //Defect(s) Found: No defects found
        Console.WriteLine("--------");


        // Test 5
        // Scenario: Create an empty queue
        // Expected Result: Error message
        Console.WriteLine("Test 5");
        priorityQueue = new PriorityQueue();
        priorityQueue.Dequeue();

        //Defect(s) Found: No defects found
        Console.WriteLine("--------");
    }
}