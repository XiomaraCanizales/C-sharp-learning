﻿// DO - WHILE STATEMENT
/* Random random = new Random();
int current = 0;

do {
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7); */

// WHILE STATEMENT
/* Random random = new Random();
int current = random.Next(1, 11);

while (current >= 3) {
    Console.WriteLine(current);
    current = random.Next(1, 11);
}

Console.WriteLine($"Last number: {current}"); */

// Use the continue statement to step directly to the Boolean expression 
Random random = new Random();
int current = random.Next(1, 11);

do {
    current = random.Next(1, 11);

    if (current >= 8) continue;

    Console.WriteLine(current);
} while (current != 7);