# 🎮 Make Your First Unity Game – Beginner Friendly Guide

Welcome! 👋  
This is a **step-by-step tutorial** designed especially for **beginners** who want to make their **first Unity game**. Whether you're new to game development or just getting started with Unity, this guide will walk you through the process in a simple and clear way.

We’ll be using **Unity** and **Visual Studio 2022**, and all code changes will be documented right here as commits are made.  

The Tutorial is been inspired from <a href="http://www.youtube.com/@GMTK">Game Maker's Toolkit's</a> video, <a href="https://www.youtube.com/watch?v=XtQMytORBmM">Click here to watch</a>.

---

## 🛠️ 1. Getting Started

1. Download and Install **Unity** for your device from <a href="https://unity.com/download">here.</a>
2. Also Download and Install **Visual Studio 2022 IDE** from <a href="https://visualstudio.microsoft.com/vs/">Here<a>.
3. Make sure you have Installed **Unity Hub** as well as **Unity Editor (Latest Version)**.
4. Github(For Version Control)

## 📁 2. Setting Up Your Unity Project

1. Open Unity Hub > New Project.
2. Navigate to "Core" > Universal 2D.
3. Name your project.
4. Click "Create".

## 🧭 3. Understanding the Unity User Interface (UI)

When you open Unity, the layout might seem overwhelming at first — but don't worry, it's easy once you know what each panel does. Here's a quick breakdown:

### 🔳 Scene View
- This is your "workspace" — where you design and build your game.
- You can drag, move, rotate, and scale GameObjects here.
- Think of it like your level editor.

### 🎮 Game View
- This shows what the player will see when they play the game.
- Hit the ▶️ (Play) button at the top to preview the game in this window.

### 🧱 Hierarchy
- Lists **all GameObjects** in your current Scene.
- This is where you’ll find things like the Camera, Lights, and your Player object.
- You can drag things in and out to organize objects (like putting enemies inside a folder called "Enemies").

### ⚙️ Inspector
- When you select any GameObject, its properties show up here.
- You can change the position, size, color, add scripts, colliders, and more from this panel.

### 📁 Project
- This is your file manager inside Unity.
- Everything you import or create (scripts, images, audio, etc.) lives here in folders.

### 💬 Console
- Displays messages like errors, warnings, and print/debug logs from your scripts.
- Super useful for finding issues in your game.

---

🔄 **Tip:** You can rearrange or reset the layout anytime:  
Go to `Window > Layouts > Default` if something gets messed up.

---

## 🧩 4. Adding Your First GameObject

Now that you're familiar with the Unity interface, let's start adding things to your game!

### 📥 Importing Assets
To bring in images, sounds, or other files into Unity:
1. Find the **Assets** tab in the **Project** window.
2. Simply **drag and drop** your image (like a character sprite) into the Assets folder.
3. Unity will automatically import it and make it available to use in your scene.

> 📝 Tip: You can also organize your assets by creating folders like `Images`, `Audio`, `Prefabs`, and `Scripts`.

---

### 🎭 Creating a GameObject

1. Go to the **Hierarchy** window.
2. Right-click > `Create Empty`.
3. A new empty GameObject will appear in your Scene. Let's rename it to `Barb`:
   - Click the GameObject, press `F2` (or right-click > Rename).
   - Type `Barb` and hit Enter.

---

### 📌 Centering the Object Using the Inspector

1. With `Barb` selected, go to the **Inspector** tab.
2. Find the **Transform** component.
3. Set the **Position** values (X, Y, Z) to `0`, so it sits in the center of the canvas.

```text
Position: X = 0 | Y = 0 | Z = 0
```
#### 🎯 Pro Tip: You can also use the move tool (press W) in the Scene view to drag it around manually.

---

## 🎨 5. Making Your GameObject Visible – Adding a Sprite

Right now, `Barb` is just an empty GameObject — it doesn’t show up in the Scene because it has no visual component. Let’s fix that by adding a **Sprite Renderer** and assigning an image (sprite) to it.

---

### ➕ Add a Sprite Renderer Component

1. Select the `Barb` GameObject in the **Hierarchy**.
2. In the **Inspector**, click the **Add Component** button at the bottom.
3. Search for and select `Sprite Renderer`.

> This tells Unity: “Hey, I want this object to display an image.”

---

### 🖼️ Assign the Barb Sprite

1. In your **Project > Assets** folder, locate the sprite image you imported earlier (for example: `barb.png`).
2. Drag and drop the sprite into the **Sprite** field of the Sprite Renderer component (in the Inspector).

Once you do this, your `Barb` object will now be visible in the Scene!

> ✅ If the image doesn't appear, make sure the Sprite’s **Texture Type** (in the Import Settings) is set to `Sprite (2D and UI)`.

If the Sprite is not Visible, try changing the Position Value for Z of either **Main Camera** or **Barb**.
Now `Barb` has a visual — you're one step closer to bringing your character to life! 🎉

---

## 🐦 6. Adding Physics and a Script to Your Bird

Now that we know how to add visual components, let’s make our GameObject interactive — like giving it **gravity** and letting it detect **collisions**. We’ll also attach a script so we can start coding behavior.

---

### 🧲 Adding Physics to the Bird

1. In the **Hierarchy**, select your `Bird` GameObject (make sure you’ve created and named it).
2. In the **Inspector**, click **Add Component**.
3. Search for and add **Rigidbody 2D** – this gives your GameObject physics like gravity and movement.
4. Again, click **Add Component**, search for and add **Circle Collider 2D** – this lets the Bird detect collisions using a circular hitbox.

> 🧠 **Why these?**  
> - `Rigidbody 2D`: Makes the Bird fall or respond to forces.
> - `Circle Collider 2D`: Lets it bump into things or trigger events when it hits other objects.

---

### 💻 Attaching a Script

1. With the Bird still selected, click **Add Component**.
2. Search for **New Script**, name it something like `BirdController`, and click **Create and Add**.
3. In the **Inspector**, double-click the script to open it in **Visual Studio 2022 IDE**.

---

### ✍️ Understanding the Script Template

Once the script opens, you’ll see something like this:

```csharp
using UnityEngine;

public class BirdController : MonoBehaviour
{
    void Start()
    {
        // This runs once when the game starts
    }

    void Update()
    {
        // This runs every frame (continuously)
    }
}
```
---

## ✏️ 7. Modifying GameObject Properties in Code

Let’s start writing actual logic inside our script to change properties of our Bird GameObject!

---

### 🐦 Renaming the GameObject via Script

In Unity, `gameObject` refers to **the object this script is attached to** — in our case, the Bird.

Let’s change the name of our Bird from `Bird` to something like `FlappyBird` using the **Start()** function.

Inside `BirdController.cs`, modify the `Start()` method like this:

```csharp
void Start()
{
    gameObject.name = "FlappyBird";
}
```

#### 🧠 This line runs once when the game begins and renames the object in the Hierarchy view.

### 🔍 Understanding the Inspector & Accessing Components
The Inspector view shows all the components attached to a GameObject — like Transform, Rigidbody2D, Collider, Sprite Renderer, and any scripts.

Right now, your script can only directly access:

 - gameObject

 - transform (for position, rotation, scale)

But what if we want to control other components like:

 - Rigidbody2D (for movement, gravity)

 - Collider2D (for detecting collisions)

 - SpriteRenderer (for changing visuals)

To do this, we need to create references to those components using code.

---

## 🕹️ 8. Making the Bird Flap with Spacebar Input

Now let’s make our bird move only **when we press the spacebar** — just like in Flappy Bird. We'll be using Unity’s **Rigidbody2D** component and writing code inside the `Update()` method.

---

### ⚙️ Accessing Rigidbody2D in Script

Before we can control the bird’s physics, we need to create a reference to its Rigidbody2D component.

At the **top of your script (but inside the class)**, add this line:

```csharp
public float flapStrength;
```

Now inside the `Update()` method, we’ll apply a velocity to the Rigidbody2D when the spacebar is pressed:
```csharp
void Update()
{
    if (Input.GetKeyDown(KeyCode.Space))
    {
        myRigidbody.linearvelocity = Vector2.up * flapStrength;
    }
}
```

 - `Input.GetKeyDown(KeyCode.Space)` detects when you press the spacebar.

 - `Vector2.up * flapStrength` applies force in the upward direction.

 - `.velocity` sets the linear velocity, which moves the bird.

> ⚠️ Right now, each spacebar press will make the bird flap upward. Without pressing, gravity (from Rigidbody2D) pulls the bird down.

---

🔧 Set flapStrength in Unity
Since `flapStrength` is marked `public`, it appears in the Unity Inspector.

1. Click on the **Bird** GameObject.
2. In the Inspector, you’ll see your **BirdController** script.
3. Set Flap Strength to something like 5 or 10 — play around with it to get the right feel.

---

## 🚧 9. Creating the Pipe Obstacle

Let’s add the classic Flappy Bird pipes as obstacles. We'll set up a **parent GameObject** with two child objects: **Top** and **Bottom** pipes. Each child will have its own sprite and collider.

---

### 🧱 Step 1: Create the Pipe Parent Object

1. In the **Hierarchy**, right-click > `Create Empty`.
2. Rename the new GameObject to `Pipe`.

This will act as the container for both the top and bottom pipes.

---

### 🌲 Step 2: Create the Top Pipe

1. Right-click on `Pipe` > `Create Empty` again — this makes a child object.
2. Rename this child to `Top`.
3. With `Top` selected, click **Add Component**:
   - Add a **Sprite Renderer** – this is how we display the image.
   - Add a **Box Collider 2D** – this lets the bird detect and react to the pipe.
4. In the **Sprite Renderer**, drag and drop your pipe sprite image into the **Sprite** field.

> ✅ No need to add `Rigidbody 2D` since the pipes are stationary — they don’t need physics like gravity.

---

### 🔁 Step 3: Duplicate and Flip for the Bottom Pipe

1. Right-click the `Top` object > **Duplicate** (or press `Ctrl + D`).
2. Rename the duplicated object to `Bottom`.
3. Select the `Bottom` pipe and go to the **Inspector**.
4. Change the **Scale Y** value to `-1` — this flips the pipe upside down so it faces downward.

> 🎨 Both pipes will now share the same sprite, but flipped to face each other.

---

## 🏗️ 10. Spawning and Moving Pipes (Like an Endless Runner)

In Flappy Bird, it’s not the bird that flies forward — instead, the world (pipes) scrolls towards the bird. We can simulate this by moving our `Pipe` GameObjects to the **left** constantly.

---

### 🧠 Why Move the Pipes?

The bird stays still on the **X-axis** and only moves **up/down**. To create the illusion of movement, we’ll scroll the obstacles from right to left.

---

### 💻 Step 1: Create a Script to Move the Pipes

1. In your **Scripts** folder, create a new script called `PipeSpawner`.
2. Attach this script to the **Pipe** parent GameObject.
3. Double-click to open it in **Visual Studio 2022 IDE**.

Inside the script, write this:

```csharp
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
    }
}
```
🔍 What’s Happening Here?
 - `transform.position += Vector3.left * moveSpeed;`: Moves the object left by moveSpeed every frame.

 - **Problem**: This would move faster on high-end devices because Update() runs more often on them.

 - ✅ Solution: Multiply by `Time.deltaTime`, which is the time that has passed since the last frame.

> 🎯 Time.deltaTime makes the movement frame-rate independent — ensuring all devices scroll at the same speed.

Let’s fix that so our game behaves the same on **every device**.

---

### 💡 What is `Time.deltaTime`?

`Time.deltaTime` is the amount of **time (in seconds)** that passed **since the last frame**.

So if your game runs at:
- 60 FPS ➜ `deltaTime` ≈ 0.016 seconds
- 30 FPS ➜ `deltaTime` ≈ 0.033 seconds

By multiplying your movement by `deltaTime`, you make it **time-based** instead of **frame-based** — much smoother and consistent.

---

### 🛠️ Step-by-Step Fix

Open your `PipeSpawner` script and update the `Update()` method like this:

```csharp
void Update()
{
    transform.position += Vector3.left * moveSpeed * Time.deltaTime;
}
```

> ✅ This ensures your pipes move at `moveSpeed` units per second, regardless of how fast `Update()` is called.

---

## 🧱 12.. Creating and Using Prefabs in Unity

Before we can spawn multiple pipes over time, we need to understand **Prefabs** — one of Unity’s most powerful tools!

---

### 💡 What is a Prefab?

A **Prefab** is like a **blueprint** of a GameObject. Once something is turned into a prefab, Unity can easily **clone (instantiate)** it anytime during gameplay.

Think of it like a cookie cutter — the prefab is the cutter, and each clone is a cookie 🍪.

---

### 🛠️ Step-by-Step: Creating a Pipe Prefab

1. In the **Hierarchy**, find your complete `Pipe` GameObject (the one with `Top` and `Bottom` as children).
2. **Drag and drop** this `Pipe` object into the **Assets** panel (at the bottom of the screen).
3. You’ll now see a blue version of your object — that’s your **Prefab**!

> 🎯 Now Unity can use this blueprint to spawn new pipes during gameplay.

---

### 🧪 Step: Setting Up the Spawner GameObject

1. Create an **Empty GameObject** in the **Hierarchy**.
2. Rename it to `PipeSpawner`.
3. Create a new C# script and name it `PipeSpawner.cs`.
4. Attach the script to the `PipeSpawner` GameObject.

Inside the script, we need a way to **reference the prefab** so Unity knows *what to clone*:

```csharp
public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe; // Drag the prefab here in the Editor
}
```
🔗 Final Step: Linking the Prefab to the Script
Unity doesn’t automatically know which GameObject you mean — so you must **manually assign the reference**:

1. Click on the **PipeSpawner** GameObject in the Hierarchy.
2. Look at the Inspector — you’ll see a slot labeled **Pipe** under the **PipeSpawner** script.
3. Drag your **Pipe Prefab** from the Assets folder into this slot.


---

## 🚀 13. Building the Pipe Spawner from Scratch

Let’s now bring everything together and build the complete **Pipe Spawner** logic step-by-step.

We'll go from a **basic version** to a more **efficient and clean version**.

---

### 🔨 Step 1: Basic Pipe Spawning (Raw Version)

In the `PipeSpawner.cs` script attached to the `PipeSpawner` GameObject, start with the raw logic:

```csharp
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe; // Link your prefab in the Inspector

    void Update()
    {
        Instantiate(pipe, transform.position, transform.rotation);
    }
}
```
> 🔁 Warning: When you press Play, you’ll see a flood of pipes! That’s because Update() runs every frame — and we’re instantiating a pipe each time.

---

### ⏳ Step 2: Add a Timer and Spawn Rate
To slow down the spawning, we’ll add two new variables:
 - `spawnRate`: How often a pipe should spawn (in seconds).

 - `timer`: Keeps track of time since the last spawn.

Update your script like this:

```csharp
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 5f;
    private float timer = 0f;

    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            Instantiate(pipe, transform.position, transform.rotation);
            timer = 0f;
        }
    }
}
```
> 🕒 Now, pipes will spawn every `spawnRate` seconds — much more controlled!

---

### 🧼 Step 3: Clean Up with a `Spawn()` Function
To avoid repeating code and keep things clean, let’s move the spawning logic into a reusable function:
```csharp
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 5f;
    private float timer = 0f;

    void Start()
    {
        Spawn(); // Spawn one pipe immediately when the game starts
    }

    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            Spawn();
            timer = 0f;
        }
    }

    void Spawn()
    {
        Instantiate(pipe, transform.position, transform.rotation);
    }
}
```

---

> 🎉 This structure is modular, readable, and efficient — your first big step into writing maintainable game code!

---

## 🎲 14. Randomizing Pipe Spawn Heights

Right now, all the pipes spawn at the **exact same height** — making the game super predictable and… boring 😴.

Let’s spice things up by adding **random vertical offsets** to each spawned pipe!

---

### 🧠 Idea: Randomize the Y-Coordinate

We’ll give each pipe a **random vertical position** when it spawns — but keep it within a reasonable range so the game stays playable.

---

### 🛠️ Step-by-Step Instructions

#### 1. Add a Height Offset Variable

Open your `PipeSpawner.cs` script and add this new variable at the top:

```csharp
public float heightOffset = 10f;
```
This is how far up and down we allow the pipes to randomly shift.

---

#### 2. Modify the Spawn() Function

Update your function like this:
```csharp
void Spawn()
{
    float lowestPoint = transform.position.y - heightOffset;
    float highestPoint = transform.position.y + heightOffset;

    Vector3 spawnPosition = new Vector3(
        transform.position.x,
        Random.Range(lowestPoint, highestPoint),
        0f // Because we're in 2D
    );

    Instantiate(pipe, spawnPosition, transform.rotation);
}
```
#### 🧠 Why Use Vector3?
Even though we’re making a 2D game, Unity still expects positions to be in Vector3 format because its engine is 3D under the hood. We just leave the Z-axis at `0`.

#### ✅ Result
Now every time a pipe spawns, it appears at a different Y position — making your game much more engaging and challenging!

> 🎉 Try adjusting the `heightOffset` in the Inspector to make the pipes easier or harder to dodge.

---

## 🧹 16. Deleting Off-Screen Pipes (Performance Boost)

Your game now spawns pipes beautifully, but there’s a hidden problem…

> 😨 Pipes that go off-screen to the left are **still in memory**, taking up resources!

If you leave them piling up, your game will eventually lag or even crash.

Let’s fix that by **automatically deleting pipes** once they pass the player.

---

### 🧠 Idea

We want to destroy the pipe **once it moves too far left** — outside the camera's view.

---

### 🛠️ Step-by-Step Instructions

#### 1. Open the `Pipe` Script

This is the same script where you handled `moveSpeed`. It should be attached to the **parent pipe prefab**.

#### 2. Add a `deadZone` Variable

At the top of your script, add:

```csharp
public float deadZone = -10f; // Adjust this based on your camera view
```
This is the X-position beyond which a pipe is considered "dead."

#### 3. Check in the `Update()` Function
Now update your `Update()` function like this:

```csharp
void Update()
{
    transform.position += Vector3.left * moveSpeed * Time.deltaTime;

    if (transform.position.x < deadZone)
    {
        Debug.Log("Pipe Deleted"); // Optional: for debugging
        Destroy(gameObject);
    }
}
```
####✅ Done! Now You're Saving Memory
Every pipe that leaves the screen on the left will be automatically destroyed, keeping your game clean and efficient.

> 🧠 Pro Tip: You can also use Unity's `OnBecameInvisible()` function for more advanced optimization later!
