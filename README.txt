The implementation of object pooling keeps us from having to use the expensive processes of Instaiation/destruction of objects in unity.
By having a pool of objects and simply iterating through them as necessary we can optimize our games performance by decreasing the time complexity of operations. The advantage of this method is most
prevalent when we are instantiating/destroying large quantities of similar objects within our scene. Object pooling simply deactivates the gameobjects rather than explicitly calling destroy. 
once the objects are needed again they are placed as necessary in the scene. An importnant note about object pooling is that it should only hold as much objects as you expect to see in the scene at any given time.
I have an Object Pool class whose job is to hold the pool of objects and place them where they're needed at any point in time. it holds up to 10 instances of the object in question and reactivates them after setting it to a certain position.
pressing 'X' will spawn a pellet that you can then pickup again for score

The implementation of the command design pattern is moreso of a functional one. The main strength of the command pattern is that it allows us to attach data to our functions calls that we can then refer back to at runtime. this is a 
very good way to implement undo/redo actions and it also allows us to attach context specific information to a distinct call of of a method. I first created a commandinterface called ICommand. 
This interfaces goal was to give a framework for any command so that they must implement Execute() and Undo(). In this example, you can undo your pellets every time you press 'Z' and it will decrease your score accordingly.

I chose to create a Score Manager for this game. In the case of this manager, it's main purpose is to keep score for every object the player picks up and increment/decrement accordingly.
there is also a score counter which changes on update based on what the players score is.
I implemented it by using a singleton instance and simply incrementing/decrementing score whenever called.