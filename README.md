# AlphaNumeric_Generator

Project date: 2020

It generates thousand of alphanumeric values and then execute multi-thread function to check for duplicates before appending to the current collection

This is the 1st time I use multi-threading function.

I did a pretty obsolete coding here and don't know how to use cancellation token yet or Task.Run() or what's the purpose of await.

To make a multiple thread I made a function that execute a for loop and inside the for loop is where i call a check function and run it in a new thread every loop.

And to cancel or stop the Thread I use Thread.Abort() method. This is also the project where I learn to use Try Catch to Catch Explosion from my Code. haha
